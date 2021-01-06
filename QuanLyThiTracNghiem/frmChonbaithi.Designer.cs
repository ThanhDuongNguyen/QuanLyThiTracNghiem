
namespace QuanLyThiTracNghiem
{
    partial class frmChonbaithi
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
            this.btn_Chon = new System.Windows.Forms.Button();
            this.cbb_MaDe = new System.Windows.Forms.ComboBox();
            this.cbb_Mon = new System.Windows.Forms.ComboBox();
            this.cbb_Ky_Thi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Chon
            // 
            this.btn_Chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Location = new System.Drawing.Point(153, 143);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(85, 40);
            this.btn_Chon.TabIndex = 10;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = true;
            // 
            // cbb_MaDe
            // 
            this.cbb_MaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaDe.FormattingEnabled = true;
            this.cbb_MaDe.Location = new System.Drawing.Point(107, 101);
            this.cbb_MaDe.Name = "cbb_MaDe";
            this.cbb_MaDe.Size = new System.Drawing.Size(226, 32);
            this.cbb_MaDe.TabIndex = 7;
            // 
            // cbb_Mon
            // 
            this.cbb_Mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Mon.FormattingEnabled = true;
            this.cbb_Mon.Location = new System.Drawing.Point(107, 57);
            this.cbb_Mon.Name = "cbb_Mon";
            this.cbb_Mon.Size = new System.Drawing.Size(226, 32);
            this.cbb_Mon.TabIndex = 8;
            // 
            // cbb_Ky_Thi
            // 
            this.cbb_Ky_Thi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ky_Thi.FormattingEnabled = true;
            this.cbb_Ky_Thi.Location = new System.Drawing.Point(107, 16);
            this.cbb_Ky_Thi.Name = "cbb_Ky_Thi";
            this.cbb_Ky_Thi.Size = new System.Drawing.Size(226, 32);
            this.cbb_Ky_Thi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Đề:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kì Thi:";
            // 
            // frmChonbaithi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 195);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.cbb_MaDe);
            this.Controls.Add(this.cbb_Mon);
            this.Controls.Add(this.cbb_Ky_Thi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChonbaithi";
            this.Text = "frmChonbaithi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.ComboBox cbb_MaDe;
        private System.Windows.Forms.ComboBox cbb_Mon;
        private System.Windows.Forms.ComboBox cbb_Ky_Thi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}