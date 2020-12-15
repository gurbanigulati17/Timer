﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int timeCs, timeSec, timeMin;
        bool isActive;

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeCs++;
                if (timeCs >= 30)
                {
                    timeSec++;
                    timeCs = 0;
                }
                if (timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;
                }
            }
            DrawTime();

        }

        private void DrawTime()
        {
            labelCs.Text = string.Format("{0:00}", timeCs);
            labelSec.Text = string.Format("{0:00}", timeSec);
            labelMin.Text = string.Format("{0:00}", timeMin);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
        }
    }
}
