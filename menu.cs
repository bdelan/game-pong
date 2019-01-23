//==========================================
// Title:  Pong Game
// Author: Borja Delgado
// Date:   15 Dec 2015
// .........................................
// Description:
// 	Playable version of the well known Atari
// 	video game PONG!
// #########################################
// Class Menu:
//  Game difficulty selection.
//  New game button.
//  Exit button.
//==========================================

using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class Menu : Form
    {
        public int MenuSpeed;
        public int MenuBallx;
        public int MenuBally;

        public Menu()
        {
            InitializeComponent();
        }

        private void MenuStartNewGameButton_Click(object sender, EventArgs e)
        {

            if (rbEasy.Checked)
            {
                MenuSpeed = 7;
                MenuBallx = 7;
                MenuBally = 7;
            }
            else if (rbNormal.Checked)
            {
                MenuSpeed = 10;
                MenuBallx = 10;
                MenuBally = 10;
            }
            else if (rbHard.Checked)
            {
                MenuSpeed = 15;
                MenuBallx = 15;
                MenuBally = 15;
            }

            this.Hide();
            Game game = new Game(MenuSpeed, MenuBallx, MenuBally);
            game.ShowDialog();
        }

        private void MenuExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
