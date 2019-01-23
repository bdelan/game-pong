namespace Pong
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStartNewGameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.menuExitGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Difficulty";
            // 
            // menuStartNewGameButton
            // 
            this.menuStartNewGameButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStartNewGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStartNewGameButton.Location = new System.Drawing.Point(58, 209);
            this.menuStartNewGameButton.Name = "menuStartNewGameButton";
            this.menuStartNewGameButton.Size = new System.Drawing.Size(183, 34);
            this.menuStartNewGameButton.TabIndex = 2;
            this.menuStartNewGameButton.Text = "Start New Game";
            this.menuStartNewGameButton.UseVisualStyleBackColor = false;
            this.menuStartNewGameButton.Click += new System.EventHandler(this.MenuStartNewGameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("KodchiangUPC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pong!";
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.BackColor = System.Drawing.Color.IndianRed;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(148, 119);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(78, 24);
            this.rbEasy.TabIndex = 4;
            this.rbEasy.Text = "Easy    ";
            this.rbEasy.UseVisualStyleBackColor = false;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.BackColor = System.Drawing.Color.IndianRed;
            this.rbNormal.Checked = true;
            this.rbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(148, 149);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(77, 24);
            this.rbNormal.TabIndex = 5;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = false;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.BackColor = System.Drawing.Color.IndianRed;
            this.rbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(148, 179);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(78, 24);
            this.rbHard.TabIndex = 6;
            this.rbHard.Text = "Hard    ";
            this.rbHard.UseVisualStyleBackColor = false;
            // 
            // menuExitGame
            // 
            this.menuExitGame.BackColor = System.Drawing.Color.Crimson;
            this.menuExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExitGame.Location = new System.Drawing.Point(98, 253);
            this.menuExitGame.Name = "menuExitGame";
            this.menuExitGame.Size = new System.Drawing.Size(102, 23);
            this.menuExitGame.TabIndex = 7;
            this.menuExitGame.Text = "Exit Game";
            this.menuExitGame.UseVisualStyleBackColor = false;
            this.menuExitGame.Click += new System.EventHandler(this.MenuExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 269);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 292);
            this.Controls.Add(this.menuExitGame);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStartNewGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong Game - Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuStartNewGameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.Button menuExitGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}