//==========================================
// Title:  Pong Game
// Author: Borja Delgado
// Date:   15 Dec 2015
// .........................................
// Description:
// 	Playable version of the well known Atari
// 	video game PONG!
// #########################################
// Class Game:
//  Player movements.
//  CPU and ball speed.
//  Player and CPU life counters.
//  Player, CPU and ball window limitations.
//  New game button.
//  Exit button.
//==========================================

using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Game : Form
    {
        private bool _moveUp;
        private bool _moveDown;

        private int _cpuSpeed;
        private int _ballSpeedX;
        private int _ballSpeedY;

        private int _playerScore = 7;
        private int _cpuScore    = 7;

        public Game(int menuSpeed, int menuBallX, int menuBallY)
        {
            _cpuSpeed   = menuSpeed;
            _ballSpeedX = menuBallX;
            _ballSpeedY = menuBallY;
            
            InitializeComponent();
            ControlBox = false;
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _moveUp = true;
                    break;
                case Keys.Down:
                    _moveDown = true;
                    break;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _moveUp = false;
                    break;
                case Keys.Down:
                    _moveDown = false;
                    break;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + _playerScore;
            cpuScore.Text    = "" + _cpuScore;

            ball.Top  -= _ballSpeedY;
            ball.Left -= _ballSpeedX;

            cpu.Top += _cpuSpeed;

            if (cpu.Top > 455 || cpu.Bounds.IntersectsWith(gameMenu.Bounds))
            {
                _cpuSpeed = -_cpuSpeed;
            }

            if (ball.Left < 0)
            {
                ball.Left = 434;
                _ballSpeedX = -_ballSpeedX;
                _ballSpeedX -= 2;
                _playerScore--;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                _ballSpeedX = -_ballSpeedX;
                _ballSpeedX += 2;
                _cpuScore--;
            }

            if (ball.Top < 10 || ball.Top + ball.Height > ClientSize.Height || ball.Bounds.IntersectsWith(gameMenu.Bounds))
            {
                _ballSpeedY = -_ballSpeedY;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                _ballSpeedX = -_ballSpeedX;
            }

            if (_moveUp && player.Top > 0)
            {
                player.Top -= 20;
            }

            if (_moveDown && player.Top < 455 || player.Bounds.IntersectsWith(gameMenu.Bounds))
            {
                player.Top += 20;
            }

            if (_playerScore <= 0)
            {
                playerScore.Text = "" + _playerScore;
                gameTimer.Stop();
                MessageBox.Show("CPU wins, you loose \n\n" +
                                "Click 'OK' for new game");
                ResetGame();
            }

            if (_cpuScore <= 0)
            {
                cpuScore.Text = "" + _cpuScore;
                gameTimer.Stop();
                MessageBox.Show("You win! \n\n" +
                                "Want to play again?");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            Application.Restart();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            ResetGame();
        }

        private void ExitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
