
namespace QuanLyThiTracNghiem
{
    partial class frmThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTin));
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.dpStudent_birth_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudent_class = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtStudent_phone_number = new System.Windows.Forms.TextBox();
            this.txtStudent_Name = new System.Windows.Forms.TextBox();
            this.txtSudent_code = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(269, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 33);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            this.btnFix.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnFix.FlatAppearance.BorderSize = 3;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFix.Image = ((System.Drawing.Image)(resources.GetObject("btnFix.Image")));
            this.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFix.Location = new System.Drawing.Point(138, 383);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(66, 33);
            this.btnFix.TabIndex = 50;
            this.btnFix.Text = "Sửa";
            this.btnFix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFix.UseVisualStyleBackColor = true;
            // 
            // dpStudent_birth_date
            // 
            this.dpStudent_birth_date.Enabled = false;
            this.dpStudent_birth_date.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStudent_birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStudent_birth_date.Location = new System.Drawing.Point(169, 243);
            this.dpStudent_birth_date.Name = "dpStudent_birth_date";
            this.dpStudent_birth_date.Size = new System.Drawing.Size(220, 30);
            this.dpStudent_birth_date.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.Highlight;
            label5.Location = new System.Drawing.Point(42, 308);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 23);
            label5.TabIndex = 40;
            label5.Text = "Lớp học:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.Highlight;
            label8.Location = new System.Drawing.Point(42, 202);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(120, 23);
            label8.TabIndex = 41;
            label8.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Highlight;
            label3.Location = new System.Drawing.Point(42, 112);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(66, 23);
            label3.TabIndex = 42;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.Highlight;
            label2.Location = new System.Drawing.Point(44, 250);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 23);
            label2.TabIndex = 43;
            label2.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 33);
            this.label6.TabIndex = 44;
            this.label6.Text = "Thông Tin Học Sinh";
            this.label6.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.White;
            label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.Highlight;
            label4.Location = new System.Drawing.Point(41, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 23);
            label4.TabIndex = 45;
            label4.Text = "Mssv:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(41, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 23);
            label1.TabIndex = 47;
            label1.Text = "Tài Khoản:";
            // 
            // txtStudent_class
            // 
            this.txtStudent_class.Enabled = false;
            this.txtStudent_class.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent_class.Location = new System.Drawing.Point(166, 302);
            this.txtStudent_class.Name = "txtStudent_class";
            this.txtStudent_class.Size = new System.Drawing.Size(223, 31);
            this.txtStudent_class.TabIndex = 34;
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(166, 146);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(223, 31);
            this.txtCMND.TabIndex = 37;
            // 
            // txtStudent_phone_number
            // 
            this.txtStudent_phone_number.Enabled = false;
            this.txtStudent_phone_number.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent_phone_number.Location = new System.Drawing.Point(166, 195);
            this.txtStudent_phone_number.Name = "txtStudent_phone_number";
            this.txtStudent_phone_number.Size = new System.Drawing.Size(223, 31);
            this.txtStudent_phone_number.TabIndex = 35;
            // 
            // txtStudent_Name
            // 
            this.txtStudent_Name.Enabled = false;
            this.txtStudent_Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent_Name.Location = new System.Drawing.Point(166, 105);
            this.txtStudent_Name.Name = "txtStudent_Name";
            this.txtStudent_Name.Size = new System.Drawing.Size(223, 31);
            this.txtStudent_Name.TabIndex = 38;
            // 
            // txtSudent_code
            // 
            this.txtSudent_code.Enabled = false;
            this.txtSudent_code.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSudent_code.Location = new System.Drawing.Point(166, 65);
            this.txtSudent_code.Name = "txtSudent_code";
            this.txtSudent_code.Size = new System.Drawing.Size(223, 31);
            this.txtSudent_code.TabIndex = 39;
            // 
            // frmThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.dpStudent_birth_date);
            this.Controls.Add(label5);
            this.Controls.Add(label8);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtStudent_class);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtStudent_phone_number);
            this.Controls.Add(this.txtStudent_Name);
            this.Controls.Add(this.txtSudent_code);
            this.Name = "frmThongTin";
            this.Text = "frmThongTin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.DateTimePicker dpStudent_birth_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudent_class;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtStudent_phone_number;
        private System.Windows.Forms.TextBox txtStudent_Name;
        private System.Windows.Forms.TextBox txtSudent_code;
    }
}