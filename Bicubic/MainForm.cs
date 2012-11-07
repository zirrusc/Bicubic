using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.Drawing.Imaging;

namespace Bicubic
{
    public partial class MainForm : Form
    {
		//public const string bmpExtension = "bmp";
		//public const string[] Filter = "ビットマップイメージ|*.bmp";
		private const string btnCloseText = "閉じる(&C)";
		private const string btnCancelText = "キャンセル(&C)";
		private const string filterImageString = "イメージ|";
		private const string filterAsterisk = "*";
		private string filter = ResizeImage.SupportExtensionFilter;

		private const bool isShowLinkLabel = false;

		private string formerFileName;
		private int formerWidth;
		private int formerHeight;

		private ResizeImage ri;

		View v;
		private bool isShowView;

		private bool isCheckInput = true;


		private BackgroundWorker bgwSave = new BackgroundWorker();
		private BackgroundWorker bgwCheckInput = new BackgroundWorker();

        public MainForm()
        {
            InitializeComponent();

			bgwSave.DoWork += new DoWorkEventHandler(Save_DoWork);
			bgwSave.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Save_RunWorkerCompleted);
			bgwCheckInput.DoWork += new DoWorkEventHandler(bgwCheckInput_DoWork);
			bgwCheckInput.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwCheckInput_RunWorkerCompleted);

			//progressBar1.Visible = false;
			isReadyStart = Status.NotReady;
			cbbUnit.SelectedIndex = 0;
			chkMaintainAspectRatio.Checked = true;
			isShowView = false;
			nudX.Value = nudY.Value = 100;
			linkLabel1.Visible = isShowLinkLabel;
			status = "";
			v = new View();
			v.Show();
		}

		private enum Status
		{
			NotReady, Ready, Processing
		}

		private Status _isReadyStart;

		private Status isReadyStart
		{
			set
			{
				switch (value)
				{
					case Status.NotReady:
						btnStart.Enabled = false;
						btnClose.Text = btnCloseText;
						//progressBar1.Enabled = false;
						break;
					case Status.Ready:
						btnStart.Enabled = true;
						btnClose.Text = btnCloseText;
						//progressBar1.Enabled = false;
						break;
					case Status.Processing:
						btnStart.Enabled = false;
						btnClose.Text = btnCancelText;
						//progressBar1.Enabled = true;
						break;
				}
				_isReadyStart = value;
			}
			get
			{
				return _isReadyStart;
			}
		}

		private string status
		{
			set
			{
				lblStatus.Text = value;
			}
			get
			{
				return lblStatus.Text;
			}
		}

        private void btnStart_Click(object sender, EventArgs e)
        {
			Accept(true);
        }

		private void Accept(bool isSave, bool isForce = false)
		{
			if (isReadyStart == Status.Ready || isForce)
			{
				isReadyStart = Status.Processing;
				try
				{
					int width, height;
					if ((string)cbbUnit.SelectedItem == "px")
					{
						width = (int)nudX.Value;
						height = (int)nudY.Value;
					}
					else
					{
						// by %
						width = (int)((double)nudX.Value / 100d * (double)formerWidth);
						height = (int)((double)nudY.Value / 100d * (double)formerHeight);
					}
					if (ri == null) ri = new ResizeImage(txtFile.Text);
					ri.CreateImage(width, height,
						InterpolationMode.HighQualityBicubic);
					v.SetImage(ri.AfterImage);
					if (isSave)
					{
						//isReadyStart = Status.Processing;
						status = "保存しています...";
						string save = txtSaveAs.Text;
						if (bgwSave.IsBusy == false)
						{
							//bgwSave = new BackgroundWorker();
							saveArgs = new bgwSaveArgs(txtFile.Text, txtSaveAs.Text);
							bgwSave.RunWorkerAsync();
						}
						else
						{
							status = "すでに保存中です";
						}
						//isReadyStart = Status.Ready;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					isReadyStart = Status.Ready;
				}
			}
		}

		struct bgwSaveArgs
		{
			public string File;
			public string Save;

			public bgwSaveArgs(string file, string save)
			{
				File = file;
				Save = save;
			}
		}

		bgwSaveArgs saveArgs;

		void Save_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				string file = saveArgs.File;
				string save = saveArgs.Save;
				if (Path.GetExtension(save) == "")
				{
					save += Path.GetExtension(file);
				}
				ri.SaveImage(save);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		void Save_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			status = "保存しました";
		}

        private void btnReferFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = formerFileName = ofd.FileName;
            }
        }

        private void btnReferSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = filter;
			sfd.FileName =　txtSaveAs.Text == "" ? Path.GetFileName(txtFile.Text) : txtSaveAs.Text;
			ImageFormat format = null;
			try
			{
				format = ResizeImage.GetFormat(sfd.FileName);
			}
			catch (Exception)
			{}

			int index;
			if (format == ImageFormat.Bmp)
			{
				index = 0;
			}
			else if (format == ImageFormat.Jpeg)
			{
				index = 1;
			}
			else if (format == ImageFormat.Gif)
			{
				index = 2;
			}
			else if (format == ImageFormat.Tiff)
			{
				index = 3;
			}
			else if (format == ImageFormat.Png)
			{
				index = 4;
			}
			else
			{
				index = 5;
			}
			sfd.FilterIndex = index + 1;
			sfd.Title = "保存先を選んでください";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtSaveAs.Text = sfd.FileName;
            }
        }

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (ri != null) ri.Dispose();
			if (v != null) v.Dispose();
			if (bgwSave != null) bgwSave.Dispose();
			if (bgwCheckInput != null) bgwCheckInput.Dispose();
		}

		private void txtFile_TextChanged(object sender, EventArgs e)
		{
			if (File.Exists(txtFile.Text) && ResizeImage.SupportExtensionFilter.Contains(Path.GetExtension(txtFile.Text)))
			{
				pictureBox1.Image = new Bitmap(txtFile.Text);
				formerFileName = txtFile.Text;
				formerWidth = pictureBox1.Image.Width;
				formerHeight = pictureBox1.Image.Height;
				v.SetImage(formerFileName);
				isShowView = true;
				if (txtSaveAs.Text == "")
				{
					isCheckInput = false;
					txtSaveAs.Text = Path.GetDirectoryName(txtFile.Text) + @"\out" + Path.GetExtension(txtFile.Text);
					isCheckInput = true;
				}
			}
			else
			{
				pictureBox1.Image = null;
				formerFileName = null;
				formerWidth = 0;
				formerHeight = 0;
				isShowView = false;
			}
			CheckInput();
		}

		private void txtSaveAs_TextChanged(object sender, EventArgs e)
		{
			if (isCheckInput) CheckInput();
		}

		private void nudX_ValueChanged(object sender, EventArgs e)
		{
			if (isCheckInput)
			{
				if (chkMaintainAspectRatio.Checked && formerFileName != null)
				{
					isCheckInput = false;
					if ((string)cbbUnit.SelectedItem == "px")
					{
						nudY.Value = formerHeight * nudX.Value / formerWidth;
					}
					else
					{
						nudY.Value = nudX.Value;
					}
					isCheckInput = true;
				}
				CheckInput();
				if (isShowView) Accept(false, true);
			}

		}

		private void nudY_ValueChanged(object sender, EventArgs e)
		{
			if (isCheckInput)
			{
				if (chkMaintainAspectRatio.Checked && formerFileName != null)
				{
					isCheckInput = false;
					if ((string)cbbUnit.SelectedItem == "px")
					{
						nudX.Value = formerWidth * nudY.Value / formerHeight;
					}
					else
					{
						nudX.Value = nudY.Value;
					}
					isCheckInput = true;
				}
				CheckInput();
				if (isShowView) Accept(false, true);
			}
		}

		private void CheckInput()
		{
			if (bgwCheckInput.IsBusy == false && isCheckInput == true)
			{
				isCheckInput = false;
				inputArgs = new bgwCheckInputArgs(txtFile.Text, txtSaveAs.Text, nudX.Value, nudX.Value);
				bgwCheckInput.RunWorkerAsync();
			}
		}

		struct bgwCheckInputArgs
		{
			public string File;
			public string Save;
			public decimal X;
			public decimal Y;

			public bgwCheckInputArgs(string file, string save, decimal x, decimal y)
			{
				File = file;
				Save = save;
				X = x;
				Y = y;
			}
		}

		bgwCheckInputArgs inputArgs;
		Status nowReady;
		void bgwCheckInput_DoWork(object sender, DoWorkEventArgs e)
		{
			nowReady = _CheckInput();
			// if (isReadyStart != nowReady) isReadyStart = nowReady;
		}

		void bgwCheckInput_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (isReadyStart != nowReady) isReadyStart = nowReady;
			isCheckInput = true;
		}

		private Status _CheckInput()
		{
			string file = inputArgs.File;
			string save = inputArgs.Save;
			decimal X = inputArgs.X;
			decimal Y = inputArgs.Y;
			string extension = Path.GetExtension(file).ToLower();
			string allowExtension = ResizeImage.SupportExtensionFilter;

			if (!File.Exists(file) && !allowExtension.Contains(extension))
			{
				return Status.NotReady;
			}
			if (Directory.Exists(save) || save == "")
			{
				return Status.NotReady;
			}
			//if (file == save)
			//{
			//    return Status.NotReady;
			//}
			if (X == 0 || Y == 0)
			{
				return Status.NotReady;
			}
			return Status.Ready;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://sites.google.com/site/curlcloud/app/bicubic");
		}

		private void cbbUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isShowView) Accept(false, true);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
    }
}
