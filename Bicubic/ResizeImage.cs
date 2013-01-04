using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace Bicubic
{
	class ResizeImage : IDisposable
	{
		public static readonly string[] SupportImageFormat = { "Bmp", "Jpeg", "Gif", "Tiff", "Png" };
		public static readonly string[] SupportBmpExtension = { ".bmp", ".dib", ".rle" };
		public static readonly string[] SupportJpegExtension = { ".jpg", ".jpeg", ".jpe", ".jfif" };
		public static readonly string[] SupportGifExtension = { ".gif" };
		public static readonly string[] SupportTiffExtension = { ".tiff", ".tif" };
		public static readonly string[] SupportPngExtension = { ".png" };
		public static readonly string SupportExtensionFilter = "サポートするすべての画像ファイル|*.bmp;*.dib;*.rle;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff|ビットマップファイル|*.bmp;*.dib;*.rle|Jpeg ファイル|*.jpg;*.jpeg;*.jpe;*.jfif|Gif ファイル|*.gif|Tiff ファイル|*.tif;*.tiff|PNG ファイル|*.png";

		public Bitmap BeforeImage { private set; get; }
		public Bitmap AfterImage { private set; get; }

		public ImageFormat Format { private set; get; }
		public ResizeImage(string fileName)
		{
			try
			{
				// Check extension
				Format = GetFormat(fileName);
				BeforeImage = new Bitmap(fileName);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static ImageFormat GetFormat(string fileName)
		{
			string extension = Path.GetExtension(fileName);
			extension = extension.ToLower();
			if (SupportBmpExtension.Contains<string>(extension))
				return ImageFormat.Bmp;
			else if (SupportJpegExtension.Contains<string>(extension))
				return ImageFormat.Jpeg;
			else if (SupportGifExtension.Contains<string>(extension))
				return ImageFormat.Gif;
			else if (SupportTiffExtension.Contains<string>(extension))
				return ImageFormat.Tiff;
			else if (SupportPngExtension.Contains<string>(extension))
				return ImageFormat.Png;
			else
				throw new NotSupportedException();
		}

		public void CreateImage(int width, int height, InterpolationMode im)
		{
			Graphics g = null;
			try
			{
				AfterImage = new Bitmap(width, height);
				g = Graphics.FromImage(AfterImage);
				g.InterpolationMode = im;
				g.DrawImage(BeforeImage, 0, 0, width, height);
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				if (g != null) g.Dispose();
			}
		}

		public void SaveImage(string fileName)
		{
			try
			{
				SaveImage(fileName, Format);				
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void SaveImage(string fileName, ImageFormat format)
		{
			try
			{
				AfterImage.Save(fileName, format);
			}
			catch (Exception)
			{
				throw;
			}
		}


		public void Dispose()
		{
			if (BeforeImage != null) BeforeImage.Dispose();
			if (AfterImage != null) AfterImage.Dispose();
		}
	}
}
