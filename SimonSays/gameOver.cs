using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class gameOver : UserControl
    {
        public gameOver()
        {
            InitializeComponent();
        }

        private void gameOver_Load(object sender, EventArgs e)
        {
            //sets some labels to humiliate the player
            doneLabel.Text = "get rekt " + Form1.name + "\n you got a measly score of: " + (gameScreen.pattern.Count() - 1);

            againLabel.Text = "would you like some more?";
        }
        //exit button clicked method
        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }
        //restartbutton clicked method
        private void restartButton_Click(object sender, EventArgs e)
        {
            //restart the app
            Application.Restart();
        }
    }
}
