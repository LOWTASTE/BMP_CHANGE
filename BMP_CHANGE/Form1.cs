using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMP_CHANGE
{
    public partial class Form1 : Form
    {
        public static Bitmap BMP_F;   
        public static Bitmap BMP_E;
        public static Bitmap BMP_R;
        static  System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private static bool exitFlag = false;  

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            try
            {
                string file_f = chooseBmp();
                BMP_F = new Bitmap(file_f);
                pictureBox_f.Image = BMP_F;
                int BMPWidth = BMP_F.Width;
                int BMPHeight = BMP_F.Height;
                textBox_c.Text = "起始帧:\n" + file_f + "\n宽度为:" + BMP_F.Width +  " \n高度为:" + BMP_F.Height;

            }
            catch
            {
                textBox_c.Text = "请选择图片";
            }
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            try
            {
                string file_e = chooseBmp();
                BMP_E = new Bitmap(file_e);
                pictureBox_e.Image = BMP_E;
                textBox_c.Text = file_e;
                textBox_c.Text = "截至帧:\n" + file_e + "\n宽度为:" + BMP_E.Width + " \n高度为:" + BMP_E.Height;
            }
            catch
            {
                textBox_c.Text = "请选择图片";
            }
        }

        private void btn_r_Click(object sender, EventArgs e)
        {

            if(BMP_F==null||BMP_E==null)
            {
                btn_f_Click(sender, e);
                btn_e_Click(sender, e);
            }
            if(BMP_E.Width!=BMP_F.Width||BMP_E.Height!=BMP_E.Height)
            {
                textBox_c.Text = "请重新选择大小相等的图片";
                btn_f_Click(sender, e);
                btn_e_Click(sender, e);
            }

            BMP_R = (Bitmap)BMP_F.Clone();

            Timer_Load(sender, e);
            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
                pictureBox_r.Image = BMP_R;
            }
            if(exitFlag == true)
            {
                myTimer.Stop();
            }

        }

        public string chooseBmp()
        {
            string bmpfile = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择位图文件";
            dialog.Filter = "图片文件(*.bmp)|*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bmpfile = dialog.FileName;
            }
            return bmpfile;
        }


        public static Color changeRGB(Color des,Color src)
        {

            if (des.A > src.A)
            {
                src = Color.FromArgb(src.A + 1, src.R, src.G, src.B);
            }
            if (des.A < src.A)
            {
                src = Color.FromArgb(src.A - 1, src.R, src.G, src.B);
            }


            if (des.R > src.R)
            {
                src = Color.FromArgb(src.R + 1,src.G,src.B);
            }
            if(des.R < src.R)
            {
                src = Color.FromArgb(src.R - 1, src.G, src.B);
            }

            if (des.G > src.G)
            {
                src = Color.FromArgb(src.R, src.G + 1, src.B);
            }
            if (des.G < src.G)
            {
                src = Color.FromArgb(src.R, src.G - 1, src.B);
            }

            if (des.B > src.B)
            {
                src = Color.FromArgb(src.R, src.G, src.B + 1);
            }
            if (des.B < src.B)
            {
                src = Color.FromArgb(src.R, src.G, src.B - 1);
            }
            return src;
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            // Sets the timer interval to 1 seconds.
            // myTimer.Interval = 1000;
            myTimer.Interval = 10;

            /* Adds the event and the event handler for the method that will 
                                    process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Start();

            // Runs the timer, and raises the event.
            //this._TimersTimer = new System.Timers.Timer();
            //this._TimersTimer.Interval = 100;
            //this._TimersTimer.Elapsed += new System.Timers.ElapsedEventHandler(_TimersTimer_Elapsed);
            //this._TimersTimer.Start();
        }
        private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            //Color pixelColor = Color.FromName("Red");
            int BMPWidth = BMP_F.Width;
            int BMPHeight = BMP_F.Height;

            for (int i = 0; i < BMPWidth; i++)
            {
                for (int j = 0; j < BMPHeight; j++)
                {
                    Color Dcolor = BMP_E.GetPixel(i, j);
                    Color Rcolor = BMP_R.GetPixel(i, j);
                    Color RES = changeRGB(Dcolor,Rcolor);
                    BMP_R.SetPixel(i, j, RES);
                }
            }


            if (BMP_R.Equals(BMP_E))
            {
                myTimer.Enabled = false;
                exitFlag = true;
            }
            else
            {
                myTimer.Enabled = true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
