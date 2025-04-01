using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }
        Pen p = new Pen(Color.Black, 3);
        int X, Y;//計畫滑鼠位置
        private void 線條粗細ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage((Bitmap)pictureBox1.Image);
                g.DrawLine(p, X, Y, e.X, e.Y);
                X = e.X;
                Y = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;

        }

        private void 粗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 5;
        }

        private void 細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 1;

        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Width = 3;
        }

        private void 線條樣式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 點短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void 長短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
        }

        private void 長線ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}

