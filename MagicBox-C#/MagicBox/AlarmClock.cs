using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AlarmClock : Form
    {
        System.Timers.Timer timer;
        public AlarmClock()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            label1.Text = "Running...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();                    
            timer.Stop();
            label1.Text = "Stopped";

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;

        }

        private void playaudio() // defining the function
        {
            SoundPlayer audio = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.dt_16bars_102rap); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }


        delegate void UpdateLable(Label label1, string value);

        void UpdateDataLable(Label label1, string value)
        {
            label1.Text = value;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;

            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLable upd = UpdateDataLable;
                    if (label1.InvokeRequired)
                        Invoke(upd, label1, "Stop");
                    SoundPlayer player = new SoundPlayer();
                    playaudio();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
