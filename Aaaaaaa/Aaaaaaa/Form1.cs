using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int s = 10,q=10;
        Random rnd = new Random();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += s;
            if (button1.Right >= this.DisplayRectangle.Width || button1.Left <= 0)
            {
                s *= -1;
                this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
            button1.Top += q;
            if (button1.Bottom >= this.DisplayRectangle.Height || button1.Top <= 0)
            {
                q *= -1;
                this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Left = e.X;
            button2.Top = e.Y;
            button2.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        

    }
}
