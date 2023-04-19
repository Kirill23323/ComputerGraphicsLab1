using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphicsLab1
{
    internal class Histogramm : Form
    {
        int[] hist;
        public Histogramm(Bitmap image)
        {
         hist = GetHistogramm(image);
         this.Paint += (o, e) => DrawHistogramm(e.Graphics, ClientRectangle, hist);
         this.Resize += (o, e) => Refresh();
         Refresh();
        }
        private static void DrawHistogramm(Graphics g, Rectangle rect, int[] hist)
        {
            float max = hist.Max();
            if (max > 0)
                for (int i = 0; i < hist.Length; i++)
                {
                    float h = rect.Height * hist[i] / (float)max;
                    g.FillRectangle(Brushes.Green, i * rect.Width / (float)hist.Length, rect.Height - h, rect.Width / (float)hist.Length, h);
                }
        }

        private static int[] GetHistogramm(Bitmap image)
        {
            int[] result = new int[256];
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    int i = (int)(255 * image.GetPixel(x, y).GetBrightness());
                    result[i]++;
                }
            }
            return result;
        }

    }
}
