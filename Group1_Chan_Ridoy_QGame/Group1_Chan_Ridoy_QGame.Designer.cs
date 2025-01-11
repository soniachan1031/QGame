namespace Group1_Chan_Ridoy_QGame
{
    partial class Group1_Chan_Ridoy_QGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group1_Chan_Ridoy_QGame));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDesign = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(173, 73);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(504, 47);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to QGame World";
            // 
            // btnDesign
            // 
            this.btnDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDesign.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesign.Image = ((System.Drawing.Image)(resources.GetObject("btnDesign.Image")));
            this.btnDesign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesign.Location = new System.Drawing.Point(181, 194);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(215, 94);
            this.btnDesign.TabIndex = 1;
            this.btnDesign.Text = "Design";
            this.btnDesign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesign.UseVisualStyleBackColor = false;
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlay.Location = new System.Drawing.Point(446, 194);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(215, 94);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(316, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 94);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Group1_Chan_Ridoy_QGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 587);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnDesign);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Group1_Chan_Ridoy_QGame";
            this.Text = "Group1_Chan_Ridoy_QGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
    }
}

