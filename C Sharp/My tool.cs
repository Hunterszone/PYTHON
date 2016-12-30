using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Text = "New instance";
            f2.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                //OR

                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void defaultViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void biggerFontAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = menuStrip1.Font.Size;
            currentSize += 2.0F;
            menuStrip1.Font = new Font(menuStrip1.Font.Name, currentSize,
            menuStrip1.Font.Style, menuStrip1.Font.Unit);

        }

        private void smallerFontAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = menuStrip1.Font.Size;
            currentSize -= 2.0F;
            menuStrip1.Font = new Font(menuStrip1.Font.Name, currentSize,
            menuStrip1.Font.Style, menuStrip1.Font.Unit);
        }
    }
}
