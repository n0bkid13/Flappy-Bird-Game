namespace game
{
    partial class Flappy_Birds
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
            this.components = new System.ComponentModel.Container();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(9, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(110, 36);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // ground
            // 
            this.ground.Image = global::game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 609);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(691, 76);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::game.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(12, 108);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(61, 50);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 2;
            this.FlappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::game.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(548, -1);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 209);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::game.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(297, 355);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 257);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 0;
            this.pipeBottom.TabStop = false;
            // 
            // Flappy_Birds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 678);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Name = "Flappy_Birds";
            this.Text = "Flappy_Birds";
            this.Load += new System.EventHandler(this.Flappy_Birds_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}