
namespace snake_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.camSnake = new System.Windows.Forms.PictureBox();
            this.currentScore = new System.Windows.Forms.Label();
            this.scoreMade = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.camSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSalmon;
            this.startButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(597, 68);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(124, 56);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startGame);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.Maroon;
            this.snapButton.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snapButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.snapButton.Location = new System.Drawing.Point(597, 141);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(124, 58);
            this.snapButton.TabIndex = 1;
            this.snapButton.Text = "Snap";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeaSnap);
            // 
            // camSnake
            // 
            this.camSnake.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.camSnake.Location = new System.Drawing.Point(11, 12);
            this.camSnake.Name = "camSnake";
            this.camSnake.Size = new System.Drawing.Size(580, 680);
            this.camSnake.TabIndex = 2;
            this.camSnake.TabStop = false;
            this.camSnake.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // currentScore
            // 
            this.currentScore.AutoSize = true;
            this.currentScore.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentScore.Location = new System.Drawing.Point(597, 12);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(54, 19);
            this.currentScore.TabIndex = 3;
            this.currentScore.Text = "Score : 0";
            // 
            // scoreMade
            // 
            this.scoreMade.AutoSize = true;
            this.scoreMade.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreMade.Location = new System.Drawing.Point(597, 31);
            this.scoreMade.Name = "scoreMade";
            this.scoreMade.Size = new System.Drawing.Size(79, 19);
            this.scoreMade.TabIndex = 4;
            this.scoreMade.Text = "HighScore : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.scoreMade);
            this.Controls.Add(this.currentScore);
            this.Controls.Add(this.camSnake);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.camSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.PictureBox camSnake;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.Label scoreMade;
        private System.Windows.Forms.Timer gameTimer;
    }
}

