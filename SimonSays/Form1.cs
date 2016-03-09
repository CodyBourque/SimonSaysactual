using System;
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

        public static string name;

        public Form1()
        {
            InitializeComponent();
        }
        //start button clicked method
        private void startButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length >= 3) //name's gotta be over three
            {
                //name is now what was input
                name = nameInput.Text;
                //bring forth the gamescreen
                gameScreen gs = new gameScreen();
                this.Controls.Add(gs);
                gs.BringToFront();
            }
            //unless you're JT, you have a longer name than two characters
            else
            {
                errorLabel.Text = "Your name does not have less than three characters. Probably.";
            }
        }
        //exit button pressed method
        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the app
            Application.Exit();
        }
    }
}


