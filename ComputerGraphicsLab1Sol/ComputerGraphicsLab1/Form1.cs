namespace ComputerGraphicsLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image= image;
                pictureBox1.Refresh();
            }
        }

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).ProcessImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled) 
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ôèëüòğÃàóññàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÷åğíîÁåëûéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ÿğêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğåçêîñòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ãèñòîãğàììàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogramm hist = new Histogramm(image);
            hist.ShowDialog();
        }

        private void ëèíåéíîåĞàñòÿæåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearStretchFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïåğåíîñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new TransferFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new StampingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïåğåíîñToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filters filter = new TransferFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâîğîòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new RotateFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñòåêëîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âîëíû1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilter1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âîëíû2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilter2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåğûéÌèğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GreyWorldFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ëèíåéíîåĞàñòÿæåíèåToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearStretchFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ôèëüòğÑîáåëÿÏîÎñèXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilterX();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ôèëüòğÑîáåëÿÏîÎñèYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilterY();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void îïåğàòîğÙàğğàÏîÎñèXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraFilterX();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void îïåğàòîğÙàğğàÏîÎñèYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharraFilterY();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void îïåğàòîğÏğşèòòàÏîÎñèXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PruittFilterX();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void îïåğàòîğÏğşèòòàÏîÎñèYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new PruittFilterY();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ğàñøèğåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new DilationFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñóæåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new ErosionFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new OpeningFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new ClosingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ãğàäèåíòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GradFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ìåäèàííûéÔèëüòğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}