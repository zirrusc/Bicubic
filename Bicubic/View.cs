using System.Drawing;
using System.Windows.Forms;

namespace Bicubic
{
	public partial class View : Form
	{
		public View()
		{
			InitializeComponent();
		}

		public void SetImage(string path)
		{
			if (path == "")
			{
				pictureBox1.Image = null;
			}
			else
			{
				pictureBox1.Image = new Bitmap(path);

			}
		}

		public void SetImage(Image i)
		{
			pictureBox1.Image = i;
		}

	}
}
