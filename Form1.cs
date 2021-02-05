using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Semaforos_Final
{
    public partial class Form1 : Form
    {
        int seg = 30;
        int seg2 = 30;
        
      
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            CarDown2.Visible = false;
            CarUp2.Visible = false;
            CarLeft2.Visible = false;
            CarRight2.Visible = false;
        }

        private void BackGround_Click(object sender, EventArgs e)
        {

        }

        private void Slow_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)Convert.ToInt64(textBox1.Text);
        }

        private void Medium_Click(object sender, EventArgs e)
        {

            timer1.Interval = (int)Convert.ToInt64(textBox2.Text);
        }

        private void Fast_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)Convert.ToInt64(textBox3.Text);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            seg--;
            textBox4.Text = seg.ToString();
            if (seg >= 11)
            {
                if (seg % 2 == 0)
                {
                    CarDown2.Visible = true;
                    CarUp2.Visible = true;
                    CarDown.Visible = false;
                    CarUp.Visible = false;
                }
                else
                {
                    CarDown2.Visible = false;
                    CarUp2.Visible = false;
                    CarDown.Visible = true;
                    CarUp.Visible = true;
                }

                RedUp.BackColor = Color.Black;
                OrangeUp.BackColor = Color.Black;
                GreenUp.BackColor = Color.Lime;

                RedDown.BackColor = Color.Black;
                OrangeDown.BackColor = Color.Black;
                GreenDown.BackColor = Color.Lime;

                RedRight.BackColor = Color.Red;
                OrangeRight.BackColor = Color.Black;
                GreenRight.BackColor = Color.Black;

                RedLeft.BackColor = Color.Red;
                OrangeLeft.BackColor = Color.Black;
                GreenLeft.BackColor = Color.Black;
            }
            if (seg <= 10)
            {
                if (seg % 2 == 0)
                {
                    CarDown2.Visible = true;
                    CarUp2.Visible = true;
                    CarDown.Visible = false;
                    CarUp.Visible = false;
                }
                else
                {
                    CarDown2.Visible = false;
                    CarUp2.Visible = false;
                    CarDown.Visible = true;
                    CarUp.Visible = true;
                }
                RedUp.BackColor = Color.Black;
                OrangeUp.BackColor = Color.Orange;
                GreenUp.BackColor = Color.Black;

                RedDown.BackColor = Color.Black;
                OrangeDown.BackColor = Color.Orange;
                GreenDown.BackColor = Color.Black;
            }
            if (seg <= 0)
            {
                CarUp2.Visible = false;
                CarDown2.Visible = false;
                CarDown.Visible = true;
                CarUp.Visible = true;
                RedUp.BackColor = Color.Red;
                OrangeUp.BackColor = Color.Black;
                GreenUp.BackColor = Color.Black;

                RedDown.BackColor = Color.Red;
                OrangeDown.BackColor = Color.Black;
                GreenDown.BackColor = Color.Black;
                timer1.Stop();
                textBox4.Text = "0";

            }
            if (textBox4.Text == "0")
            {
                timer1.Start();
                seg2--;
                textBox4.Text = seg2.ToString();
                if (seg2 >= 11)
                {
                    if (seg2 % 2 == 0)
                    {
                        CarLeft2.Visible = true;
                        CarRight2.Visible = true;
                        CarLeft.Visible = false;
                        CarRight.Visible = false;
                    }
                    else
                    {
                        CarLeft2.Visible = false;
                        CarRight2.Visible = false;
                        CarLeft.Visible = true;
                        CarRight.Visible = true;
                    }
                    RedUp.BackColor = Color.Red;
                    OrangeUp.BackColor = Color.Black;
                    GreenUp.BackColor = Color.Black;

                    RedDown.BackColor = Color.Red;
                    OrangeDown.BackColor = Color.Black;
                    GreenDown.BackColor = Color.Black;

                    RedRight.BackColor = Color.Black;
                    OrangeRight.BackColor = Color.Black;
                    GreenRight.BackColor = Color.Lime;

                    RedLeft.BackColor = Color.Black;
                    OrangeLeft.BackColor = Color.Black;
                    GreenLeft.BackColor = Color.Lime;
                }
                if (seg2 <= 10)
                {
                    if (seg2 % 2 == 0)
                    {
                        CarLeft2.Visible = true;
                        CarRight2.Visible = true;
                        CarLeft.Visible = false;
                        CarRight.Visible = false;
                    }
                    else
                    {
                        CarLeft2.Visible = false;
                        CarRight2.Visible = false;
                        CarLeft.Visible = true;
                        CarRight.Visible = true;
                    }
                    RedLeft.BackColor = Color.Black;
                    OrangeLeft.BackColor = Color.Orange;
                    GreenLeft.BackColor = Color.Black;

                    RedRight.BackColor = Color.Black;
                    OrangeRight.BackColor = Color.Orange;
                    GreenRight.BackColor = Color.Black;
                }
                if (seg2 == 0)
                {
                    CarLeft2.Visible = false;
                    CarRight2.Visible = false;
                    CarLeft.Visible = true;
                    CarRight.Visible = true;
                    RedLeft.BackColor = Color.Red;
                    OrangeLeft.BackColor = Color.Black;
                    GreenLeft.BackColor = Color.Black;

                    RedRight.BackColor = Color.Red;
                    OrangeRight.BackColor = Color.Black;
                    GreenRight.BackColor = Color.Black;
                    timer1.Stop();
                }
                if (seg2 == 0)
                {
                    timer1.Start();
                    seg = 30;
                    seg2 = 30;
                }

            }
        }

        
    }
}
