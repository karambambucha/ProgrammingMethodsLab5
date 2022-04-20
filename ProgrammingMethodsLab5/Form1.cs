using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingMethodsLab5
{
    public partial class ClocksInterface : Form
    {
        Timer timer = new Timer();
        int WIDTH, HEIGHT, secHAND = 140, minHAND = 110, hrHAND = 80;
        int cy, cx; 
        Bitmap bmp;
        Graphics clock;
        static AnalogueClock analogueClock = new AnalogueClock(25, 59, 55);
        static DigitalClock digitalClock = new DigitalClock(25, 59, 55);
        static AnalogueToDigitalAdapter adapter = new AnalogueToDigitalAdapter(analogueClock); 
        static Client client = new Client();
        public ClocksInterface()
        {
            InitializeComponent();
        }

        private void GetAnalogTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client.RequestTime(adapter), "Время с аналоговых часов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void changeTimeBtn_Click(object sender, EventArgs e)
        {
            client.AddHours(adapter, (int)hourNum.Value);
            client.AddMinutes(adapter, (int)minuteNum.Value);
            client.AddSeconds(adapter, (int)secondNum.Value);
            client.AddHours(digitalClock, (int)hourNum.Value);
            client.AddMinutes(digitalClock, (int)minuteNum.Value);
            client.AddSeconds(digitalClock, (int)secondNum.Value);
        }

        private void setRealTimeBtn_Click(object sender, EventArgs e)
        {
            client.SetTime(adapter, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            client.SetTime(digitalClock, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        private void setTimeBtn_Click(object sender, EventArgs e)
        {
            client.SetTime(adapter, (int)setHourNum.Value, (int)setMinuteNum.Value, (int)setSecondNum.Value);
            client.SetTime(digitalClock, (int)setHourNum.Value, (int)setMinuteNum.Value, (int)setSecondNum.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WIDTH = 300;
            HEIGHT = 300;
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            timer.Interval = 1000; 
            timer.Tick += new EventHandler(timerTick); 
            timer.Start();
        }
        private void timerTick(object sender, EventArgs e)
        {
            client.AddSeconds(adapter, 1);
            client.AddSeconds(digitalClock, 1);
            string text = client.RequestTime(digitalClock);
            clockText.Text = text;
            clockText.SelectionStart = 0;
            clockText.SelectionLength = text.Length;
            clockText.SelectionColor = Color.White;
            int[] handCoord = new int[2];
            clock = Graphics.FromImage(bmp);
            clock.Clear(Color.Black);
            clock.DrawEllipse(new Pen(Color.White, 1.5f), 0, 0, WIDTH, HEIGHT);
            clock.DrawString("12", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(140, 3));
            clock.DrawString("1", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(218, 22));
            clock.DrawString("2", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(263, 70));
            clock.DrawString("3", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(285, 140));
            clock.DrawString("4", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(263, 212));
            clock.DrawString("5", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(218, 259));
            clock.DrawString("6", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(142, 279));
            clock.DrawString("7", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(70, 259));
            clock.DrawString("8", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(22, 212));
            clock.DrawString("9", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(1, 140));
            clock.DrawString("10", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(22, 70));
            clock.DrawString("11", new Font("Montserrat ExtraBold", 12), Brushes.White, new PointF(70, 22));
            clock.DrawString(analogueClock.TimeOfDay, new Font("Montserrat ExtraBold", 12), Brushes.Red, new PointF(cx - 12, cy + 20));
            handCoord = secondCoord(secHAND);
            clock.DrawLine(new Pen(Color.Red, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            handCoord = minuteCoord(minHAND);
            clock.DrawLine(new Pen(Color.White, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
            handCoord = hourCoord(hrHAND);
            clock.DrawLine(new Pen(Color.White, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1])); 
            pictureBox1.Image = bmp;
            clock.Dispose();
        } 
        private int[] minuteCoord(int hlen)
        {
            int[] coord = new int[2];
            int val = analogueClock.MinuteDegree;
            if (val >= 0 && val <= 100)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        private int[] secondCoord(int hlen)
        {
            int[] coord = new int[2];
            int val = analogueClock.SecondDegree;
            if (val >= 0 && val <= 100)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
        private int[] hourCoord(int hlen)
        {
            int[] coord = new int[2];
            int val = analogueClock.HourDegree + (analogueClock.MinuteDegree / 12);
            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}
