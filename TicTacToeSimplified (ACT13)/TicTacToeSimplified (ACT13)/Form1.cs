using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeSimplified__ACT13_
{
    public partial class Form1 : Form
    {
        bool turn = true; // true is x false is o
        int turnCount = 0;

        public Form1()
        {
           InitializeComponent(); 
        }

        public void Squares()
        {
            PictureBox[][] squaresPlace = new PictureBox[][]
            {
        new PictureBox[] { R1C1, R1C2, R1C3},
        new PictureBox[] { R2C1, R2C2, R2C3 },
        new PictureBox[] { R3C1, R3C2, R3C3 },
            };
            
        }
        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click where you would like to place the mark." + 
                "The game will automatically change the player." +
                " Continue back and forth until there is a winner or the grid is full.", "Tic Tac Toe About");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Mark(object sender, EventArgs e)
        {
           PictureBox b = (PictureBox)sender;
            
            

            if (turn)
            {
                b.Image = imageList1.Images[0];
                b.Tag = "x";
            }
            else
            {
                b.Image = imageList1.Images[1];
                b.Tag = "o";

            }
            turn = !turn;
            
            b.Enabled = false;
            turnCount++;

            WinCheck();
        }//Mark end
        

        private void WinCheck()
        {
            Squares();
            bool Winner = false;


            
            //Horizontal Check
            if ((R1C1.Tag == R1C2.Tag) && (R1C2.Tag == R1C3.Tag) && (!R1C1.Enabled))
                Winner = true;
            if ((R2C1.Tag == R2C2.Tag) && (R2C2.Tag == R2C3.Tag) && (!R2C1.Enabled))
                Winner = true;
            if ((R3C1.Tag == R3C2.Tag) && (R3C2.Tag == R3C3.Tag) && (!R3C1.Enabled))
                Winner = true;

            //Vertical Checks
            if ((R1C1.Tag == R2C1.Tag) && (R2C1.Tag == R3C1.Tag) && (!R1C1.Enabled))
                Winner = true;
            if ((R1C2.Tag == R2C2.Tag) && (R2C2.Tag == R3C2.Tag) && (!R1C2.Enabled))
                Winner = true;
            if ((R1C3.Tag == R2C3.Tag) && (R2C3.Tag == R3C3.Tag) && (!R1C3.Enabled))
                Winner = true;

            //Diag Check
            if ((R1C1.Tag == R2C2.Tag) && (R2C2.Tag == R3C3.Tag) && (!R1C1.Enabled))
                Winner = true;
            if ((R3C1.Tag == R2C2.Tag) && (R2C2.Tag == R1C3.Tag) && (!R3C1.Enabled))
                Winner = true;

            if (Winner)
            {
                endGame();

                string win = "";
                if (turn)
                    win = "O";
                else
                    win = "X";

                MessageBox.Show("" + win + " Wins!", "WINNER WINNER");
            }// end if
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Cats Game", "OOF");
            }
            
        }//wincheck end


        private void endGame()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    PictureBox b = (PictureBox)c;
                    b.Enabled = false;
                }
            }//end try
            catch { }
           
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    PictureBox b = (PictureBox)c;
                    b.Enabled = true;
                    b.Image = null;
                    b.Tag = "";
                }
            }//end try
            catch { }
        }
    }
}
