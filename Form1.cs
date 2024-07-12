using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrabGame2
{
    public partial class Form1 : Form
    {

        //Constants
        private const int ItemFallSpeed = 10;       //Speed at which items fall down the form 
        private const int WinScore = 5;             //Score required to win the game 
        private const int LoseScore = -3;           //Score that results in losing the game 

        //Fields
        private Random random = new Random();       //Random number generator for item positions
        private int score = 0;                      //Current score of the player

        //Constructor
        public Form1()
        {
            InitializeComponent();
            InitializeGame();           //Initialize game elenments and start conditions 

        }

        //Initialize game elements and start conditions
        private void InitializeGame()
        {
            labelGameOver.Visible = false;      //Hide the game over message initially

            //Set transparent background for game elements 
            SetTransparentBackground(crab);
            SetTransparentBackground(monkey);
            SetTransparentBackground(kaki);
            SetTransparentBackground(lychee);
            SetTransparentBackground(lychee2);

        }

        //Sets a control's back color to transparent and assigns it to the background control
        private void SetTransparentBackground(Control control)
        {
            control.Parent = bg;                        //Set control's parent to the background panel
            control.BackColor = Color.Transparent;      //Set control's background color to transparent
        }

        //Timer tick event handler
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveItemDown();             //Move items(kaki, lychee, lychee2) down the form
            CheckItemCollection();      //Check if the crab collects any items 
            CheckGameOver();            //Check if the game is over based on score
        }

        //Move items(kaki, lychee, lychee2) down the form or reset their position if they fall off
        private void MoveItemDown()
        {
            MoveItemDown(kaki);         //Move kaki down or reset its position
            MoveItemDown(lychee);       //Move lychee down or reset its position
            MoveItemDown(lychee2);      //Move lychee2 down or reset its position
        }

        //Move a single item down the form or reset its position if it falls off
        private void MoveItemDown(Control item)
        {
            //If item has fallen off the bottom of the form
            if (item.Top >= 500)
            {
                //Reset item's position to a random X- coordinate within the form's width
                item.Location = new Point(random.Next(50, 700), 0);
            }
            else
            {
                //Move item down by ItemFallSpeed pixels
                item.Top += ItemFallSpeed;
            }
        }

        //Check if the crab collects any items (kaki, lychee, lychee2) and update score
        private void CheckItemCollection()
        {
            //If crab collects kaki
            if (CollectItem(kaki))
            {
                UpdateScore(1);                 //Increase score 
                ResetItemPosition(kaki);        //Reset kaki's position
            }

            //If crab collects lychee
            if (CollectItem(lychee))
            {
                UpdateScore(-1);                //Decrease score 
                ResetItemPosition(lychee);      //Reset lychee's position
            }

            //If crab collects lychee2
            if (CollectItem(lychee2))
            {
                UpdateScore(-1);                //Decrease score 
                ResetItemPosition(lychee2);     //Reset lychee2's position
            }
        }

        //Check if the crab intersects with a specific item and update score
        private bool CollectItem(Control item)
        {
            //Check if crab insersects with any items 
            if (crab.Bounds.IntersectsWith(item.Bounds))
            {
                return true;
            }
            return false;
        }

        //Display the score and display it in the score labal
        private void UpdateScore(int change)
        {
            score += change;                            //Update score by the secified change 
            labelScore.Text = $"Points: {score}";       //Display updated score in the score label 

            //If score reaches the win condition
            if (score == WinScore)
            {
                EndGame("WIN");             //End the game with a win message 
            }
            //If score reaches the lose condition
            else if (score == LoseScore)
            {
                EndGame("LOSE");            //End the game with a lose message 
            }
        }

        //Reset the position of a specific item to a random location at the top of the form 
        private void ResetItemPosition(Control item)
        {
            item.Location = new Point(random.Next(50, 700), 0);         //Set item's position to a random location at the top
        }

        //End the game with a specified message
        private void EndGame(string message)
        {
            labelGameOver.Text = message;       //Display the game over message 
            labelGameOver.Visible = true;       //Show the over label
            timer1.Enabled = false;             //Stop the game timer
        }

        //Key down event handler for player movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MoveCrab(e.KeyCode);        //Move the crab based on the pressed key
        }

        //Move the crab left or right based on the pressed key 
        private void MoveCrab(Keys key)
        {
            const int CrabMoveDistance = 10;        //Distance to move the crab

            if (key == Keys.Left)
            {
                crab.Left -= CrabMoveDistance;      //Move crab left
            }
            else if (key == Keys.Right)
            {
                crab.Left += CrabMoveDistance;      //Move crab right 
            }
        }

        //Check if the game is over (score reaches win or lose conditions)
        private void CheckGameOver()
        {
            if (score == WinScore || score == LoseScore)
            {
                EndGame(score == WinScore ? "WIN" : "LOSE");        //End the game with win or lose message 
            }
        }

    }
}
