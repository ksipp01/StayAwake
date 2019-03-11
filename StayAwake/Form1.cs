using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StayAwake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected bool up = true;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.MoveMouse == true)
            {
                Program.MoveMouse = false;
                button1.BackColor = Color.Red;
                timer1.Enabled = false;
                this.TopMost = false;
                return;
            }
            if (Program.MoveMouse == false)
            {
                Program.MoveMouse = true;
                button1.BackColor = Color.Lime;
                timer1.Enabled = true;
                button1.Text = "Stop";
                this.TopMost = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.MoveMouse == false)
                   StayAwake.Move.Mouse(0, 0);
            
            else
            {
                
                if (this.up)
                    StayAwake.Move.Mouse(4, 4);
                else
                    StayAwake.Move.Mouse(-4, -4);

            }
            this.up = !this.up;

            if (DateTime.Now.Hour == 7 && DateTime.Now.Minute == 00)
                Application.Exit();
           //test commit 


        }
    }
}
