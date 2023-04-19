namespace ComputerGraphicsLab1
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;
        Bitmap image;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черноБелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляПоОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляПоОсиYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторЩарраПоОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторЩарраПоОсиYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаПоОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаПоОсиYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.градиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.гистограммаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.матМорфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.черноБелыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркостьToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem,
            this.переносToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.стеклоToolStripMenuItem,
            this.волны1ToolStripMenuItem,
            this.волны2ToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem1,
            this.медианныйФильтрToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // черноБелыйToolStripMenuItem
            // 
            this.черноБелыйToolStripMenuItem.Name = "черноБелыйToolStripMenuItem";
            this.черноБелыйToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.черноБелыйToolStripMenuItem.Text = "Черно-Белый";
            this.черноБелыйToolStripMenuItem.Click += new System.EventHandler(this.черноБелыйToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.яркостьToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
            // 
            // переносToolStripMenuItem
            // 
            this.переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            this.переносToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.переносToolStripMenuItem.Text = "Перенос";
            this.переносToolStripMenuItem.Click += new System.EventHandler(this.переносToolStripMenuItem_Click_1);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.стеклоToolStripMenuItem.Text = "Стекло";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // волны1ToolStripMenuItem
            // 
            this.волны1ToolStripMenuItem.Name = "волны1ToolStripMenuItem";
            this.волны1ToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.волны1ToolStripMenuItem.Text = "Волны1";
            this.волны1ToolStripMenuItem.Click += new System.EventHandler(this.волны1ToolStripMenuItem_Click);
            // 
            // волны2ToolStripMenuItem
            // 
            this.волны2ToolStripMenuItem.Name = "волны2ToolStripMenuItem";
            this.волны2ToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.волны2ToolStripMenuItem.Text = "Волны2";
            this.волны2ToolStripMenuItem.Click += new System.EventHandler(this.волны2ToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem1
            // 
            this.линейноеРастяжениеToolStripMenuItem1.Name = "линейноеРастяжениеToolStripMenuItem1";
            this.линейноеРастяжениеToolStripMenuItem1.Size = new System.Drawing.Size(250, 26);
            this.линейноеРастяжениеToolStripMenuItem1.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem1.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem1_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.motionBlurToolStripMenuItem,
            this.фильтрСобеляПоОсиXToolStripMenuItem,
            this.фильтрСобеляПоОсиYToolStripMenuItem,
            this.операторЩарраПоОсиXToolStripMenuItem,
            this.операторЩарраПоОсиYToolStripMenuItem,
            this.операторПрюиттаПоОсиXToolStripMenuItem,
            this.операторПрюиттаПоОсиYToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // фильтрСобеляПоОсиXToolStripMenuItem
            // 
            this.фильтрСобеляПоОсиXToolStripMenuItem.Name = "фильтрСобеляПоОсиXToolStripMenuItem";
            this.фильтрСобеляПоОсиXToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.фильтрСобеляПоОсиXToolStripMenuItem.Text = "Фильтр Собеля по оси X";
            this.фильтрСобеляПоОсиXToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляПоОсиXToolStripMenuItem_Click);
            // 
            // фильтрСобеляПоОсиYToolStripMenuItem
            // 
            this.фильтрСобеляПоОсиYToolStripMenuItem.Name = "фильтрСобеляПоОсиYToolStripMenuItem";
            this.фильтрСобеляПоОсиYToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.фильтрСобеляПоОсиYToolStripMenuItem.Text = "Фильтр Собеля по оси Y";
            this.фильтрСобеляПоОсиYToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляПоОсиYToolStripMenuItem_Click);
            // 
            // операторЩарраПоОсиXToolStripMenuItem
            // 
            this.операторЩарраПоОсиXToolStripMenuItem.Name = "операторЩарраПоОсиXToolStripMenuItem";
            this.операторЩарраПоОсиXToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.операторЩарраПоОсиXToolStripMenuItem.Text = "Оператор Щарра по оси X";
            this.операторЩарраПоОсиXToolStripMenuItem.Click += new System.EventHandler(this.операторЩарраПоОсиXToolStripMenuItem_Click);
            // 
            // операторЩарраПоОсиYToolStripMenuItem
            // 
            this.операторЩарраПоОсиYToolStripMenuItem.Name = "операторЩарраПоОсиYToolStripMenuItem";
            this.операторЩарраПоОсиYToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.операторЩарраПоОсиYToolStripMenuItem.Text = "Оператор Щарра по оси Y";
            this.операторЩарраПоОсиYToolStripMenuItem.Click += new System.EventHandler(this.операторЩарраПоОсиYToolStripMenuItem_Click);
            // 
            // операторПрюиттаПоОсиXToolStripMenuItem
            // 
            this.операторПрюиттаПоОсиXToolStripMenuItem.Name = "операторПрюиттаПоОсиXToolStripMenuItem";
            this.операторПрюиттаПоОсиXToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.операторПрюиттаПоОсиXToolStripMenuItem.Text = "Оператор Прюитта по оси X";
            this.операторПрюиттаПоОсиXToolStripMenuItem.Click += new System.EventHandler(this.операторПрюиттаПоОсиXToolStripMenuItem_Click);
            // 
            // операторПрюиттаПоОсиYToolStripMenuItem
            // 
            this.операторПрюиттаПоОсиYToolStripMenuItem.Name = "операторПрюиттаПоОсиYToolStripMenuItem";
            this.операторПрюиттаПоОсиYToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.операторПрюиттаПоОсиYToolStripMenuItem.Text = "Оператор Прюитта по оси Y";
            this.операторПрюиттаПоОсиYToolStripMenuItem.Click += new System.EventHandler(this.операторПрюиттаПоОсиYToolStripMenuItem_Click);
            // 
            // матМорфологияToolStripMenuItem
            // 
            this.матМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расширениеToolStripMenuItem,
            this.сужениеToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.градиентToolStripMenuItem});
            this.матМорфологияToolStripMenuItem.Name = "матМорфологияToolStripMenuItem";
            this.матМорфологияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матМорфологияToolStripMenuItem.Text = "Мат Морфология";
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.расширениеToolStripMenuItem.Text = "Расширение";
            this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.расширениеToolStripMenuItem_Click);
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сужениеToolStripMenuItem.Text = "Сужение";
            this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.сужениеToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openingToolStripMenuItem.Text = "Opening";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closingToolStripMenuItem.Text = "Closing";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // градиентToolStripMenuItem
            // 
            this.градиентToolStripMenuItem.Name = "градиентToolStripMenuItem";
            this.градиентToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.градиентToolStripMenuItem.Text = "Градиент";
            this.градиентToolStripMenuItem.Click += new System.EventHandler(this.градиентToolStripMenuItem_Click);
            // 
            // гистограммаToolStripMenuItem
            // 
            this.гистограммаToolStripMenuItem.Name = "гистограммаToolStripMenuItem";
            this.гистограммаToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.гистограммаToolStripMenuItem.Text = "Гистограмма";
            this.гистограммаToolStripMenuItem.Click += new System.EventHandler(this.гистограммаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 469);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(692, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Button button1;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private ToolStripMenuItem черноБелыйToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem яркостьToolStripMenuItem;
        private ToolStripMenuItem резкостьToolStripMenuItem;
        private ToolStripMenuItem гистограммаToolStripMenuItem;
        private ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
        private ToolStripMenuItem переносToolStripMenuItem;
        private ToolStripMenuItem поворотToolStripMenuItem;
        private ToolStripMenuItem стеклоToolStripMenuItem;
        private ToolStripMenuItem волны1ToolStripMenuItem;
        private ToolStripMenuItem волны2ToolStripMenuItem;
        private ToolStripMenuItem motionBlurToolStripMenuItem;
        private ToolStripMenuItem серыйМирToolStripMenuItem;
        private ToolStripMenuItem линейноеРастяжениеToolStripMenuItem1;
        private ToolStripMenuItem фильтрСобеляПоОсиXToolStripMenuItem;
        private ToolStripMenuItem фильтрСобеляПоОсиYToolStripMenuItem;
        private ToolStripMenuItem операторЩарраПоОсиXToolStripMenuItem;
        private ToolStripMenuItem операторЩарраПоОсиYToolStripMenuItem;
        private ToolStripMenuItem операторПрюиттаПоОсиXToolStripMenuItem;
        private ToolStripMenuItem операторПрюиттаПоОсиYToolStripMenuItem;
        private ToolStripMenuItem матМорфологияToolStripMenuItem;
        private ToolStripMenuItem расширениеToolStripMenuItem;
        private ToolStripMenuItem сужениеToolStripMenuItem;
        private ToolStripMenuItem openingToolStripMenuItem;
        private ToolStripMenuItem closingToolStripMenuItem;
        private ToolStripMenuItem градиентToolStripMenuItem;
        private ToolStripMenuItem медианныйФильтрToolStripMenuItem;
    }
}