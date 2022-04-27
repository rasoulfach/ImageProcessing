using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageProcessing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //>> FUNCTIONS
        private Bitmap GammaCorrection(Bitmap img, double gamma, double c = 1d)
        {
            int width = img.Width;
            int height = img.Height;
            BitmapData srcData = img.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int bytes = srcData.Stride * srcData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(srcData.Scan0, buffer, 0, bytes);
            img.UnlockBits(srcData);
            int current = 0;
            int cChannels = 3;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    current = y * srcData.Stride + x * 4;
                    for (int i = 0; i < cChannels; i++)
                    {
                        double range = (double)buffer[current + i] / 255;
                        double correction = c * Math.Pow(range, gamma);
                        result[current + i] = (byte)(correction * 255);
                    }
                    result[current + 3] = 255;
                }
            }
            Bitmap resImg = new Bitmap(width, height);
            BitmapData resData = resImg.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(result, 0, resData.Scan0, bytes);
            resImg.UnlockBits(resData);
            return resImg;
        }

        private Bitmap NegativeCorrection(Bitmap img)
        {
            Bitmap bitmap = img;

            int height = img.Height;
            int width = img.Width;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    Color p = bitmap.GetPixel(x, y);

                    //extract ARGB value from p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find negative value
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //set new ARGB value in pixel
                    bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));


                }
            }
            return bitmap;
        }

        private Bitmap Thresholding(Bitmap img, int red = 0, int green = 0, int blue = 0)
        {
            Bitmap bitmap = img;

            int height = img.Height;
            int width = img.Width;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    Color p = bitmap.GetPixel(x, y);

                    //extract ARGB value from p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //Thresholding
                    //RED
                    if (r <= red)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = 255;
                    }
                    //BLUE
                    if (b <= blue)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = 255;
                    }
                    //GREEN
                    if (g <= green)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = 255;
                    }


                    //set new ARGB value in pixel
                    bitmap.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            return bitmap;

        }

        private Bitmap GreyScale(Bitmap bitmap)
        {
            Bitmap grayScale = new Bitmap(bitmap.Width, bitmap.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = bitmap.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }

        private Bitmap Average(Bitmap bitmap, int[] array, float taghsim)
        {
            Color c;
            float sumR = 0;
            float sumG = 0;
            float sumB = 0;
            int node = 0;
            float zaribNode = 1;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 1; i <= bitmap.Width - 2; i++)
                for (int j = 1; j <= bitmap.Height - 2; j++)
                {
                    node = 0;
                    for (int x = i - 1; x <= i + 1; x++)
                        for (int y = j - 1; y <= j + 1; y++)
                        {
                            zaribNode = array[node];
                            c = bitmap.GetPixel(x, y);
                            sumR = sumR + zaribNode * c.R;
                            sumG = sumG + zaribNode * c.G;
                            sumB = sumB + zaribNode * c.B;
                            node++;
                        }
                    int colorR = (int)Math.Round(sumR / taghsim, 10);
                    int colorG = (int)Math.Round(sumG / taghsim, 10);
                    int colorB = (int)Math.Round(sumB / taghsim, 10);

                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(colorR, colorG, colorB));
                    sumR = 0;
                    sumG = 0;
                    sumB = 0;
                }
            return tepm;
        }

        private Bitmap Average5x(Bitmap bitmap)
        {
            Color c;
            float sum = 0;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 2; i <= bitmap.Width - 3; i++)
                for (int j = 2; j <= bitmap.Height - 3; j++)
                {
                    for (int x = i - 2; x <= i + 2; x++)
                        for (int y = j - 2; y <= j + 2; y++)
                        {
                            c = bitmap.GetPixel(x, y);
                            sum = sum + c.R;
                        }
                    int color = (int)Math.Round(sum / 25, 10);
                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return tepm;
        }

        private Bitmap Average7x(Bitmap bitmap)
        {
            Color c;
            float sum = 0;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 3; i <= bitmap.Width - 4; i++)
                for (int j = 3; j <= bitmap.Height - 4; j++)
                {
                    for (int x = i - 3; x <= i + 3; x++)
                        for (int y = j - 3; y <= j + 3; y++)
                        {
                            c = bitmap.GetPixel(x, y);
                            sum = sum + c.R;
                        }
                    int color = (int)Math.Round(sum / 49, 10);
                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return tepm;
        }

        private Bitmap Average19x(Bitmap bitmap)
        {
            Color c;
            float sum = 0;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 9; i <= bitmap.Width - 10; i++)
                for (int j = 9; j <= bitmap.Height - 10; j++)
                {
                    for (int x = i - 9; x <= i + 9; x++)
                        for (int y = j - 9; y <= j + 9; y++)
                        {
                            c = bitmap.GetPixel(x, y);
                            sum = sum + c.R;
                        }
                    int color = (int)Math.Round(sum / 361, 10);
                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return tepm;
        }

        public int[] HistogramR(Bitmap bitmap)
        {
            Color c;
            int[] x = new int[256];
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    x[c.R]++;
                }
            return x;
        }

        public int[] HistogramG(Bitmap bitmap)
        {
            Color c;
            int[] x = new int[256];
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    x[c.G]++;
                }
            return x;
        }

        public int[] HistogramB(Bitmap bitmap)
        {
            Color c;
            int[] x = new int[256];
            for (int i = 0; i < bitmap.Width; i++)
                for (int j = 0; j < bitmap.Height; j++)
                {
                    c = bitmap.GetPixel(i, j);
                    x[c.B]++;
                }
            return x;
        }

        public Bitmap MedianFilter(Bitmap bitmap)
        {
            Bitmap temp = new Bitmap(bitmap.Width, bitmap.Height);
            Color c;
            Bitmap res;
            List<int> termsList = new List<int>();
            int counter = 0;

            for (int i = 1; i <= bitmap.Width - 2; i++)
                for (int j = 1; j <= bitmap.Height - 2; j++)
                {
                    for (int x = i - 1; x <= i + 1; x++)
                        for (int y = j - 1; y <= j + 1; y++)
                        {

                            c = bitmap.GetPixel(x, y);
                            termsList.Add(c.R);
                            counter++;
                        }
                    int[] terms = termsList.ToArray();
                    Array.Sort<int>(terms);
                    Array.Reverse(terms);
                    int color = terms[4];
                    temp.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    termsList.Clear();
                    counter = 0;
                }
            res = temp;

            return res;
        }

        public Bitmap Laplacian(Bitmap bitmap, int[] array)
        {
            var image2 = new Bitmap(bitmap);
            for (int x = 1; x < bitmap.Width - 1; x++)
            {
                for (int y = 1; y < bitmap.Height - 1; y++)
                {
                    Color color1, color2, color3, color4, color5, color6, color7, color8, color9;
                    color1 = bitmap.GetPixel(x - 1, y - 1);
                    color2 = bitmap.GetPixel(x, y - 1);
                    color3 = bitmap.GetPixel(x + 1, y - 1);
                    color4 = bitmap.GetPixel(x - 1, y);
                    color5 = bitmap.GetPixel(x, y);
                    color6 = bitmap.GetPixel(x + 1, y);
                    color7 = bitmap.GetPixel(x - 1, y + 1);
                    color8 = bitmap.GetPixel(x, y + 1);
                    color9 = bitmap.GetPixel(x + 1, y + 1);
                    int r = color1.R * array[0]
                        + color2.R * array[1]
                        + color3.R * array[2]
                        + color4.R * array[3]
                        + color5.R * array[4]
                        + color6.R * array[5]
                        + color7.R * array[6]
                        + color8.R * array[7]
                        + color9.R * array[8];
                    int g = color1.G * array[0]
                        + color2.G * array[1]
                        + color3.G * array[2]
                        + color4.G * array[3]
                        + color5.G * array[4]
                        + color6.G * array[5]
                        + color7.G * array[6]
                        + color8.G * array[7]
                        + color9.G * array[8];
                    int b = color1.B * array[0]
                        + color2.B * array[1]
                        + color3.B * array[2]
                        + color4.B * array[3]
                        + color5.B * array[4]
                        + color6.B * array[5]
                        + color7.B * array[6]
                        + color8.B * array[7]
                        + color9.B * array[8];
                    int avg = (r + g + b) / 3;
                    if (avg > 255) avg = 255;
                    if (avg < 0) avg = 0;
                    image2.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                }
            }
            return image2;
        }


        private Bitmap Laplacian5x(Bitmap bitmap)
        {
            Color c;
            float sum = 0;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 2; i <= bitmap.Width - 3; i++)
                for (int j = 2; j <= bitmap.Height - 3; j++)
                {
                    for (int x = i - 2; x <= i + 2; x++)
                        for (int y = j - 2; y <= j + 2; y++)
                        {
                            c = bitmap.GetPixel(x, y);
                            if (x == i && y == j)
                            {
                                sum = sum + c.R * (-24);
                            }
                            else
                            {
                                sum = sum + c.R;
                            }
                        }
                    int color = (int)Math.Round(sum / 25);
                    if (color > 255) color = 255;
                    if (color < 0) color = 0;
                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return tepm;
        }

        private Bitmap Laplacian7x(Bitmap bitmap)
        {
            Color c;
            float sum = 0;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 3; i <= bitmap.Width - 4; i++)
                for (int j = 3; j <= bitmap.Height - 4; j++)
                {
                    for (int x = i - 3; x <= i + 3; x++)
                        for (int y = j - 3; y <= j + 3; y++)
                        {
                            c = bitmap.GetPixel(x, y);
                            if (x == i && y == j)
                            {
                                sum = sum + c.R * (-48);
                            }
                            else
                            {
                                sum = sum + c.R;
                            }
                        }
                    int color = (int)Math.Round(sum / 49);
                    if (color > 255) color = 255;
                    if (color < 0) color = 0;
                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return tepm;
        }

        private Bitmap Laplacian19x(Bitmap bitmap)
        {
            Color c;
            float sum = 0;
            Bitmap tepm = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 9; i <= bitmap.Width - 10; i++)
                for (int j = 9; j <= bitmap.Height - 10; j++)
                {
                    for (int x = i - 9; x <= i + 9; x++)
                        for (int y = j - 9; y <= j + 9; y++)
                        {
                            c = bitmap.GetPixel(x, y);
                            if (x == i && y == j)
                            {
                                sum = sum + c.R * (-360);
                            }
                            else
                            {
                                sum = sum + c.R;
                            }
                        }
                    int color = (int)Math.Round(sum / 361);
                    if (color > 255) color = 255;
                    if (color < 0) color = 0;
                    tepm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            return tepm;
        }


        private string MoneyRecognation(Bitmap bitmap)
        {
            int height = bitmap.Height;
            int width = bitmap.Width;

            int area = height * width;

            int sumr = 0;
            int sumg = 0;
            int sumb = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    Color p = bitmap.GetPixel(x, y);

                    //extract ARGB value from p
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    sumr = sumr + r;
                    sumg = sumg + g;
                    sumb = sumb + b;
                }
            }

            sumr /= area;
            sumg /= area;
            sumb /= area;

            //>> مقایسه با هزاری
            //>> 178 , 203 , 194
            if (sumg > sumb && sumb > sumr) return "1000";

            //>> مقایسه با 5 هزاری
            //>> 210 , 193 , 173
            if (sumr > sumg && sumg > sumb) return "5000";

            //>> مقایسه با 10 هزاری
            //>> 194 , 208 , 175
            if (sumg > sumr && sumr > sumb) return "10000";

            //>> مقایسه با 50 هزاری
            //>> 162 , 161 , 190
            if (sumb > sumr && sumb > sumg) return "50000";

            return "Unknown!";
        }


        //>> Upload & Recovery

        private void zapasPicBox_Click(object sender, EventArgs e)
        {
            PictureBoxX.Image = new Bitmap(zapasPicBox.Image);
        }

        private void gsZapaspicbox_Click(object sender, EventArgs e)
        {
            PictureBoxX.Image = new Bitmap(gsZapaspicbox.Image);
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != null)
            {
                string fileName = openFileDialog.FileName;
                PictureBoxX.ImageLocation = fileName.ToString();
                zapasPicBox.ImageLocation = fileName.ToString();
                Bitmap btzapasgrey = GreyScale((Bitmap)zapasPicBox.Image);
                gsZapaspicbox.Image = btzapasgrey;
            }
        }

        //>> Buttons
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void NegBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            PictureBoxX.Image = NegativeCorrection(bitmap);
        }

        private void GamaBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(PictureBoxX.Image);
            PictureBoxX.Image = GammaCorrection(bitmap, Convert.ToDouble(gamaYTextBox.Text), Convert.ToDouble(gamaCTextBox.Text));
        }

        private void thrshBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            PictureBoxX.Image = Thresholding(bitmap, Convert.ToInt16(thrRedText.Text), Convert.ToInt16(thrGreenText.Text), Convert.ToInt16(thrBlueText.Text));
        }

        private void gsGamaBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = GammaCorrection(bitmap, Convert.ToDouble(gsYText.Text), Convert.ToDouble(gsCText.Text));

        }

        private void gsNegBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = NegativeCorrection(bitmap);
        }

        private void gsThreBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Thresholding(bitmap, Convert.ToInt16(gsThrBit.Text), Convert.ToInt16(gsThrBit.Text), Convert.ToInt16(gsThrBit.Text));

        }

        private void AverageBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            int[] x = new int[9];


            x[0] = Convert.ToInt32(xy1.Text);
            x[1] = Convert.ToInt32(xy2.Text);
            x[2] = Convert.ToInt32(xy3.Text);
            x[3] = Convert.ToInt32(xy4.Text);
            x[4] = Convert.ToInt32(xy5.Text);
            x[5] = Convert.ToInt32(xy6.Text);
            x[6] = Convert.ToInt32(xy7.Text);
            x[7] = Convert.ToInt32(xy8.Text);
            x[8] = Convert.ToInt32(xy9.Text);

            float taghsim = 0;
            for (int i = 0; i < 9; i++)
            {
                taghsim += x[i];
            }

            PictureBoxX.Image = Average(bitmap, x, taghsim);
        }

        private void avg5Btn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Average5x(bitmap);
        }

        private void avg7Btn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Average7x(bitmap);
        }

        private void avg19Btn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Average19x(bitmap);
        }

        private void histogBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];

            red = HistogramR(bitmap);
            green = HistogramG(bitmap);
            blue = HistogramB(bitmap);

            showfrm showbedamR = new showfrm(red, "red");
            showbedamR.Show();

            showfrm showbedamG = new showfrm(green, "green");
            showbedamG.Show();

            showfrm showbedamB = new showfrm(blue, "blue");
            showbedamB.Show();
        }

        private void Median_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = MedianFilter(bitmap);
        }

        private static int GetBit(byte b, int bitIndex)
        {
            return (b >> bitIndex) & 0x01;
        }

        private static Bitmap GetBitPlaneRed(Bitmap bitmap, int bitPlaneIndex)
        {
            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color currColor = bitmap.GetPixel(i, j);

                    int bit = GetBit(currColor.R, bitPlaneIndex);

                    Color newColor = Color.FromArgb(255, 255 * bit, 255 * bit);

                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        private void bitPlain_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            ImageFormat imageFormat = bitmap.RawFormat;

            for (int i = 0; i < 8; i++)
            {
                Bitmap newBitmap = GetBitPlaneRed(bitmap, i);
                newBitmap = GreyScale(newBitmap);
                bitfrm bitfrm1 = new bitfrm(i.ToString(), newBitmap);
                bitfrm1.Show();
            }
        }

        private void LaplasianBtn_Click(object sender, EventArgs e)
        {
            int[] x = new int[9];
            x[0] = Convert.ToInt32(xyl1.Text);
            x[1] = Convert.ToInt32(xyl2.Text);
            x[2] = Convert.ToInt32(xyl3.Text);
            x[3] = Convert.ToInt32(xyl4.Text);
            x[4] = Convert.ToInt32(xyl5.Text);
            x[5] = Convert.ToInt32(xyl6.Text);
            x[6] = Convert.ToInt32(xyl7.Text);
            x[7] = Convert.ToInt32(xyl8.Text);
            x[8] = Convert.ToInt32(xyl9.Text);
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            PictureBoxX.Image = Laplacian(bitmap, x);
        }

        private void Laplasian5xBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Laplacian5x(bitmap);
        }

        private void Laplasian7xBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Laplacian7x(bitmap);
        }

        private void Laplasian19xBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            bitmap = GreyScale(bitmap);
            PictureBoxX.Image = Laplacian19x(bitmap);
        }

        private void moneyBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = (Bitmap)PictureBoxX.Image;
            string tashkis = MoneyRecognation(bitmap);
            recLbl.Text = tashkis;
        }
    }
}
