namespace SimonSays
{
    partial class gameOver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doneLabel = new System.Windows.Forms.Label();
            this.againLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.doneLabel.ForeColor = System.Drawing.Color.Snow;
            this.doneLabel.Location = new System.Drawing.Point(4, 4);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(60, 24);
            this.doneLabel.TabIndex = 0;
            this.doneLabel.Text = "label1";
            // 
            // againLabel
            // 
            this.againLabel.AutoSize = true;
            this.againLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.againLabel.ForeColor = System.Drawing.Color.Snow;
            this.againLabel.Location = new System.Drawing.Point(4, 241);
            this.againLabel.Name = "againLabel";
            this.againLabel.Size = new System.Drawing.Size(60, 24);
            this.againLabel.TabIndex = 1;
            this.againLabel.Text = "label1";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(0, 399);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(212, 101);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "hit me";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(288, 399);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(212, 101);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "pls no more";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.againLabel);
            this.Controls.Add(this.doneLabel);
            this.Name = "gameOver";
            this.Size = new System.Drawing.Size(500, 500);
            this.Load += new System.EventHandler(this.gameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doneLabel;
        private System.Windows.Forms.Label againLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
    }
}
