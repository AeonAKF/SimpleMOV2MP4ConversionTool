namespace MediaConversionTool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBoxOpen = new System.Windows.Forms.TextBox();
            this.txtBoxSave = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.prgConvert = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(9, 10);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(392, 54);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "1 - Open Media File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(9, 102);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(392, 57);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "2 - Save to Folder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(9, 266);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(286, 41);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "4 - Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(299, 266);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 41);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxOpen
            // 
            this.txtBoxOpen.Location = new System.Drawing.Point(9, 69);
            this.txtBoxOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxOpen.Name = "txtBoxOpen";
            this.txtBoxOpen.Size = new System.Drawing.Size(393, 20);
            this.txtBoxOpen.TabIndex = 4;
            this.txtBoxOpen.Text = "D:\\Temp\\File.mov";
            // 
            // txtBoxSave
            // 
            this.txtBoxSave.Location = new System.Drawing.Point(9, 163);
            this.txtBoxSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxSave.Name = "txtBoxSave";
            this.txtBoxSave.Size = new System.Drawing.Size(393, 20);
            this.txtBoxSave.TabIndex = 5;
            this.txtBoxSave.Text = "D:\\Temp\\";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(9, 193);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 13);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "3 - File Name";
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(82, 193);
            this.txtBoxFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(320, 20);
            this.txtBoxFileName.TabIndex = 7;
            this.txtBoxFileName.Text = "Output.mp4";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(14, 218);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(397, 17);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "A message will be displayed when the conversion is complete.";
            // 
            // prgConvert
            // 
            this.prgConvert.Location = new System.Drawing.Point(9, 238);
            this.prgConvert.MarqueeAnimationSpeed = 0;
            this.prgConvert.Name = "prgConvert";
            this.prgConvert.Size = new System.Drawing.Size(391, 23);
            this.prgConvert.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgConvert.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 312);
            this.Controls.Add(this.prgConvert);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtBoxSave);
            this.Controls.Add(this.txtBoxOpen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Conversion Tool v1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBoxOpen;
        private System.Windows.Forms.TextBox txtBoxSave;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar prgConvert;
    }
}

