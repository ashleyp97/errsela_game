using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Net.Http;
using System.Media;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading.Tasks;
namespace pantest
{
    public partial class Form1 : Form
    {
        private int correct;
        private int answer;
        private int timeLeft = 3600;
        private string chosenDirection = "";
        private static readonly HttpClient client = new HttpClient();
        private VideoCapture capture;
        private Mat frame;
        private bool isCapturing = false;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Addition_generate_problem()
        {
            //randomize addition problems
            Random rand = new Random();
            int num1 = rand.Next(1, 50);
            int num2 = rand.Next(1, 50);

            //answer equals num1 + num2
            correct = num1 + num2;
            label2.Text = $"What is {num1} + {num2} ?";
            textBox3.Text = "";
            button1.Enabled = false;
            button5.Enabled = true;

        }

        private void Subtract_generate_problem()
        {
            //randomize subtraction problems
            Random rand = new Random();
            int num1 = rand.Next(25, 100);
            int num2 = rand.Next(1, 20);

            //answer equals num1 - num2
            correct = num1 - num2;
            label2.Text = $"What is {num1} - {num2} ?";
            textBox3.Text = "";
            button2.Enabled = false;
            button5.Enabled = true;

        }

        private void Multiply_generate_problem()
        {
            //randomize multiplication problems
            Random rand = new Random();
            int num1 = rand.Next(2, 12);
            int num2 = rand.Next(2, 12);

            //answer equals num1 * num2
            correct = num1 * num2;
            label2.Text = $"What is {num1} x {num2} ?";
            textBox3.Text = "";
            button3.Enabled = false;
            button5.Enabled = true;

        }

        private void Divide_generate_problem()
        {
            //randomize division problems
            Random rand = new Random();
            int multiplier = rand.Next(1, 10);
            int num1 = multiplier * 5;
            int num2 = multiplier;

            //answer equals num2 / num1
            correct = num1 / num2;
            label2.Text = $"What is {num1} ÷ {num2}?";
            textBox3.Text = "";
            button4.Enabled = false;
            button5.Enabled = true;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chosenDirection = "Forward";
            Addition_generate_problem();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            chosenDirection = "Backwards";
            Subtract_generate_problem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chosenDirection = "Left";
            Multiply_generate_problem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chosenDirection = "Right";
            Divide_generate_problem();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox3.Text, out answer))
            {
                if (answer == correct)
                {
                    label3.Text = "CORRECT";
                    label3.ForeColor = System.Drawing.Color.Green;
                    textBox3.Clear();
                    label3.Refresh();

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;

                    if (chosenDirection == "Forward")
                    {
                        try
                        {
                            await client.GetAsync("https://nyitetic.nyit.edu/errsela/botcommand.aspx?commandtype=live&origin=&sender=ashleypan9901@gmail.com&speech=&rm=22&lm=0&servo1=3&servo2=5&senttime=&duration=4&left_power=100&right_power=100&threshold=40&n_duration=1&song=&approved=FORWARD");
                            textBox3.Clear();
                            label3.Refresh();
                        }
                        catch
                        {
                            MessageBox.Show("Error opening URL");
                        }
                    }
                    else if (chosenDirection == "Backwards")
                    {
                        button2.Enabled = true;
                        try
                        {
                            await client.GetAsync("https://nyitetic.nyit.edu/errsela/botcommand.aspx?commandtype=live&origin=&sender=ashleypan9901@gmail.com&speech=&rm=22&lm=0&servo1=3&servo2=5&senttime=&duration=4&left_power=100&right_power=100&threshold=40&n_duration=1&song=&approved=REVERSE");
                        }
                        catch
                        {
                            MessageBox.Show("Error opening URL");
                        }
                    }
                    else if (chosenDirection == "Left")
                    {
                        button3.Enabled = true;

                        try
                        {
                            await client.GetAsync("https://nyitetic.nyit.edu/errsela/botcommand.aspx?commandtype=live&origin=&sender=ashleypan9901@gmail.com&speech=&rm=22&lm=0&servo1=3&servo2=5&senttime=&duration=4&left_power=100&right_power=100&threshold=40&n_duration=1&song=&approved=LEFT90");
                        }
                        catch
                        {
                            MessageBox.Show("Error opening URL");
                        }
                    }
                    else if (chosenDirection == "Right")
                    {
                        button4.Enabled = true;
                        try
                        {
                            await client.GetAsync("https://nyitetic.nyit.edu/errsela/botcommand.aspx?commandtype=live&origin=&sender=ashleypan9901@gmail.com&speech=&rm=22&lm=0&servo1=3&servo2=5&senttime=&duration=4&left_power=100&right_power=100&threshold=40&n_duration=1&song=&approved=RIGHT90" +
                                "" +
                                "");
                        }
                        catch
                        {
                            MessageBox.Show("Error opening URL");
                        }
                    }
                }
                else
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;

                    if (chosenDirection == "Forward")
                    {
                        label3.Text = "INCORRECT";
                        label3.ForeColor = System.Drawing.Color.Red;
                        label3.Refresh();
                    }
                    else if (chosenDirection == "Backwards")
                    {
                        label3.Text = "INCORRECT";
                        label3.ForeColor = System.Drawing.Color.Red;
                        label3.Refresh();
                    }
                    else if (chosenDirection == "Left")
                    {
                        label3.Text = "INCORRECT";
                        label3.ForeColor = System.Drawing.Color.Red;
                        label3.Refresh();
                    }
                    else
                    {
                        label3.Text = "INCORRECT";
                        label3.ForeColor = System.Drawing.Color.Red;
                        label3.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid answer.");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "00:00";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                timeLeft--;

                int minutes = timeLeft / 60;
                int seconds = timeLeft % 60;

                label4.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }
            else
            {
                timer1.Stop();
                label4.Text = "00:00";
                MessageBox.Show("Time's Up!");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Congrats! You delivered all the packages!");
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://docs.google/forms/d/15bSjKxdoodBJPWVBc4GWDcrWChcAKGp26guOLKz5NHQ",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open browser.");
            }

        }

        private void CaptureLoop()
        {
            while (isCapturing && capture.IsOpened())
            {
                if (capture.Read(frame))
                {
                    // Convert the OpenCV Mat to a Bitmap and display it in the PictureBox
                    if (!frame.Empty())
                    {
                        pictureBox1.Image = BitmapConverter.ToBitmap(frame);
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string cameraUrl = "rtsp://username:password@ip_address:port/stream_path";
            capture = new VideoCapture(cameraUrl);
            frame = new Mat();
            isCapturing = true;
            Task.Run(() => CaptureLoop());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCapturing = false;
            capture?.Release();
            frame?.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
