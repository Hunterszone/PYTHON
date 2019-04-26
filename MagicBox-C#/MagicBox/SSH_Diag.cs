using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;





namespace WindowsFormsApplication1
{
    public partial class SSH_Diag : Form
    {
        string input = string.Empty;

        public string inputTo;
        public string outputFrom;
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public static SshClient client { get; set; }
        public ShellStream shellStream { get; set; }

        public SSH_Diag()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;

            this.textBox2.Text = "";
            this.input = string.Empty;

            this.textBox4.Text = "";
            this.input = string.Empty;

            this.textBox5.Text = "";
            this.input = string.Empty;
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SshClient cSSH = new SshClient("216.58.214.206", 80, "google.com");
            cSSH.Connect();
            SshCommand x = cSSH.RunCommand("exec \"/var/lib/asterisk/bin/retrieve_conf\"");
            cSSH.Disconnect();
            cSSH.Dispose();

            textBox1.Text = cSSH.ToString();
           

        }

        }
    }

