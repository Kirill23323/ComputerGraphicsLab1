using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ComputerGraphicsLab1
{
    abstract class Filters
    {
        public virtual Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }
        protected virtual Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return sourceImage.GetPixel(x, y);
        }
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
    }
    class InvertFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;
        }
    }

    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            }
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }
    }
    class BlurFilter : MatrixFilter
    {
        public BlurFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                    kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
            }
        }
    }
    class GaussianFilter : MatrixFilter
    {
        public void CreateGaussianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1; // размер ядра
            kernel = new float[size, size]; // ядро фильтра
            float norm = 0; // коэффициент нормировки ядра
            for (int i = -radius; i <= radius; i++) // рассчет ядра
            {
                for (int j = -radius; j <= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
                    norm += kernel[i + radius, j + radius];
                }
            }
            for (int i = 0; i < size; i++) // нормировка ядра
            {
                for (int j = 0; j < size; j++)
                    kernel[i, j] /= norm;
            }
        }
        public GaussianFilter()
        {
            CreateGaussianKernel(3, 2);
        }
    }
    class GrayScaleFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb((int)((sourceColor.R * 0.36) + (sourceColor.G * 0.53) + (sourceColor.B * 0.11)), (int)((sourceColor.R * 0.36) + (sourceColor.G * 0.53) + (sourceColor.B * 0.11)), (int)((sourceColor.R * 0.36) + (sourceColor.G * 0.53) + (sourceColor.B * 0.11)));
            return resultColor;
        }
    }
    class SepiaFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int intensity = (int)((sourceColor.R * 0.36) + (sourceColor.G * 0.53) + (sourceColor.B * 0.11));
            int k = 10;
            Color resultColor = Color.FromArgb(Clamp(((int)(intensity + 2 * k)), 0, 255), Clamp(((int)(intensity + 0.5 * k)), 0, 255), Clamp(((int)(intensity - 1 * k)), 0, 255));
            return resultColor;
        }
    }
    class BrightnessFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int k = 10;
            Color resultColor = Color.FromArgb(Clamp((sourceColor.R + k), 0, 255), Clamp((sourceColor.G + k), 0, 255), Clamp((sourceColor.B + k), 0, 255));
            return resultColor;
        }
    }
    class SobelFilterX : MatrixFilter
    {
        public SobelFilterX()
        {

            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            kernel[0, 0] = -1;
            kernel[0, 1] = 0;
            kernel[0, 2] = 1;
            kernel[1, 0] = -2;
            kernel[1, 1] = 0;
            kernel[1, 2] = 2;
            kernel[2, 0] = -1;
            kernel[2, 1] = 0;
            kernel[2, 2] = 1;


        }
    }
    class SobelFilterY : MatrixFilter
    {
        public SobelFilterY()
        {

            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            kernel[0, 0] = -1;
            kernel[0, 1] = -2;
            kernel[0, 2] = -1;
            kernel[1, 0] = 0;
            kernel[1, 1] = 0;
            kernel[1, 2] = 0;
            kernel[2, 0] = 1;
            kernel[2, 1] = 2;
            kernel[2, 2] = 1;

        }
    }
    class SharraFilterX : MatrixFilter
    {
        public SharraFilterX()
        {

            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            kernel[0, 0] = 3;
            kernel[0, 1] = 0;
            kernel[0, 2] = -3;
            kernel[1, 0] = 10;
            kernel[1, 1] = 0;
            kernel[1, 2] = -10;
            kernel[2, 0] = 3;
            kernel[2, 1] = 0;
            kernel[2, 2] = -3;


        }
    }
    class SharraFilterY : MatrixFilter
    {
        public SharraFilterY()
        {

            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            kernel[0, 0] = 3;
            kernel[0, 1] = 10;
            kernel[0, 2] = 3;
            kernel[1, 0] = 0;
            kernel[1, 1] = 0;
            kernel[1, 2] = 0;
            kernel[2, 0] = -3;
            kernel[2, 1] = -10;
            kernel[2, 2] = -3;


        }
    }
    class PruittFilterX : MatrixFilter
    {
        public PruittFilterX()
        {

            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            kernel[0, 0] = -1;
            kernel[0, 1] = 0;
            kernel[0, 2] = 1;
            kernel[1, 0] = -1;
            kernel[1, 1] = 0;
            kernel[1, 2] = 1;
            kernel[2, 0] = -1;
            kernel[2, 1] = 0;
            kernel[2, 2] = 1;


        }
    }
    class PruittFilterY : MatrixFilter
    {
        public PruittFilterY()
        {

            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];

            kernel[0, 0] = -1;
            kernel[0, 1] = -1;
            kernel[0, 2] = -1;
            kernel[1, 0] = 0;
            kernel[1, 1] = 0;
            kernel[1, 2] = 0;
            kernel[2, 0] = 1;
            kernel[2, 1] = 1;
            kernel[2, 2] = 1;


        }
    }
    class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 0;
            kernel[0, 1] = -1;
            kernel[0, 2] = 0;
            kernel[1, 0] = -1;
            kernel[1, 1] = 5;
            kernel[1, 2] = -1;
            kernel[2, 0] = 0;
            kernel[2, 1] = -1;
            kernel[2, 2] = 0;
        }
    }
    class StampingFilter : MatrixFilter
    {
        public StampingFilter()
        {
            int sizeX = 3;
            int sizeY = 3;
            float norm = 0;
            kernel = new float[sizeX, sizeY];
            kernel[0, 0] = 0;
            kernel[0, 1] = 1;
            kernel[0, 2] = 0;
            kernel[1, 0] = 1;
            kernel[1, 1] = 0;
            kernel[1, 2] = -1;
            kernel[2, 0] = 0;
            kernel[2, 1] = -1;
            kernel[2, 2] = 0;
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    kernel[i, j] += 50;
                    norm += kernel[i, j];
                }
            }
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    kernel[i, j] /= norm;

                }
            }
        }
    }
    class TransferFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int xnew = x + 50;
            int idX = Clamp(xnew, 0, sourceImage.Width - 1);
            int ynew = y;
            int idY = Clamp(ynew, 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(idX, idY);
            if (xnew < 0 || xnew > (sourceImage.Width - 1) || ynew < 0 || ynew > (sourceImage.Height - 1))
                return Color.FromArgb(255, 255, 255);
            else
                return Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);
        }
    }
    class RotateFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;

            int xnew = (int)((x - x0) * Math.Cos((float)Math.PI / 4) - (y - y0) * Math.Sin((float)Math.PI / 4) + x0);
            int idX = Clamp(xnew, 0, sourceImage.Width - 1);

            int ynew = (int)((x - x0) * Math.Sin((float)Math.PI / 4) + (y - y0) * Math.Cos((float)Math.PI / 4) + y0);
            int idY = Clamp(ynew, 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(idX, idY);
            if (xnew < 0 || xnew > (sourceImage.Width - 1) || ynew < 0 || ynew > (sourceImage.Height - 1))
                return Color.FromArgb(255, 255, 255);
            else
                return Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);
        }
    }
    class GlassFilter : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Random rand = new Random();
            int xnew = (int)(x + ((rand.NextDouble() - 0.5) * 10));
            int idX = Clamp(xnew, 0, sourceImage.Width - 1);
            int ynew = (int)(y + ((rand.NextDouble() - 0.5) * 10));
            int idY = Clamp(ynew, 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(idX, idY);
            return Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);
        }
    }
    class WaveFilter1 : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int xnew = (int)(x + (20 * (Math.Sin((float)((2 * Math.PI * y) / 60)))));
            int idX = Clamp(xnew, 0, sourceImage.Width - 1);
            int ynew = y;
            int idY = Clamp(ynew, 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(idX, idY);
            return Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);
        }
    }
    class WaveFilter2 : Filters
    {
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int xnew = (int)(x + (20 * (Math.Sin((float)((2 * Math.PI * x) / 30)))));
            int idX = Clamp(xnew, 0, sourceImage.Width - 1);
            int ynew = y;
            int idY = Clamp(ynew, 0, sourceImage.Height - 1);
            Color sourceColor = sourceImage.GetPixel(idX, idY);
            return Color.FromArgb(sourceColor.R, sourceColor.G, sourceColor.B);
        }
    }
    class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter()
        {
            int size = 9;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i != j)
                        kernel[i, j] = 0;
                    else
                        kernel[i, j] = (float)1 / size;
                }
            }
        }
    }
    class GreyWorldFilter : Filters
    {
        protected int avgColorR, avgColorG, avgColorB, avg;

        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            int N = sourceImage.Width * sourceImage.Height;
            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 50));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color sColor = sourceImage.GetPixel(i, j);

                    sumR += sColor.R;
                    sumG += sColor.G;
                    sumB += sColor.B;
                }
            }

            avgColorR = sumR / N;
            avgColorG = sumG / N;
            avgColorB = sumB / N;

            avg = (avgColorR + avgColorG + avgColorB) / 3;


            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress(50 + (int)((float)i / resultImage.Width * 50));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));

                }
            }

            return resultImage;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color sourceColor = sourceImage.GetPixel(x, y);

            int R = sourceColor.R * avg / avgColorR;
            int G = sourceColor.G * avg / avgColorG;
            int B = sourceColor.B * avg / avgColorB;

            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }
    }
    class LinearStretchFilter : Filters
    {
        protected int YmaxR, YmaxG, YmaxB,
                       YminR, YminG, YminB;
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            Color zeroColor = sourceImage.GetPixel(0, 0);

            YminR = zeroColor.R;
            YmaxR = zeroColor.R;
            YmaxG = zeroColor.G;
            YminG = zeroColor.G;
            YmaxB = zeroColor.B;
            YminB = zeroColor.B;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 50));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color sColor = sourceImage.GetPixel(i, j);

                    if (YminR > sColor.R)
                        YminR = sColor.R;
                    if (YmaxR < sColor.R)
                        YmaxR = sColor.R;
                    if (YminG > sColor.G)
                        YminG = sColor.G;
                    if (YmaxG < sColor.G)
                        YmaxG = sColor.G;
                    if (YminB > sColor.B)
                        YminB = sColor.B;
                    if (YmaxB < sColor.B)
                        YmaxB = sColor.B;
                }
            }

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress(50 + (int)((float)i / resultImage.Width * 50));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {

            Color sourceColor = sourceImage.GetPixel(x, y);

            int R = (sourceColor.R - YminR) * (255 / (YmaxR - YminR));
            int G = (sourceColor.G - YminG) * (255 / (YmaxG - YminG));
            int B = (sourceColor.B - YminB) * (255 / (YmaxB - YminB));

            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }
    }
    class MedianFilter : Filters
    {
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    if (i == 0 || j == 0 || j == sourceImage.Height - 1 || i == sourceImage.Width - 1)
                        resultImage.SetPixel(i, j, sourceImage.GetPixel(i, j));
                    else
                        resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));

                }
            }
            return resultImage;
        }

        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int diam = 9;
            Color[] window = new Color[diam];
            int[] windowR = new int[diam];
            int[] windowG = new int[diam];
            int[] windowB = new int[diam];
            int count = 0;
            for (int k = x - 1; k < x + 2; k++)
            {
                for (int l = y - 1; l < y + 2; l++)
                {
                    window[count] = sourceImage.GetPixel(k, l);
                    windowR[count] = window[count].R;
                    windowG[count] = window[count].G;
                    windowB[count] = window[count].B;
                    count++;
                }
            }
            Array.Sort(windowR);
            Array.Sort(windowG);
            Array.Sort(windowB);
            int r = windowR[diam / 2];
            int g = windowG[diam / 2];
            int b = windowB[diam / 2];

            return Color.FromArgb(r, g, b);
        }
    }
    class Morfology : Filters
    {
        protected int MW, MH;
        protected int[,] mask = null;
        protected int del = 1, plus = 0;
        protected void SetMask(int MW, int MH, int[,] mask)
        {
            this.MW = MW;
            this.MH = MH;
            this.mask = mask;
        }

        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            SetMask(3, 3, new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } });

            for (int i = MW / 2; i < sourceImage.Width - MW / 2; i++)
            {
                worker.ReportProgress(plus + (int)((float)i / resultImage.Width * 100 / del));
                if (worker.CancellationPending) return null;
                for (int j = MH; j < sourceImage.Height - MH / 2; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImage;
        }
    }
    class DilationFilter : Morfology
    {
        public DilationFilter(int del = 1, int plus = 0)
        {
            this.del = del;
            this.plus = plus;
        }
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double avg;
            double avgRes = 0;
            Color sourceColor;
            Color resultColor = Color.FromArgb(0, 0, 0);

            for (int i = -MW / 2; i <= MW / 2; i++)
            {
                for (int j = -MH / 2; j <= MH / 2; j++)
                {
                    sourceColor = sourceImage.GetPixel(i + x, j + y);
                    avg = (sourceColor.R + sourceColor.B + sourceColor.G) / 3;

                    if (mask[i + MW / 2, j + MH / 2] * avg > avgRes)
                        resultColor = sourceColor;

                    avgRes = (resultColor.R + resultColor.G + resultColor.B) / 3;
                }
            }

            return resultColor;
        }
    }

    class ErosionFilter : Morfology
    {
        public ErosionFilter(int del = 1, int plus = 0)
        {
            this.del = del;
            this.plus = plus;
        }
        protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            double avg;
            Color sourceColor;
            Color resultColor = Color.FromArgb(0, 0, 0);
            double avgRes = 255;

            for (int i = -MW / 2; i <= MW / 2; i++)
            {
                for (int j = -MH / 2; j <= MH / 2; j++)
                {
                    sourceColor = sourceImage.GetPixel(i + x, j + y);
                    avg = (sourceColor.R + sourceColor.B + sourceColor.G) / 3;

                    if (mask[i + MW / 2, j + MH / 2] * avg < avgRes)
                        resultColor = sourceColor;

                    avgRes = (resultColor.R + resultColor.G + resultColor.B) / 3;
                }
            }

            return resultColor;
        }
    }

    class OpeningFilter : Morfology
    {
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Filters filters1 = new DilationFilter(2, 50);
            Filters filters2 = new ErosionFilter(2);

            return filters1.ProcessImage(filters2.ProcessImage(sourceImage, worker), worker);
        }
    }

    class ClosingFilter : Morfology
    {
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Filters filters1 = new DilationFilter(2);
            Filters filters2 = new ErosionFilter(2, 50);

            return filters2.ProcessImage(filters1.ProcessImage(sourceImage, worker), worker);
        }
    }

    class GradFilter : Morfology
    {
        protected Bitmap dilImage, erImage;
        public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Filters filterD = new DilationFilter(3);
            Filters filterE = new ErosionFilter(3, 33);
            dilImage = filterD.ProcessImage(sourceImage, worker);
            erImage = filterE.ProcessImage(sourceImage, worker);

            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress(67 + (int)((float)i / resultImage.Width * 33));
                if (worker.CancellationPending) return null;
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    resultImage.SetPixel(i, j, CalculateNewPixelColor(i, j));
                }
            }
            return resultImage;
        }

        protected Color CalculateNewPixelColor(int x, int y)
        {

            Color dilColor = dilImage.GetPixel(x, y);
            Color erColor = erImage.GetPixel(x, y);

            int R = dilColor.R - erColor.R;
            int G = dilColor.G - erColor.G;
            int B = dilColor.B - erColor.B;

            return Color.FromArgb(Clamp(R, 0, 255),
                                    Clamp(G, 0, 255),
                                    Clamp(B, 0, 255));
        }
    }
}
