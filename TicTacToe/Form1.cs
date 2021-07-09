using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        byte turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            WeHaveAWinner();
        }

        private void WeHaveAWinner()
        {
            bool We_Have_A_Winner = false;

            //Horizontal Winner
            if ((btnTL.Text == btnTM.Text) && (btnTM.Text == btnTR.Text) && (!btnTL.Enabled))
                We_Have_A_Winner = true;
            else if ((btnML.Text == btnMM.Text) && (btnMM.Text == btnMR.Text) && (!btnML.Enabled))
                We_Have_A_Winner = true;
            else if ((btnBL.Text == btnBM.Text) && (btnTM.Text == btnBR.Text) && (!btnBL.Enabled))
                We_Have_A_Winner = true;

            //Vertical Winner
            else if ((btnTL.Text == btnML.Text) && (btnML.Text == btnBL.Text) && (!btnTL.Enabled))
                We_Have_A_Winner = true;
            else if ((btnTM.Text == btnMM.Text) && (btnMM.Text == btnBM.Text) && (!btnTM.Enabled))
                We_Have_A_Winner = true;
            else if ((btnTR.Text == btnMR.Text) && (btnMR.Text == btnBR.Text) && (!btnTR.Enabled))
                We_Have_A_Winner = true;

            //Diagonal Winner
            else if ((btnTL.Text == btnMM.Text) && (btnMM.Text == btnBR.Text) && (!btnTL.Enabled))
                We_Have_A_Winner = true;
            else if ((btnTR.Text == btnMM.Text) && (btnMM.Text == btnBL.Text) && (!btnTR.Enabled))
                We_Have_A_Winner = true;


            if (We_Have_A_Winner)
            {
                stopPlaying();

                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " has Won!", "Result");
            }
            else
            {
                if(turn_count == 9)
                    MessageBox.Show("It's a draw, please try again", "Sorry");
            }
        }

        private void stopPlaying()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
        private void tryAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }

}
 