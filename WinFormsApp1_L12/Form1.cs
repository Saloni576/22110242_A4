using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1_L12
{
    public partial class Form1 : Form
    {
        private TimeSpan targetTime;
        private bool isAlarmSet = false;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // optional setup
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!TimeSpan.TryParseExact(txtTimeInput.Text, "c", CultureInfo.InvariantCulture, out targetTime))
            {
                MessageBox.Show("Invalid format. Please enter time as HH:MM:SS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isAlarmSet = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isAlarmSet) return;

            TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan trimmedNow = new TimeSpan(now.Hours, now.Minutes, now.Seconds);

            // Change background color randomly
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            if (trimmedNow == targetTime)
            {
                timer1.Stop();
                isAlarmSet = false;
                MessageBox.Show("Alarm: Time matched!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
