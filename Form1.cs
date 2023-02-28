using System.Net;
using Newtonsoft.Json;

namespace times
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private bool top;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ca_label.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")).ToString("G");
            hk_label.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("China Standard Time")).ToString("G");
            uk_label.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")).ToString("G");
            tor_label.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).ToString("G");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(top == false)
            {
                top = true;
                Form1.ActiveForm.TopMost = true;
            }
            else
            {
                top = false;
                Form1.ActiveForm.TopMost = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void tor_label_Click(object sender, EventArgs e)
        {

        }
    }
}