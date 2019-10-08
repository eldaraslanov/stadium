namespace stadium
{
    partial class stad
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
            this.txtstadName = new System.Windows.Forms.TextBox();
            this.txtStadPrice = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.nmUpRoomPerson = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.txtstadNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewStad = new System.Windows.Forms.DataGridView();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmUpRoomPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstadName
            // 
            this.txtstadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstadName.Location = new System.Drawing.Point(15, 43);
            this.txtstadName.Name = "txtstadName";
            this.txtstadName.Size = new System.Drawing.Size(144, 30);
            this.txtstadName.TabIndex = 28;
            // 
            // txtStadPrice
            // 
            this.txtStadPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStadPrice.Location = new System.Drawing.Point(315, 43);
            this.txtStadPrice.Name = "txtStadPrice";
            this.txtStadPrice.Size = new System.Drawing.Size(83, 30);
            this.txtStadPrice.TabIndex = 30;
            this.txtStadPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStadPrice_KeyPress);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(15, 124);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(144, 30);
            this.txtRoomName.TabIndex = 31;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo.Location = new System.Drawing.Point(165, 124);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(144, 30);
            this.txtRoomNo.TabIndex = 32;
            this.txtRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRoomNo_KeyPress);
            // 
            // nmUpRoomPerson
            // 
            this.nmUpRoomPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUpRoomPerson.Location = new System.Drawing.Point(315, 124);
            this.nmUpRoomPerson.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmUpRoomPerson.Name = "nmUpRoomPerson";
            this.nmUpRoomPerson.Size = new System.Drawing.Size(83, 30);
            this.nmUpRoomPerson.TabIndex = 33;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(200)))), ((int)(((byte)(40)))));
            this.btnAdd.Location = new System.Drawing.Point(434, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 80);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add.";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.Red;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.White;
            this.lblerror.Location = new System.Drawing.Point(429, 141);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(71, 25);
            this.lblerror.TabIndex = 36;
            this.lblerror.Text = "lblerror";
            this.lblerror.Visible = false;
            // 
            // txtstadNo
            // 
            this.txtstadNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstadNo.Location = new System.Drawing.Point(165, 43);
            this.txtstadNo.Name = "txtstadNo";
            this.txtstadNo.Size = new System.Drawing.Size(144, 30);
            this.txtstadNo.TabIndex = 29;
            this.txtstadNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtstadNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "St. Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "St. No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "St. Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ro. Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ro. No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Person";
            // 
            // dataGridViewStad
            // 
            this.dataGridViewStad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStad.Location = new System.Drawing.Point(0, 235);
            this.dataGridViewStad.Name = "dataGridViewStad";
            this.dataGridViewStad.Size = new System.Drawing.Size(272, 277);
            this.dataGridViewStad.TabIndex = 43;
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(313, 235);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(298, 277);
            this.dataGridViewRoom.TabIndex = 44;
            // 
            // stad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.dataGridViewStad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nmUpRoomPerson);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtStadPrice);
            this.Controls.Add(this.txtstadNo);
            this.Controls.Add(this.txtstadName);
            this.Name = "stad";
            this.Size = new System.Drawing.Size(614, 515);
            this.Load += new System.EventHandler(this.Stad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmUpRoomPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstadName;
        private System.Windows.Forms.TextBox txtStadPrice;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.NumericUpDown nmUpRoomPerson;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txtstadNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewStad;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
    }
}
