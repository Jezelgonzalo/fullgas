namespace fullgas
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.pbloading = new System.Windows.Forms.ProgressBar();
            this.lblstatementprogress = new System.Windows.Forms.Label();
            this.lbprogress = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbstatementprog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbloading
            // 
            this.pbloading.Location = new System.Drawing.Point(38, 250);
            this.pbloading.Margin = new System.Windows.Forms.Padding(2);
            this.pbloading.Name = "pbloading";
            this.pbloading.Size = new System.Drawing.Size(519, 27);
            this.pbloading.TabIndex = 1;
            // 
            // lblstatementprogress
            // 
            this.lblstatementprogress.AutoSize = true;
            this.lblstatementprogress.BackColor = System.Drawing.Color.Transparent;
            this.lblstatementprogress.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblstatementprogress.Location = new System.Drawing.Point(35, 225);
            this.lblstatementprogress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatementprogress.Name = "lblstatementprogress";
            this.lblstatementprogress.Size = new System.Drawing.Size(104, 13);
            this.lblstatementprogress.TabIndex = 2;
            this.lblstatementprogress.Text = "Filling up your tank...";
            this.lblstatementprogress.Click += new System.EventHandler(this.lblstatementprogress_Click);
            // 
            // lbprogress
            // 
            this.lbprogress.AutoSize = true;
            this.lbprogress.BackColor = System.Drawing.Color.Transparent;
            this.lbprogress.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbprogress.Location = new System.Drawing.Point(535, 285);
            this.lbprogress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbprogress.Name = "lbprogress";
            this.lbprogress.Size = new System.Drawing.Size(21, 13);
            this.lbprogress.TabIndex = 3;
            this.lbprogress.Text = "0%";
            this.lbprogress.Click += new System.EventHandler(this.lbprogress_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbstatementprog
            // 
            this.lbstatementprog.AutoSize = true;
            this.lbstatementprog.BackColor = System.Drawing.Color.Transparent;
            this.lbstatementprog.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbstatementprog.Location = new System.Drawing.Point(35, 285);
            this.lbstatementprog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbstatementprog.Name = "lbstatementprog";
            this.lbstatementprog.Size = new System.Drawing.Size(135, 13);
            this.lbstatementprog.TabIndex = 4;
            this.lbstatementprog.Text = "You\'re tank has been filled!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(194, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(609, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbstatementprog);
            this.Controls.Add(this.lbprogress);
            this.Controls.Add(this.lblstatementprogress);
            this.Controls.Add(this.pbloading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbloading;
        private System.Windows.Forms.Label lblstatementprogress;
        private System.Windows.Forms.Label lbprogress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbstatementprog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}