namespace Group1_Chan_Ridoy_QGame
{
    partial class QGameDesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QGameDesignForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.comboBoxCol = new System.Windows.Forms.ComboBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.comboBoxRow = new System.Windows.Forms.ComboBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.panelToolBox = new System.Windows.Forms.Panel();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelButton
            // 
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButton.Controls.Add(this.btnExit);
            this.panelButton.Controls.Add(this.btnSave);
            this.panelButton.Controls.Add(this.btnLoad);
            this.panelButton.Controls.Add(this.btnGenerate);
            this.panelButton.Controls.Add(this.comboBoxCol);
            this.panelButton.Controls.Add(this.lblColumn);
            this.panelButton.Controls.Add(this.comboBoxRow);
            this.panelButton.Controls.Add(this.lblRow);
            this.panelButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelButton.Location = new System.Drawing.Point(1, 1);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1476, 131);
            this.panelButton.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(1314, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 86);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(1182, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 86);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.Location = new System.Drawing.Point(1048, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 86);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerate.Location = new System.Drawing.Point(480, 22);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 86);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // comboBoxCol
            // 
            this.comboBoxCol.FormattingEnabled = true;
            this.comboBoxCol.Location = new System.Drawing.Point(323, 43);
            this.comboBoxCol.Name = "comboBoxCol";
            this.comboBoxCol.Size = new System.Drawing.Size(79, 28);
            this.comboBoxCol.TabIndex = 3;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColumn.Location = new System.Drawing.Point(229, 46);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(96, 25);
            this.lblColumn.TabIndex = 2;
            this.lblColumn.Text = "Columns:";
            // 
            // comboBoxRow
            // 
            this.comboBoxRow.FormattingEnabled = true;
            this.comboBoxRow.Location = new System.Drawing.Point(95, 43);
            this.comboBoxRow.Name = "comboBoxRow";
            this.comboBoxRow.Size = new System.Drawing.Size(79, 28);
            this.comboBoxRow.TabIndex = 1;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRow.Location = new System.Drawing.Point(32, 46);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(66, 25);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "Rows:";
            // 
            // panelToolBox
            // 
            this.panelToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelToolBox.Controls.Add(this.btnBlueBox);
            this.panelToolBox.Controls.Add(this.btnGreenBox);
            this.panelToolBox.Controls.Add(this.btnRedBox);
            this.panelToolBox.Controls.Add(this.btnBlueDoor);
            this.panelToolBox.Controls.Add(this.btnGreenDoor);
            this.panelToolBox.Controls.Add(this.btnRedDoor);
            this.panelToolBox.Controls.Add(this.btnWall);
            this.panelToolBox.Controls.Add(this.btnNone);
            this.panelToolBox.Controls.Add(this.lblToolBox);
            this.panelToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelToolBox.Location = new System.Drawing.Point(3, 130);
            this.panelToolBox.Name = "panelToolBox";
            this.panelToolBox.Size = new System.Drawing.Size(270, 1230);
            this.panelToolBox.TabIndex = 1;
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueBox.Image = ((System.Drawing.Image)(resources.GetObject("btnBlueBox.Image")));
            this.btnBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueBox.Location = new System.Drawing.Point(25, 623);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Size = new System.Drawing.Size(209, 60);
            this.btnBlueBox.TabIndex = 1;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.btnBlueBox_Click_1);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenBox.Image = ((System.Drawing.Image)(resources.GetObject("btnGreenBox.Image")));
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.Location = new System.Drawing.Point(25, 547);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(209, 60);
            this.btnGreenBox.TabIndex = 1;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedBox.Image = ((System.Drawing.Image)(resources.GetObject("btnRedBox.Image")));
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.Location = new System.Drawing.Point(25, 472);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(209, 60);
            this.btnRedBox.TabIndex = 1;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueDoor.Image = ((System.Drawing.Image)(resources.GetObject("btnBlueDoor.Image")));
            this.btnBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlueDoor.Location = new System.Drawing.Point(25, 396);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(209, 60);
            this.btnBlueDoor.TabIndex = 1;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btnBlueDoor_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenDoor.Image = ((System.Drawing.Image)(resources.GetObject("btnGreenDoor.Image")));
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.Location = new System.Drawing.Point(25, 319);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(209, 60);
            this.btnGreenDoor.TabIndex = 1;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedDoor.Image = ((System.Drawing.Image)(resources.GetObject("btnRedDoor.Image")));
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.Location = new System.Drawing.Point(25, 244);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(209, 60);
            this.btnRedDoor.TabIndex = 1;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnWall
            // 
            this.btnWall.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWall.Image = ((System.Drawing.Image)(resources.GetObject("btnWall.Image")));
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.Location = new System.Drawing.Point(25, 165);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(209, 60);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // btnNone
            // 
            this.btnNone.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNone.Image = ((System.Drawing.Image)(resources.GetObject("btnNone.Image")));
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.Location = new System.Drawing.Point(25, 87);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(209, 60);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolBox.Location = new System.Drawing.Point(73, 38);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(83, 25);
            this.lblToolBox.TabIndex = 0;
            this.lblToolBox.Text = "Toolbox";
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplay.Location = new System.Drawing.Point(273, 130);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1204, 1230);
            this.panelDisplay.TabIndex = 2;
            // 
            // QGameDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 1369);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelToolBox);
            this.Controls.Add(this.panelButton);
            this.Name = "QGameDesignForm";
            this.Text = "QGameDesignForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            this.panelToolBox.ResumeLayout(false);
            this.panelToolBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelToolBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox comboBoxCol;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.ComboBox comboBoxRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label lblToolBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}