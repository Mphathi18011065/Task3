namespace Task2_18011065_MphathiMaapola
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
            this.grpMap = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblResource = new System.Windows.Forms.Label();
            this.lblAr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpMap
            // 
            this.grpMap.Location = new System.Drawing.Point(22, 12);
            this.grpMap.Name = "grpMap";
            this.grpMap.Size = new System.Drawing.Size(556, 427);
            this.grpMap.TabIndex = 0;
            this.grpMap.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(585, 29);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(203, 410);
            this.txtInfo.TabIndex = 5;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(585, 13);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(48, 13);
            this.lblRound.TabIndex = 6;
            this.lblRound.Text = "Round : ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(585, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(666, 474);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read ";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(585, 445);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(666, 445);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Location = new System.Drawing.Point(24, 456);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(64, 13);
            this.lblResource.TabIndex = 11;
            this.lblResource.Text = "Resources :";
            // 
            // lblAr
            // 
            this.lblAr.AutoSize = true;
            this.lblAr.Location = new System.Drawing.Point(24, 474);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(105, 13);
            this.lblAr.TabIndex = 12;
            this.lblAr.Text = "Resources aquired  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 523);
            this.Controls.Add(this.lblAr);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.grpMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMap;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Label lblAr;
    }
}

