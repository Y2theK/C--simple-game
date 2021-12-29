namespace gameTuto_floppyBird
{
    partial class Form1
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
            this.lbScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.pBGround = new System.Windows.Forms.PictureBox();
            this.pBpipeBottom = new System.Windows.Forms.PictureBox();
            this.pBpipeTop = new System.Windows.Forms.PictureBox();
            this.pBfloppyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfloppyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(-4, -2);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(94, 24);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "Score : 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // btnRestart
            // 
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Location = new System.Drawing.Point(167, 145);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 38);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pBGround
            // 
            this.pBGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBGround.Image = global::gameTuto_floppyBird.Properties.Resources.clouds;
            this.pBGround.Location = new System.Drawing.Point(0, 337);
            this.pBGround.Name = "pBGround";
            this.pBGround.Size = new System.Drawing.Size(382, 31);
            this.pBGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBGround.TabIndex = 3;
            this.pBGround.TabStop = false;
            // 
            // pBpipeBottom
            // 
            this.pBpipeBottom.Image = global::gameTuto_floppyBird.Properties.Resources.pipeBottom;
            this.pBpipeBottom.Location = new System.Drawing.Point(313, 235);
            this.pBpipeBottom.Name = "pBpipeBottom";
            this.pBpipeBottom.Size = new System.Drawing.Size(57, 96);
            this.pBpipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBpipeBottom.TabIndex = 2;
            this.pBpipeBottom.TabStop = false;
            // 
            // pBpipeTop
            // 
            this.pBpipeTop.Image = global::gameTuto_floppyBird.Properties.Resources.pipeTop;
            this.pBpipeTop.Location = new System.Drawing.Point(286, 12);
            this.pBpipeTop.Name = "pBpipeTop";
            this.pBpipeTop.Size = new System.Drawing.Size(57, 101);
            this.pBpipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBpipeTop.TabIndex = 1;
            this.pBpipeTop.TabStop = false;
            // 
            // pBfloppyBird
            // 
            this.pBfloppyBird.Image = global::gameTuto_floppyBird.Properties.Resources.flappyBird;
            this.pBfloppyBird.Location = new System.Drawing.Point(12, 42);
            this.pBfloppyBird.Name = "pBfloppyBird";
            this.pBfloppyBird.Size = new System.Drawing.Size(48, 48);
            this.pBfloppyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBfloppyBird.TabIndex = 0;
            this.pBfloppyBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(382, 368);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pBGround);
            this.Controls.Add(this.pBpipeBottom);
            this.Controls.Add(this.pBpipeTop);
            this.Controls.Add(this.pBfloppyBird);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FloppyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBfloppyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBfloppyBird;
        private System.Windows.Forms.PictureBox pBpipeTop;
        private System.Windows.Forms.PictureBox pBpipeBottom;
        private System.Windows.Forms.PictureBox pBGround;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btnRestart;
    }
}

