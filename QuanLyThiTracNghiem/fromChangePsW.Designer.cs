
namespace QuanLyThiTracNghiem
{
    partial class fromChangePsW
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(188, 193);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 39);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đổi Mật Khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(188, 147);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '❤';
            this.txtPassWord.Size = new System.Drawing.Size(193, 31);
            this.txtPassWord.TabIndex = 12;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(188, 88);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '❤';
            this.txtOldPass.Size = new System.Drawing.Size(193, 31);
            this.txtOldPass.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mật Khẩu Cũ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu Mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromChangePsW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 270);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "fromChangePsW";
            this.Text = "fromChangePsW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}