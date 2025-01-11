namespace Group1_Chan_Ridoy_QGame
{
    partial class QGamePlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QGamePlayForm));
            this.panelRecord = new System.Windows.Forms.Panel();
            this.txtBoxes = new System.Windows.Forms.TextBox();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblNumberOfBoxes = new System.Windows.Forms.Label();
            this.lblNumberOfMoves = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblControlPanel = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gameLogo = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelRecord.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRecord
            // 
            this.panelRecord.BackColor = System.Drawing.Color.Black;
            this.panelRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRecord.Controls.Add(this.txtBoxes);
            this.panelRecord.Controls.Add(this.txtMoves);
            this.panelRecord.Controls.Add(this.lblNumberOfBoxes);
            this.panelRecord.Controls.Add(this.lblNumberOfMoves);
            this.panelRecord.Controls.Add(this.btnLoad);
            this.panelRecord.Controls.Add(this.lblControlPanel);
            this.panelRecord.Location = new System.Drawing.Point(1304, 1);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(341, 657);
            this.panelRecord.TabIndex = 0;
            // 
            // txtBoxes
            // 
            this.txtBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxes.Location = new System.Drawing.Point(117, 478);
            this.txtBoxes.Multiline = true;
            this.txtBoxes.Name = "txtBoxes";
            this.txtBoxes.Size = new System.Drawing.Size(109, 40);
            this.txtBoxes.TabIndex = 5;
            this.txtBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMoves
            // 
            this.txtMoves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoves.Location = new System.Drawing.Point(117, 323);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(109, 40);
            this.txtMoves.TabIndex = 4;
            this.txtMoves.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumberOfBoxes
            // 
            this.lblNumberOfBoxes.AutoSize = true;
            this.lblNumberOfBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBoxes.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfBoxes.Location = new System.Drawing.Point(82, 441);
            this.lblNumberOfBoxes.Name = "lblNumberOfBoxes";
            this.lblNumberOfBoxes.Size = new System.Drawing.Size(184, 25);
            this.lblNumberOfBoxes.TabIndex = 3;
            this.lblNumberOfBoxes.Text = "Number of Boxes:";
            // 
            // lblNumberOfMoves
            // 
            this.lblNumberOfMoves.AutoSize = true;
            this.lblNumberOfMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMoves.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfMoves.Location = new System.Drawing.Point(78, 288);
            this.lblNumberOfMoves.Name = "lblNumberOfMoves";
            this.lblNumberOfMoves.Size = new System.Drawing.Size(188, 25);
            this.lblNumberOfMoves.TabIndex = 2;
            this.lblNumberOfMoves.Text = "Number of Moves:";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.FlatAppearance.BorderSize = 4;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Image = global::Group1_Chan_Ridoy_QGame.Properties.Resources.open_file_24;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.Location = new System.Drawing.Point(83, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(172, 89);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblControlPanel
            // 
            this.lblControlPanel.AutoSize = true;
            this.lblControlPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlPanel.ForeColor = System.Drawing.Color.White;
            this.lblControlPanel.Location = new System.Drawing.Point(82, 44);
            this.lblControlPanel.Name = "lblControlPanel";
            this.lblControlPanel.Size = new System.Drawing.Size(172, 29);
            this.lblControlPanel.TabIndex = 0;
            this.lblControlPanel.Text = "Control Panel";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Black;
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControl.Controls.Add(this.lblWelcome);
            this.panelControl.Controls.Add(this.gameLogo);
            this.panelControl.Controls.Add(this.btnDown);
            this.panelControl.Controls.Add(this.btnRight);
            this.panelControl.Controls.Add(this.btnLeft);
            this.panelControl.Controls.Add(this.btnUp);
            this.panelControl.Location = new System.Drawing.Point(1304, 664);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(341, 679);
            this.panelControl.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(86, 387);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(180, 33);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "QGame World";
            // 
            // gameLogo
            // 
            this.gameLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("gameLogo.ErrorImage")));
            this.gameLogo.Image = ((System.Drawing.Image)(resources.GetObject("gameLogo.Image")));
            this.gameLogo.Location = new System.Drawing.Point(44, 399);
            this.gameLogo.Name = "gameLogo";
            this.gameLogo.Size = new System.Drawing.Size(270, 239);
            this.gameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameLogo.TabIndex = 4;
            this.gameLogo.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDown.Image = global::Group1_Chan_Ridoy_QGame.Properties.Resources.down_arrow_24;
            this.btnDown.Location = new System.Drawing.Point(132, 257);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(79, 66);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRight.Image = global::Group1_Chan_Ridoy_QGame.Properties.Resources.right_arrow_24;
            this.btnRight.Location = new System.Drawing.Point(212, 183);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(79, 66);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Image = global::Group1_Chan_Ridoy_QGame.Properties.Resources.left_arrow_24;
            this.btnLeft.Location = new System.Drawing.Point(57, 183);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(71, 66);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUp.Image = global::Group1_Chan_Ridoy_QGame.Properties.Resources.up_arrow_24;
            this.btnUp.Location = new System.Drawing.Point(131, 113);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(79, 66);
            this.btnUp.TabIndex = 0;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.Yellow;
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelDisplay.Location = new System.Drawing.Point(1, 1);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1297, 1342);
            this.panelDisplay.TabIndex = 2;
            // 
            // QGamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 1345);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelRecord);
            this.Controls.Add(this.panelDisplay);
            this.Name = "QGamePlayForm";
            this.Text = "QGamePlayForm";
            this.panelRecord.ResumeLayout(false);
            this.panelRecord.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblControlPanel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblNumberOfMoves;
        private System.Windows.Forms.TextBox txtBoxes;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblNumberOfBoxes;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.PictureBox gameLogo;
        private System.Windows.Forms.Label lblWelcome;
    }
}