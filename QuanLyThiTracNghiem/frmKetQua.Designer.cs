
namespace QuanLyThiTracNghiem
{
    partial class frmKetQua
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
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_KetQua.BackColor = System.Drawing.Color.Wheat;
            this.btn_KetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetQua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_KetQua.Location = new System.Drawing.Point(0, 109);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(339, 47);
            this.btn_KetQua.TabIndex = 3;
            this.btn_KetQua.Text = "Điểm: ";
            this.btn_KetQua.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết Quả Thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 203);
            this.Controls.Add(this.btn_KetQua);
            this.Controls.Add(this.label2);
            this.Name = "frmKetQua";
            this.Text = "frmKetQua";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.Label label2;
    }
}