
namespace QuanLyThiTracNghiem
{
    partial class frmChonDeOn
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
            this.cbb_Khoi = new System.Windows.Forms.ComboBox();
            this.cbb_DoKho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Chon
            // 
            this.btn_Chon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chon.Location = new System.Drawing.Point(140, 130);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(85, 40);
            this.btn_Chon.TabIndex = 17;
            this.btn_Chon.Text = "Chọn";
            this.btn_Chon.UseVisualStyleBackColor = true;
            // 
            // cbb_Khoi
            // 
            this.cbb_Khoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Khoi.FormattingEnabled = true;
            this.cbb_Khoi.Location = new System.Drawing.Point(115, 92);
            this.cbb_Khoi.Name = "cbb_Khoi";
            this.cbb_Khoi.Size = new System.Drawing.Size(216, 32);
            this.cbb_Khoi.TabIndex = 14;
            // 
            // cbb_DoKho
            // 
            this.cbb_DoKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_DoKho.FormattingEnabled = true;
            this.cbb_DoKho.Location = new System.Drawing.Point(115, 54);
            this.cbb_DoKho.Name = "cbb_DoKho";
            this.cbb_DoKho.Size = new System.Drawing.Size(216, 32);
            this.cbb_DoKho.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Khối";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(115, 13);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(216, 32);
            this.cbb_MonHoc.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Độ Khó:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Môn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChonDeOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 191);
            this.Controls.Add(this.btn_Chon);
            this.Controls.Add(this.cbb_Khoi);
            this.Controls.Add(this.cbb_DoKho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_MonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChonDeOn";
            this.Text = "frmChonDeOn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.ComboBox cbb_Khoi;
        private System.Windows.Forms.ComboBox cbb_DoKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}