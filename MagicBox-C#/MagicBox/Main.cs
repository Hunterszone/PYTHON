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
using WMPLib;
using System.Windows.Media;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web;
using Microsoft.Graph;
using Newtonsoft.Json;
using System.Collections.Specialized;
using Microsoft.VisualBasic.FileIO;
using System.Threading;



namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            string content = "INSTRUCTIONS OF USAGE:\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
            richTextBox1.Text = content;
            

            this.Load += new System.EventHandler(this.Form1_Load);


        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void createNewForm(object sender, EventArgs e)
        {
            Main f2 = new Main();
            this.Text = "Magic Box";
            f2.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string p = "random";
            string args = string.Format("/e, /select, \"{0}\"", p);

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer";
            info.Arguments = args; 
            Process.Start(info);
            
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();

        }

        private void saveAsDialog(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Word file|*.doc, *.docx|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save as";


            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                System.IO.FileStream fs =
             (System.IO.FileStream)saveFileDialog1.OpenFile();

                this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsDialog);

            }

            else
            {
                MessageBox.Show("Nothing chosen!");
            }

        }


        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            string content = "INSTRUCTIONS OF USAGE:\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
            richTextBox1.Text = content;

            richTextBox1.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - richTextBox1.Width) / 2,
                              (Screen.PrimaryScreen.WorkingArea.Height - richTextBox1.Height) / 2);
            
            float currentSize;

            currentSize = richTextBox1.Font.Size;
            currentSize += 2.0F;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
            richTextBox1.Font.Style, richTextBox1.Font.Unit);

        }

        private void defaultScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            this.Controls.Clear();
            this.InitializeComponent();
            string content = "INSTRUCTIONS OF USAGE:\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
            richTextBox1.Text = content;

            this.BackgroundImage = null;

        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                              (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            this.Controls.Clear();
            this.InitializeComponent();
            string content = "INSTRUCTIONS OF USAGE:\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
            richTextBox1.Text = content;

            this.BackgroundImage = null;


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

            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                //OR

                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc

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



        }

        private void digitalClockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string country = RegionInfo.CurrentRegion.DisplayName;

            this.label2.Text = ".NET Framework region or country: " + country;
            this.label2.Font = new Font("Arial", 24, FontStyle.Bold);

            bool Windowstate = true;
            WindowState = FormWindowState.Maximized;

            if (Windowstate)
            {

                this.label2.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.label2.Width) / 2,
                         (Screen.PrimaryScreen.WorkingArea.Height - this.label2.Height) / 2);

                Bitmap bitmap2 = new Bitmap(WindowsFormsApplication1.Properties.Resources.maxresdefault); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                this.BackgroundImage = bitmap2;

                richTextBox1.Visible = !richTextBox1.Visible;

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

            string newPath = @"C:\MagicBox\printscreen";
            System.IO.Directory.CreateDirectory(newPath);
            printscreen.Save(@"C:\MagicBox\printscreen\printscreen.jpg", ImageFormat.Jpeg);

        }

        private void enlargeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = this.Font.Size;
            currentSize += 1.0F;
            this.Font = new Font(this.Font.Name, currentSize,
            this.Font.Style, this.Font.Unit);
        }

        private void smallerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;

            currentSize = this.Font.Size;
            currentSize -= 1.0F;
            this.Font = new Font(this.Font.Name, currentSize,
            this.Font.Style, this.Font.Unit);
        }

        private void rotateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProcessStartInfo sInfo = new ProcessStartInfo("http://youtube.com/");
            Process.Start(sInfo);

        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://facebook.com/");
            Process.Start(sInfo);
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://google.com/");
            Process.Start(sInfo);
        }

        private void bingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://bing.com/");



            Process.Start(sInfo);
        }

        private void onlineRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.partyviberadio.com/player/embed-auto/reggae.html");
            Process.Start(sInfo);

        }

        private void rEADMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = @"C:\MagicBox\README";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
                Directory.CreateDirectory(dir);

            // use Path.Combine to combine 2 strings to a path
            File.WriteAllText(Path.Combine(dir, "README.txt"), "This is the README for Magic Box!");

            Process.Start(@"C:\MagicBox\README\README.txt");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDiag box = new AboutDiag();
            box.ShowDialog();
        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string dir = @"C:\MagicBox\WinForm";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
            {
                Directory.CreateDirectory(dir);


            }


            if (!File.Exists(@"C:\MagicBox\WinForm\WinForm.jpg"))
            {
                richTextBox1.Visible = !richTextBox1.Visible;
                
                ProgressBar pBar = new ProgressBar();


                pBar.Location = new System.Drawing.Point(20, 20);
                pBar.Name = "Loading...";

                Controls.Add(pBar);


                pBar.Name = "Loading...";
                
                pBar.Minimum = 0;
                pBar.Maximum = 100;
                pBar.Value = 100;

                pBar.Dock = DockStyle.Bottom;

                int percent = (int)(((double)(pBar.Value - pBar.Minimum) /

                (double)(pBar.Maximum - pBar.Minimum)) * 100);

                using (Graphics gr = pBar.CreateGraphics())
                {

                    gr.DrawString(percent.ToString() + "% Loading Progress",

                        SystemFonts.DefaultFont,

                        System.Drawing.Brushes.Black,

                        new PointF(pBar.Width / 2 - (gr.MeasureString(percent.ToString() + "% Loading Progress",

                            SystemFonts.DefaultFont).Width / 2.0F),

                        pBar.Height / 2 - (gr.MeasureString(percent.ToString() + "% Loading Progress",

                            SystemFonts.DefaultFont).Height / 2.0F)));

                   
                }


                System.Drawing.Bitmap b = new Bitmap((this.Bounds.Width) * 6 / 4, (this.Bounds.Height) * 2);
                this.DrawToBitmap(b, this.Bounds);
                b.Save(@"C:\MagicBox\WinForm\WinForm.jpg");
                Process.Start(@"C:\MagicBox\WinForm\WinForm.jpg");

                this.Controls.Clear();
                this.InitializeComponent();
                string content = "INSTRUCTIONS OF USAGE:\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
                richTextBox1.Text = content;


            }


            else
            {
                MessageBox.Show("The Bitmap is already existing under C:\\WinForm.");
            }

        }


        private void removeSubFolders(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new DirectoryInfo(@"C:\MagicBox");

            foreach (FileInfo file in dir.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                subdir.Delete(true);
                MessageBox.Show("Subfolders have been purged!");

            }



        }

        private void termsOfAgreementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string dir = @"C:\MagicBox\Terms of Agreement";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
                Directory.CreateDirectory(dir);

            // use Path.Combine to combine 2 strings to a path
            File.WriteAllText(Path.Combine(dir, "Terms of Agreement.txt"), "All copyright, trade marks, design rights, patents and other intellectual property rights (registered and unregistered) in and on BBC Online Services and BBC Content belong to the BBC and/or third parties (which may include you or other users.) The BBC reserves all of its rights in BBC Content and BBC Online Services. Nothing in the Terms grants you a right or licence to use any trade mark, design right or copyright owned or controlled by the BBC or any other third party except as expressly provided in the Terms.");

            Process.Start(@"C:\MagicBox\Terms of Agreement\Terms of Agreement.txt");

        }

        private void removeMasterfolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dir = new DirectoryInfo(@"C:\MagicBox");
            dir.Delete(true);
            MessageBox.Show("Masterfolder has been purged!");

            if (!dir.Exists)
            {
                MessageBox.Show("Nothing to purge has left!");
            }

        }

        private void sSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SSH_Diag ssh = new SSH_Diag();
            ssh.ShowDialog();
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string dir = @"C:\MagicBox\Downloads";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
            {
                Directory.CreateDirectory(dir);

            }

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(new System.Uri("http://www.tor-hits.com/balgarski-torent-trakeri-bg/"),
                @"C:\MagicBox\Downloads\tracker's list.html");
                Process.Start(@"C:\MagicBox\Downloads\tracker's list.html");
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = @"C:\MagicBox\Uploads";  // folder location

            if (!Directory.Exists(dir))  // if it doesn't exist, create
                Directory.CreateDirectory(dir);

            // use Path.Combine to combine 2 strings to a path
            File.WriteAllText(Path.Combine(dir, "Source.txt"), "******THE CONTENT OF SOURCE.TXT WAS UPLOADED INTO AN HTML FORMAT*******");
            File.WriteAllText(Path.Combine(dir, "lambada.html"), "");
            
                    
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = @"C:\MagicBox\Uploads";
            dialog.Filter = "XML file|*.xml|TXT file|*.txt|Word file|*.doc|PDF file|*.pdf|HTM file|*.htm|All Files (*.*)|*.*"; // file types, that will be allowed to upload
            dialog.Multiselect = true; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK

            {
                String path = dialog.FileName; // get name of file
                
                
                using (var Http_Client = new WebClient())
                {
                    string Url = @"C:\MagicBox\Uploads\lambada.html";  // folder location
                    string Upload_File_Content = System.IO.File.ReadAllText(@"C:\MagicBox\Uploads\Source.txt");

                      var Post_Data = new NameValueCollection();
                    Post_Data["Uploaded content: "] = Upload_File_Content;
                    
                    var Response = Http_Client.UploadValues(Url, "POST", Post_Data);
                    MessageBox.Show("Upload completed!");
                    Process.Start(@"C:\MagicBox\Uploads\lambada.html");

                }


            }


        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            string sSource;

            string sLog;

            string sEvent;



            sSource = "dotNET Sample App";

            sLog = "Application";
            
            sEvent = "Sample Event";



            if (!EventLog.SourceExists(sSource))

                EventLog.CreateEventSource(sSource,sLog);



            EventLog.WriteEntry(sSource,sEvent);

            EventLog.WriteEntry(sSource, sEvent,
                
            EventLogEntryType.Warning, 234);
        }

        private void sendFileToRecycleBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dir = @"C:\MagicBox";
            var args = string.Format("/e, /select, \"{0}\"", dir);

                    FileSystem.DeleteDirectory(dir,
                    UIOption.AllDialogs,
                    RecycleOption.SendToRecycleBin);
                
                MessageBox.Show("Sent to Recycle bin!");
                MessageBox.Show("Nothing to recycle has left!");

                //Process.Start(@"C:\$Recycle.Bin\S-1-5-21-1604565902-1709306669-1863455436-1001");

  
            }

        private void mediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wmplayer.exe");
        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string content = "INSTRUCTIONS OF USAGE UP TO: ";
            string content2 = "\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
            richTextBox1.Text = content + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm") + content2;


        }

        private void alarmClockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlarmClock alarm = new AlarmClock();
            alarm.ShowDialog();

        }

        private void speechRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechRecgn speech = new SpeechRecgn();
            speech.ShowDialog();
        }

        private void openDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dir = new DirectoryInfo(@"C:\MagicBox");
            ProcessStartInfo info = new ProcessStartInfo();

            if (dir.Exists)
            {
                string p = @"C:\MagicBox";
                string args = string.Format("/e, /select, \"{0}\"", p);

                info.FileName = @"C:\MagicBox";
                info.Arguments = args;
                Process.Start(info);

            }
            else
            {
                MessageBox.Show("Directory MagicBox does not exist!");

                if (MessageBox.Show("Wanna create it ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string dirmain = @"C:\MagicBox\README";  // folder location

                    if (!Directory.Exists(dirmain))  // if it doesn't exist, create
         
                    {
                        richTextBox1.Visible = !richTextBox1.Visible;

                        ProgressBar pBar = new ProgressBar();


                        pBar.Location = new System.Drawing.Point(20, 20);
                        pBar.Name = "Loading...";

                        Controls.Add(pBar);


                        pBar.Name = "Loading...";


                        pBar.Minimum = 0;
                        pBar.Maximum = 100;
                        pBar.Value = 100;

                        pBar.Dock = DockStyle.Bottom;

                        Directory.CreateDirectory(dirmain);

                        MessageBox.Show("Directory has been created!");

                        File.WriteAllText(Path.Combine(dirmain, "README.txt"), "This is the README for Magic Box!");
                        
                        this.Controls.Clear();
                        this.InitializeComponent();
                        string content = "INSTRUCTIONS OF USAGE:\n\n1. A master folder named MagicBox is created under the C: drive .\n2. All subfolders are getting created under MagicBox .\n3. The local coordinates are available only in Full Screen mode .\n4. Once in Center Screen mode, you can't switch back to default position .\n5. Enlarge and smaller form are not useful in Full Screen mode .\n6. You cannot save WinForm while in Full Screen mode .".Replace("\n", Environment.NewLine);
                        richTextBox1.Text = content;

                    }

                }
            }

        }

        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"cmd.exe");
        }

        private void powerShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"powershell.exe");
        }

        private void minimizeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shell32.ShellClass objShel = new Shell32.ShellClass();
            objShel.ToggleDesktop();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string myLanguage = "en-US";
            InputLanguage.CurrentInputLanguage =
            InputLanguage.FromCulture(new System.Globalization.CultureInfo(myLanguage));
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string myLanguage = "de-DE";
            InputLanguage.CurrentInputLanguage =
            InputLanguage.FromCulture(new System.Globalization.CultureInfo(myLanguage));
        }

                                    
        }


    }


