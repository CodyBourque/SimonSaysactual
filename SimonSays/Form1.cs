﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            gameScreen gs = new gameScreen();
            this.Controls.Add(gs);
            gs.BringToFront();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
