namespace stadium
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlsSlide = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnstadium = new System.Windows.Forms.Button();
            this.btnReserv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reservesion1 = new reservesion();
            this.stad1 = new stad();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnlsSlide);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnstadium);
            this.panel1.Controls.Add(this.btnReserv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 535);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pnlsSlide
            // 
            this.pnlsSlide.BackColor = System.Drawing.Color.Red;
            this.pnlsSlide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlsSlide.Location = new System.Drawing.Point(0, 69);
            this.pnlsSlide.Name = "pnlsSlide";
            this.pnlsSlide.Size = new System.Drawing.Size(12, 133);
            this.pnlsSlide.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(40)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReport.Location = new System.Drawing.Point(12, 341);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(238, 133);
            this.btnReport.TabIndex = 22;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnstadium
            // 
            this.btnstadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(40)))));
            this.btnstadium.FlatAppearance.BorderSize = 0;
            this.btnstadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstadium.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstadium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnstadium.Location = new System.Drawing.Point(12, 205);
            this.btnstadium.Name = "btnstadium";
            this.btnstadium.Size = new System.Drawing.Size(238, 133);
            this.btnstadium.TabIndex = 21;
            this.btnstadium.Text = "Stadium";
            this.btnstadium.UseVisualStyleBackColor = false;
            this.btnstadium.Click += new System.EventHandler(this.Btnstadium_Click);
            // 
            // btnReserv
            // 
            this.btnReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(40)))));
            this.btnReserv.FlatAppearance.BorderSize = 0;
            this.btnReserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserv.Font = new System.Drawing.Font("Arial Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReserv.Location = new System.Drawing.Point(12, 69);
            this.btnReserv.Name = "btnReserv";
            this.btnReserv.Size = new System.Drawing.Size(238, 133);
            this.btnReserv.TabIndex = 20;
            this.btnReserv.Text = "Reserv";
            this.btnReserv.UseVisualStyleBackColor = false;
            this.btnReserv.Click += new System.EventHandler(this.BtnReserv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(-10, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 55);
            this.label3.TabIndex = 18;
            this.label3.Text = "Street Foot";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 19);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reservesion1);
            this.panel3.Controls.Add(this.stad1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(250, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 515);
            this.panel3.TabIndex = 2;
            // 
            // reservesion1
            // 
            this.reservesion1.BackColor = System.Drawing.Color.White;
            this.reservesion1.Location = new System.Drawing.Point(0, -3);
            this.reservesion1.Name = "reservesion1";
            this.reservesion1.Size = new System.Drawing.Size(614, 515);
            this.reservesion1.TabIndex = 1;
            // 
            // stad1
            // 
            this.stad1.Location = new System.Drawing.Point(0, -3);
            this.stad1.Name = "stad1";
            this.stad1.Size = new System.Drawing.Size(614, 515);
            this.stad1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReserv;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnstadium;
        private System.Windows.Forms.Panel pnlsSlide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private stad stad1;
        private reservesion reservesion1;
    }
}