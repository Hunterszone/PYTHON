using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Globalization;

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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Word file|*.doc, *.docx";
            saveFileDialog1.Title = "Save as";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
         (System.IO.FileStream)saveFileDialog1.OpenFile();

            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);

        }

        
        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void defaultScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                              (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

　
　
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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ProgressBar pBar = new ProgressBar(); 
 
 
             pBar.Location = new System.Drawing.Point(20, 20); 
             pBar.Name = "Loading..."; 
             pBar.Width = 200; 
             pBar.Height = 30; 
             Controls.Add(pBar); 
 
 
             pBar.Name = "Loading..."; 
 
 
             pBar.Minimum = 0; 
             pBar.Maximum = 100; 
             pBar.Value = 100; 
 
 
             pBar.Dock = DockStyle.Bottom; 
 
 
 
 
             PrintDocument pd = new PrintDocument(); 
             PrintDialog pdi = new PrintDialog(); 
             pdi.Document = pd; 
 
 
             if (pdi.ShowDialog() == DialogResult.OK) 
             { 
                 pd.Print(); 
             } 
             else 
             { 
                 MessageBox.Show("Print Cancelled"); 
             } 

        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string country = RegionInfo.CurrentRegion.DisplayName;
            
            this.label1.Text = "Local time and date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"); 
            this.label1.Font = new Font("Arial", 24,FontStyle.Bold);

            this.label2.Text = "Your country is: " + country;
            this.label2.Font = new Font("Arial", 24, FontStyle.Bold); 

 
             bool Windowstate = true; 
             WindowState = FormWindowState.Maximized;

             
 
             if (Windowstate) 
             { 
 
 
                 this.label1.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.label1.Width) / 2, 
                          (Screen.PrimaryScreen.WorkingArea.Height - this.label1.Height) / 2);

                 
                 
                 this.label2.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.label2.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.label2.Height) / 3); 

 
             
             } 

　
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            string newPath = @"C:\printscreen";
            System.IO.Directory.CreateDirectory(newPath);
            printscreen.Save(@"C:\printscreen\printscreen.jpg", ImageFormat.Jpeg);
            
        }

        private void enlargeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = this.Font.Size;
            currentSize += 2.0F;
            this.Font = new Font(this.Font.Name, currentSize,
            this.Font.Style, this.Font.Unit);
        }

        private void smallerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = this.Font.Size;
            currentSize -= 2.0F;
            this.Font = new Font(this.Font.Name, currentSize,
            this.Font.Style, this.Font.Unit);
        }
    }
}
