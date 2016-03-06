//Simon Says
//Made by Cody Bourque
//2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class gameScreen : UserControl
    {
        //colours correspondence <red = 0> <blue = 1> <yellow = 2> <green = 3>
        Random rnd = new Random(); //creates a new random value
        int InList = 0; //this variable is used for finding the pattern value
        bool playback = false; //boolean for playing back the pattern to the user
        public static List<int> pattern = new List<int>(); //pattern list
        SoundPlayer player = new SoundPlayer(); //sound player for sounds

        //immediately loads the first method
        public gameScreen()
        {
            InitializeComponent();

            gameScreen_Load();
        }
        //first method
        //used for restarting the game (i.e. clearing the pattern
        //sets the scorelabel to zero
        //moves to the next method
        void gameScreen_Load()
        {
            pattern.Clear();

            Refresh();

            scoreLabel.Text = "Your score is: 0";

            p2Turn();
        }
        //this method starts the playable part of the game
        private void p2Turn()
        {
            P2Label.Text = "Welcome to Simon Says. Get gud casul."; //sets label at the top of the screen
            pattern.Add(rnd.Next(0,4)); //adds a random number between 0 and 3 to the pattern (see correspondance)
            new Thread(playingback).Start(); //starts the playingback method on a new thread
            }
        //this method plays the pattern to the user
        void playingback()
        {
            playback = true; //sets the playback boolean to true (this is mainly for convenience)
            foreach(int colour in pattern) //for each of the values in the pattern, check which colour it is
            {
                switch(colour)
                {
                    //each case flashes the button, plays a sound and then sleeps
                    case 0: //red
                        redButton.BackColor = Color.White;
                        player = new SoundPlayer(Properties.Resources.red);
                        player.Play();
                        Thread.Sleep(200);
                        redButton.BackColor = Color.Red;
                        break;
                    case 1: //blue
                        blueButton.BackColor = Color.White;
                        player = new SoundPlayer(Properties.Resources.blue);
                        player.Play();
                        Thread.Sleep(200);
                        blueButton.BackColor = Color.Blue;
                        break;
                    case 2: //yellow
                        yellowButton.BackColor = Color.White;
                        player = new SoundPlayer(Properties.Resources.yellow);
                        player.Play();
                        Thread.Sleep(200);
                        yellowButton.BackColor = Color.Yellow;
                        break;
                    case 3: //green
                        greenButton.BackColor = Color.White;
                        player = new SoundPlayer(Properties.Resources.green);
                        player.Play();
                        Thread.Sleep(200);
                        greenButton.BackColor = Color.Green;
                        break;
                }
                //sleep for 200 ms
                Thread.Sleep(200);
            }
            playback = false; //playback false (again for convenience)
        }
        //red button clicked method
        private void redButton_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.red); //red button sound
            player.Play(); //play it
            playerTurn(0); //send the parameter 0 to the playerTurn method
        }
        //blue button clicked method
        private void blueButton_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.blue); //blue button sound
            player.Play(); //play it
            playerTurn(1); //parameter 1 to the playerTurn method
        }
        //yellow button clicked method
        private void yellowButton_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.yellow); //yellow button sound
            player.Play(); //play it
            playerTurn(2); //parameter 2 to playerTurn 
        }
        //green button clicked method
        private void greenButton_Click(object sender, EventArgs e)
        {
            player = new SoundPlayer(Properties.Resources.green); //green button sound
            player.Play(); //play it
            playerTurn(3); //parameter 3 to playerTurn
        }
        //playerTurn method which takes the parameter above and uses it as a colour
        private void playerTurn(int colour)
        {
            //if playback is true, return to it
           if (playback)
            {
                return;
            }
           //if the first value of pattern is equal to the colour parameter
           if(pattern[InList] == colour)
            {
                //add to the inlist value
                InList++;
            }
            else
            {
                player = new SoundPlayer(Properties.Resources.mistake); //mistake sound
                player.Play(); //play it
                gameOver(); //move to the gameover method
            }
           //if the inlist value is equal or greater than the pattern number
            if (InList >= pattern.Count)
            {
                //inlist zero to start again
                InList = 0;
                //move to p2turn
                p2Turn();
            }
            //display the score
            scoreLabel.Text = "Your score is: "  + (pattern.Count - 1).ToString();
        }
        //gameover method
        private void gameOver()
        {
            //bring up the gameover user control
            gameOver go = new gameOver();
            this.Controls.Add(go);
            go.BringToFront();
        }
    }
}
