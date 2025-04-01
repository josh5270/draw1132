namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
            menuStrip1 = new MenuStrip();
            畫筆色彩ToolStripMenuItem = new ToolStripMenuItem();
            黑ToolStripMenuItem = new ToolStripMenuItem();
            藍ToolStripMenuItem = new ToolStripMenuItem();
            紅ToolStripMenuItem = new ToolStripMenuItem();
            線條粗細ToolStripMenuItem = new ToolStripMenuItem();
            細ToolStripMenuItem = new ToolStripMenuItem();
            中ToolStripMenuItem = new ToolStripMenuItem();
            粗ToolStripMenuItem = new ToolStripMenuItem();
            線條樣式ToolStripMenuItem = new ToolStripMenuItem();
            直線ToolStripMenuItem = new ToolStripMenuItem();
            點短虛線ToolStripMenuItem = new ToolStripMenuItem();
            長線ToolStripMenuItem = new ToolStripMenuItem();
            長短虛線ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            橡皮擦ToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 畫筆色彩ToolStripMenuItem, 線條粗細ToolStripMenuItem, 線條樣式ToolStripMenuItem, 儲存檔案ToolStripMenuItem, 橡皮擦ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 畫筆色彩ToolStripMenuItem
            // 
            畫筆色彩ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 黑ToolStripMenuItem, 藍ToolStripMenuItem, 紅ToolStripMenuItem });
            畫筆色彩ToolStripMenuItem.Name = "畫筆色彩ToolStripMenuItem";
            畫筆色彩ToolStripMenuItem.Size = new Size(67, 20);
            畫筆色彩ToolStripMenuItem.Text = "畫筆色彩";
            // 
            // 黑ToolStripMenuItem
            // 
            黑ToolStripMenuItem.Name = "黑ToolStripMenuItem";
            黑ToolStripMenuItem.Size = new Size(86, 22);
            黑ToolStripMenuItem.Text = "黑";
            // 
            // 藍ToolStripMenuItem
            // 
            藍ToolStripMenuItem.Name = "藍ToolStripMenuItem";
            藍ToolStripMenuItem.Size = new Size(86, 22);
            藍ToolStripMenuItem.Text = "藍";
            藍ToolStripMenuItem.Click += 藍ToolStripMenuItem_Click;
            // 
            // 紅ToolStripMenuItem
            // 
            紅ToolStripMenuItem.Name = "紅ToolStripMenuItem";
            紅ToolStripMenuItem.Size = new Size(86, 22);
            紅ToolStripMenuItem.Text = "紅";
            紅ToolStripMenuItem.Click += 紅ToolStripMenuItem_Click;
            // 
            // 線條粗細ToolStripMenuItem
            // 
            線條粗細ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 細ToolStripMenuItem, 中ToolStripMenuItem, 粗ToolStripMenuItem });
            線條粗細ToolStripMenuItem.Name = "線條粗細ToolStripMenuItem";
            線條粗細ToolStripMenuItem.Size = new Size(67, 20);
            線條粗細ToolStripMenuItem.Text = "線條粗細";
            線條粗細ToolStripMenuItem.Click += 線條粗細ToolStripMenuItem_Click;
            // 
            // 細ToolStripMenuItem
            // 
            細ToolStripMenuItem.Name = "細ToolStripMenuItem";
            細ToolStripMenuItem.Size = new Size(86, 22);
            細ToolStripMenuItem.Text = "細";
            細ToolStripMenuItem.Click += 細ToolStripMenuItem_Click;
            // 
            // 中ToolStripMenuItem
            // 
            中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            中ToolStripMenuItem.Size = new Size(86, 22);
            中ToolStripMenuItem.Text = "中";
            中ToolStripMenuItem.Click += 中ToolStripMenuItem_Click;
            // 
            // 粗ToolStripMenuItem
            // 
            粗ToolStripMenuItem.Name = "粗ToolStripMenuItem";
            粗ToolStripMenuItem.Size = new Size(86, 22);
            粗ToolStripMenuItem.Text = "粗";
            粗ToolStripMenuItem.Click += 粗ToolStripMenuItem_Click;
            // 
            // 線條樣式ToolStripMenuItem
            // 
            線條樣式ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 直線ToolStripMenuItem, 點短虛線ToolStripMenuItem, 長線ToolStripMenuItem, 長短虛線ToolStripMenuItem });
            線條樣式ToolStripMenuItem.Name = "線條樣式ToolStripMenuItem";
            線條樣式ToolStripMenuItem.Size = new Size(67, 20);
            線條樣式ToolStripMenuItem.Text = "線條樣式";
            線條樣式ToolStripMenuItem.Click += 線條樣式ToolStripMenuItem_Click;
            // 
            // 直線ToolStripMenuItem
            // 
            直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            直線ToolStripMenuItem.Size = new Size(125, 22);
            直線ToolStripMenuItem.Text = "直線";
            直線ToolStripMenuItem.Click += 直線ToolStripMenuItem_Click;
            // 
            // 點短虛線ToolStripMenuItem
            // 
            點短虛線ToolStripMenuItem.Name = "點短虛線ToolStripMenuItem";
            點短虛線ToolStripMenuItem.Size = new Size(125, 22);
            點短虛線ToolStripMenuItem.Text = "點 短虛線";
            點短虛線ToolStripMenuItem.Click += 點短虛線ToolStripMenuItem_Click;
            // 
            // 長線ToolStripMenuItem
            // 
            長線ToolStripMenuItem.Name = "長線ToolStripMenuItem";
            長線ToolStripMenuItem.Size = new Size(125, 22);
            長線ToolStripMenuItem.Text = "長虛線";
            長線ToolStripMenuItem.Click += 長線ToolStripMenuItem_Click;
            // 
            // 長短虛線ToolStripMenuItem
            // 
            長短虛線ToolStripMenuItem.Name = "長短虛線ToolStripMenuItem";
            長短虛線ToolStripMenuItem.Size = new Size(125, 22);
            長短虛線ToolStripMenuItem.Text = "長短虛線";
            長短虛線ToolStripMenuItem.Click += 長短虛線ToolStripMenuItem_Click;
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(67, 20);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            儲存檔案ToolStripMenuItem.Click += 儲存檔案ToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(12, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 331);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(664, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // 橡皮擦ToolStripMenuItem
            // 
            橡皮擦ToolStripMenuItem.Name = "橡皮擦ToolStripMenuItem";
            橡皮擦ToolStripMenuItem.Size = new Size(55, 20);
            橡皮擦ToolStripMenuItem.Text = "橡皮擦";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImage = Properties.Resources.eraser;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(23, 39);
            button2.Name = "button2";
            button2.Size = new Size(65, 62);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "小畫家";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 畫筆色彩ToolStripMenuItem;
        private ToolStripMenuItem 黑ToolStripMenuItem;
        private ToolStripMenuItem 藍ToolStripMenuItem;
        private ToolStripMenuItem 紅ToolStripMenuItem;
        private ToolStripMenuItem 線條粗細ToolStripMenuItem;
        private ToolStripMenuItem 細ToolStripMenuItem;
        private ToolStripMenuItem 中ToolStripMenuItem;
        private ToolStripMenuItem 粗ToolStripMenuItem;
        private ToolStripMenuItem 線條樣式ToolStripMenuItem;
        private ToolStripMenuItem 直線ToolStripMenuItem;
        private ToolStripMenuItem 點短虛線ToolStripMenuItem;
        private ToolStripMenuItem 長短虛線ToolStripMenuItem;
        private ToolStripMenuItem 長線ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private ToolStripMenuItem 橡皮擦ToolStripMenuItem;
        private Button button2;
    }
}