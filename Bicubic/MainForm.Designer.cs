namespace Bicubic
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSaveAs = new System.Windows.Forms.TextBox();
			this.btnReferFile = new System.Windows.Forms.Button();
			this.btnReferSaveAs = new System.Windows.Forms.Button();
			this.nudX = new System.Windows.Forms.NumericUpDown();
			this.groupBoxSize = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chkMaintainAspectRatio = new System.Windows.Forms.CheckBox();
			this.cbbUnit = new System.Windows.Forms.ComboBox();
			this.nudY = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.lblStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
			this.groupBoxSize.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "補間するファイル(&F):";
			// 
			// txtFile
			// 
			this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.txtFile.Location = new System.Drawing.Point(144, 12);
			this.txtFile.Name = "txtFile";
			this.txtFile.Size = new System.Drawing.Size(255, 25);
			this.txtFile.TabIndex = 1;
			this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "保存先(&A):";
			// 
			// txtSaveAs
			// 
			this.txtSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSaveAs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSaveAs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.txtSaveAs.Location = new System.Drawing.Point(144, 43);
			this.txtSaveAs.Name = "txtSaveAs";
			this.txtSaveAs.Size = new System.Drawing.Size(255, 25);
			this.txtSaveAs.TabIndex = 4;
			this.txtSaveAs.TextChanged += new System.EventHandler(this.txtSaveAs_TextChanged);
			// 
			// btnReferFile
			// 
			this.btnReferFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReferFile.Location = new System.Drawing.Point(405, 13);
			this.btnReferFile.Name = "btnReferFile";
			this.btnReferFile.Size = new System.Drawing.Size(46, 23);
			this.btnReferFile.TabIndex = 2;
			this.btnReferFile.Text = "...";
			this.btnReferFile.UseVisualStyleBackColor = true;
			this.btnReferFile.Click += new System.EventHandler(this.btnReferFile_Click);
			// 
			// btnReferSaveAs
			// 
			this.btnReferSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReferSaveAs.Location = new System.Drawing.Point(405, 44);
			this.btnReferSaveAs.Name = "btnReferSaveAs";
			this.btnReferSaveAs.Size = new System.Drawing.Size(46, 23);
			this.btnReferSaveAs.TabIndex = 5;
			this.btnReferSaveAs.Text = "...";
			this.btnReferSaveAs.UseVisualStyleBackColor = true;
			this.btnReferSaveAs.Click += new System.EventHandler(this.btnReferSaveAs_Click);
			// 
			// nudX
			// 
			this.nudX.Location = new System.Drawing.Point(33, 24);
			this.nudX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudX.Name = "nudX";
			this.nudX.Size = new System.Drawing.Size(120, 25);
			this.nudX.TabIndex = 1;
			this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
			// 
			// groupBoxSize
			// 
			this.groupBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSize.Controls.Add(this.label6);
			this.groupBoxSize.Controls.Add(this.chkMaintainAspectRatio);
			this.groupBoxSize.Controls.Add(this.cbbUnit);
			this.groupBoxSize.Controls.Add(this.nudY);
			this.groupBoxSize.Controls.Add(this.label4);
			this.groupBoxSize.Controls.Add(this.label3);
			this.groupBoxSize.Controls.Add(this.nudX);
			this.groupBoxSize.Location = new System.Drawing.Point(111, 74);
			this.groupBoxSize.Name = "groupBoxSize";
			this.groupBoxSize.Size = new System.Drawing.Size(340, 94);
			this.groupBoxSize.TabIndex = 6;
			this.groupBoxSize.TabStop = false;
			this.groupBoxSize.Text = "サイズ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(159, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 18);
			this.label6.TabIndex = 4;
			this.label6.Text = "単位(&C):";
			// 
			// chkMaintainAspectRatio
			// 
			this.chkMaintainAspectRatio.AutoSize = true;
			this.chkMaintainAspectRatio.Location = new System.Drawing.Point(162, 56);
			this.chkMaintainAspectRatio.Name = "chkMaintainAspectRatio";
			this.chkMaintainAspectRatio.Size = new System.Drawing.Size(105, 16);
			this.chkMaintainAspectRatio.TabIndex = 6;
			this.chkMaintainAspectRatio.Text = "縦横比を保つ(&T)";
			this.chkMaintainAspectRatio.UseVisualStyleBackColor = true;
			// 
			// cbbUnit
			// 
			this.cbbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbUnit.FormattingEnabled = true;
			this.cbbUnit.Items.AddRange(new object[] {
            "%",
            "px"});
			this.cbbUnit.Location = new System.Drawing.Point(220, 23);
			this.cbbUnit.Name = "cbbUnit";
			this.cbbUnit.Size = new System.Drawing.Size(114, 26);
			this.cbbUnit.TabIndex = 5;
			this.cbbUnit.SelectedIndexChanged += new System.EventHandler(this.cbbUnit_SelectedIndexChanged);
			// 
			// nudY
			// 
			this.nudY.Location = new System.Drawing.Point(33, 55);
			this.nudY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudY.Name = "nudY";
			this.nudY.Size = new System.Drawing.Size(120, 25);
			this.nudY.TabIndex = 3;
			this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "&Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "&X:";
			// 
			// btnStart
			// 
			this.btnStart.AutoSize = true;
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Location = new System.Drawing.Point(3, 3);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(81, 29);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "開始(&S)";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(276, 185);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 35);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// btnClose
			// 
			this.btnClose.AutoSize = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClose.Location = new System.Drawing.Point(90, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(82, 29);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "閉じる(&C)";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 78);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(90, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(12, 193);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(44, 18);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "すじ雲";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(62, 193);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(42, 18);
			this.lblStatus.TabIndex = 11;
			this.lblStatus.Text = "label5";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(463, 232);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.groupBoxSize);
			this.Controls.Add(this.btnReferSaveAs);
			this.Controls.Add(this.btnReferFile);
			this.Controls.Add(this.txtSaveAs);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "バイキュービック補間";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
			this.groupBoxSize.ResumeLayout(false);
			this.groupBoxSize.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveAs;
        private System.Windows.Forms.Button btnReferFile;
        private System.Windows.Forms.Button btnReferSaveAs;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkMaintainAspectRatio;
		private System.Windows.Forms.ComboBox cbbUnit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label lblStatus;
    }
}

