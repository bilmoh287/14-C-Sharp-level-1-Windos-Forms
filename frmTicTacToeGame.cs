using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class frmTicTacToeGame : Form
    {
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        enum enPlayer {Player1, Player2};
        enum enWinner {Player1, Player2, Draw, InProgress };

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        public void EndGame()
        {
            lblTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public bool CheckWinner(Button btn1, Button btn2, Button btn3)
        {
            if(btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                //Change winning buttons color
                btn1.BackColor = Color.Yellow;
                btn2.BackColor = Color.Yellow;
                btn3.BackColor = Color.Yellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;
        }

        public void CheckGameWinner()
        {
            //Check Row 1
            if (CheckWinner(button1, button2, button3))
                return;

            //Check Row 2
            if (CheckWinner(button4, button5, button6))
                return;

            //Check Row 3
            if (CheckWinner(button7, button8, button9))
                return;

            //Check Column 1
            if (CheckWinner(button1, button4, button7))
                return;

            //Check Column 2
            if (CheckWinner(button2, button5, button8))
                return;

            //Check Column 3
            if (CheckWinner(button3, button6, button9))
                return;

            //Check Diagonal 1
            if (CheckWinner(button1, button5, button9))
                return;

            //Check Diagonal 2
            if (CheckWinner(button3, button5, button7))
                return;
        }

        public void ChangeImage(Button btn)
        {
            if(btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                { 
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player 2";
                        btn.Tag = "X";
                        GameStatus.PlayCount++;
                        CheckGameWinner();
                        break;
                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player 1";
                        btn.Tag = "O";
                        GameStatus.PlayCount++;
                        CheckGameWinner();
                        break;

                }

            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount == 9)
            {
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = false;
                EndGame();
            }
        }

        void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        public void RestartGame()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            lblTurn.Text = "Player 1";
            PlayerTurn = enPlayer.Player1;
            lblWinner.Text = "In Progress";
            GameStatus.Winner = enWinner.InProgress;
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
        }

        public frmTicTacToeGame()
        {
            InitializeComponent();
        }

        private void frmTicTacToeGame_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitePen = new Pen(white);
            whitePen.Width = 15;
            //whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //draw Horizental lines
            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460);

            //draw Vertical lines
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620);
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620);
        }

        private void frmTicTacToeGame_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

    }
}
