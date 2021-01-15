namespace QuanLyThiTracNghiem
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpQuanLyHocSinh = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinhHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoanHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhauHashHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinhHS = new System.Windows.Forms.DateTimePicker();
            this.btnSuaHS = new System.Windows.Forms.Button();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.btnThemHS = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMatKhauHS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoanHS = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChiHS = new System.Windows.Forms.TextBox();
            this.txtHoTenHS = new System.Windows.Forms.TextBox();
            this.tpQuanLyGiaoVien = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhauHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.tpKetQuaThi = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachGiaoVienMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachHocSinhMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KetQuaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maHSValidator1 = new QuanLyThiTracNghiem.Validate.MaHSValidator();
            this.maGVValidator1 = new QuanLyThiTracNghiem.Validate.MaGVValidator();
            this.tenTaiKhoanValidator1 = new QuanLyThiTracNghiem.Validate.TenTaiKhoanValidator();
            this.tenTaiKhoanValidator2 = new QuanLyThiTracNghiem.Validate.TenTaiKhoanValidator();
            this.requiredValidator1 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator2 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator3 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator4 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator5 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator6 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator7 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator8 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator9 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator10 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.requiredValidator11 = new QuanLyThiTracNghiem.Validate.RequiredValidator();
            this.groupBox1.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.tpQuanLyHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tpQuanLyGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tcAdmin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1280, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpQuanLyHocSinh);
            this.tcAdmin.Controls.Add(this.tpQuanLyGiaoVien);
            this.tcAdmin.Controls.Add(this.tpKetQuaThi);
            this.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcAdmin.Location = new System.Drawing.Point(2, 15);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1276, 561);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpQuanLyHocSinh
            // 
            this.tpQuanLyHocSinh.BackColor = System.Drawing.Color.White;
            this.tpQuanLyHocSinh.Controls.Add(this.splitContainer1);
            this.tpQuanLyHocSinh.Location = new System.Drawing.Point(4, 27);
            this.tpQuanLyHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.tpQuanLyHocSinh.Name = "tpQuanLyHocSinh";
            this.tpQuanLyHocSinh.Padding = new System.Windows.Forms.Padding(2);
            this.tpQuanLyHocSinh.Size = new System.Drawing.Size(1268, 530);
            this.tpQuanLyHocSinh.TabIndex = 0;
            this.tpQuanLyHocSinh.Tag = "QuanLyHocSinh";
            this.tpQuanLyHocSinh.Text = "Quản Lý Học Sinh";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 526);
            this.splitContainer1.SplitterDistance = 903;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(903, 526);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 24);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Học Sinh :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHocSinh);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(903, 482);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToOrderColumns = true;
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTenHS,
            this.Lop,
            this.NgaySinhHS,
            this.DiaChiHS,
            this.TenTaiKhoanHS,
            this.MatKhauHashHS});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 20);
            this.dgvHocSinh.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersVisible = false;
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(897, 459);
            this.dgvHocSinh.TabIndex = 3;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HoTenHS
            // 
            this.HoTenHS.DataPropertyName = "HoTen";
            this.HoTenHS.HeaderText = "Họ tên";
            this.HoTenHS.Name = "HoTenHS";
            this.HoTenHS.ReadOnly = true;
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // NgaySinhHS
            // 
            this.NgaySinhHS.DataPropertyName = "NgaySinh";
            this.NgaySinhHS.HeaderText = "Ngày sinh";
            this.NgaySinhHS.Name = "NgaySinhHS";
            this.NgaySinhHS.ReadOnly = true;
            // 
            // DiaChiHS
            // 
            this.DiaChiHS.DataPropertyName = "DiaChi";
            this.DiaChiHS.HeaderText = "Địa chỉ";
            this.DiaChiHS.Name = "DiaChiHS";
            this.DiaChiHS.ReadOnly = true;
            // 
            // TenTaiKhoanHS
            // 
            this.TenTaiKhoanHS.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoanHS.HeaderText = "Tên tài khoản";
            this.TenTaiKhoanHS.Name = "TenTaiKhoanHS";
            this.TenTaiKhoanHS.ReadOnly = true;
            // 
            // MatKhauHashHS
            // 
            this.MatKhauHashHS.DataPropertyName = "MatKhauHash";
            this.MatKhauHashHS.HeaderText = "Mật khẩu";
            this.MatKhauHashHS.Name = "MatKhauHashHS";
            this.MatKhauHashHS.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgaySinhHS);
            this.groupBox2.Controls.Add(this.btnSuaHS);
            this.groupBox2.Controls.Add(this.btnXoaHS);
            this.groupBox2.Controls.Add(this.btnThemHS);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtMatKhauHS);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtTenTaiKhoanHS);
            this.groupBox2.Controls.Add(this.txtMaHS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLop);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiaChiHS);
            this.groupBox2.Controls.Add(this.txtHoTenHS);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 526);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // dtpNgaySinhHS
            // 
            this.dtpNgaySinhHS.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhHS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhHS.Location = new System.Drawing.Point(123, 146);
            this.dtpNgaySinhHS.Name = "dtpNgaySinhHS";
            this.dtpNgaySinhHS.Size = new System.Drawing.Size(200, 24);
            this.dtpNgaySinhHS.TabIndex = 68;
            // 
            // btnSuaHS
            // 
            this.btnSuaHS.Location = new System.Drawing.Point(142, 266);
            this.btnSuaHS.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaHS.Name = "btnSuaHS";
            this.btnSuaHS.Size = new System.Drawing.Size(58, 46);
            this.btnSuaHS.TabIndex = 67;
            this.btnSuaHS.Text = "Sửa";
            this.btnSuaHS.UseVisualStyleBackColor = true;
            this.btnSuaHS.Click += new System.EventHandler(this.btnSuaHS_Click);
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.Location = new System.Drawing.Point(229, 266);
            this.btnXoaHS.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(58, 46);
            this.btnXoaHS.TabIndex = 66;
            this.btnXoaHS.Text = "Xóa ";
            this.btnXoaHS.UseVisualStyleBackColor = true;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // btnThemHS
            // 
            this.btnThemHS.Location = new System.Drawing.Point(50, 266);
            this.btnThemHS.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHS.Name = "btnThemHS";
            this.btnThemHS.Size = new System.Drawing.Size(58, 46);
            this.btnThemHS.TabIndex = 65;
            this.btnThemHS.Text = "Thêm ";
            this.btnThemHS.UseVisualStyleBackColor = true;
            this.btnThemHS.Click += new System.EventHandler(this.btnThemHS_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 213);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 63;
            this.label14.Text = "Mật khẩu :";
            // 
            // txtMatKhauHS
            // 
            this.txtMatKhauHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauHS.Location = new System.Drawing.Point(122, 210);
            this.txtMatKhauHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauHS.Name = "txtMatKhauHS";
            this.txtMatKhauHS.PasswordChar = '*';
            this.txtMatKhauHS.Size = new System.Drawing.Size(202, 24);
            this.txtMatKhauHS.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 180);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 18);
            this.label15.TabIndex = 61;
            this.label15.Text = "Tên tài khoản :";
            // 
            // txtTenTaiKhoanHS
            // 
            this.txtTenTaiKhoanHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoanHS.Location = new System.Drawing.Point(122, 177);
            this.txtTenTaiKhoanHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTaiKhoanHS.Name = "txtTenTaiKhoanHS";
            this.txtTenTaiKhoanHS.Size = new System.Drawing.Size(202, 24);
            this.txtTenTaiKhoanHS.TabIndex = 62;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.Location = new System.Drawing.Point(122, 22);
            this.txtMaHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(202, 24);
            this.txtMaHS.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã HS :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ tên : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lớp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ : ";
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(122, 83);
            this.txtLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(202, 24);
            this.txtLop.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày Sinh :";
            // 
            // txtDiaChiHS
            // 
            this.txtDiaChiHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiHS.Location = new System.Drawing.Point(122, 115);
            this.txtDiaChiHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChiHS.Name = "txtDiaChiHS";
            this.txtDiaChiHS.Size = new System.Drawing.Size(202, 24);
            this.txtDiaChiHS.TabIndex = 12;
            // 
            // txtHoTenHS
            // 
            this.txtHoTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenHS.Location = new System.Drawing.Point(122, 53);
            this.txtHoTenHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTenHS.Name = "txtHoTenHS";
            this.txtHoTenHS.Size = new System.Drawing.Size(202, 24);
            this.txtHoTenHS.TabIndex = 10;
            // 
            // tpQuanLyGiaoVien
            // 
            this.tpQuanLyGiaoVien.BackColor = System.Drawing.Color.White;
            this.tpQuanLyGiaoVien.Controls.Add(this.splitContainer3);
            this.tpQuanLyGiaoVien.Location = new System.Drawing.Point(4, 27);
            this.tpQuanLyGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.tpQuanLyGiaoVien.Name = "tpQuanLyGiaoVien";
            this.tpQuanLyGiaoVien.Padding = new System.Windows.Forms.Padding(2);
            this.tpQuanLyGiaoVien.Size = new System.Drawing.Size(1268, 530);
            this.tpQuanLyGiaoVien.TabIndex = 1;
            this.tpQuanLyGiaoVien.Tag = "QuanLyGiaoVien";
            this.tpQuanLyGiaoVien.Text = "Quản Lý Giáo Viên";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(2, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Size = new System.Drawing.Size(1264, 526);
            this.splitContainer3.SplitterDistance = 905;
            this.splitContainer3.TabIndex = 18;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.textBox7);
            this.splitContainer4.Panel1.Controls.Add(this.label7);
            this.splitContainer4.Panel1.Controls.Add(this.button5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer4.Size = new System.Drawing.Size(905, 526);
            this.splitContainer4.SplitterDistance = 41;
            this.splitContainer4.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(137, 8);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 24);
            this.textBox7.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tìm Giáo Viên :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(498, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 25);
            this.button5.TabIndex = 1;
            this.button5.Text = "Tìm Kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvGiaoVien);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(905, 481);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi,
            this.TenTaiKhoan,
            this.MatKhauHash});
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 20);
            this.dgvGiaoVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersVisible = false;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(899, 458);
            this.dgvGiaoVien.TabIndex = 3;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã giáo viên";
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhauHash
            // 
            this.MatKhauHash.DataPropertyName = "MatKhauHash";
            this.MatKhauHash.HeaderText = "Mật khẩu";
            this.MatKhauHash.Name = "MatKhauHash";
            this.MatKhauHash.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtMatKhau);
            this.groupBox5.Controls.Add(this.dtpNgaySinh);
            this.groupBox5.Controls.Add(this.txtMaGV);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnSuaGV);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnXoaGV);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.btnThemGV);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtDiaChi);
            this.groupBox5.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox5.Controls.Add(this.txtHoTen);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 526);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mật khẩu :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(118, 189);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(198, 24);
            this.txtMatKhau.TabIndex = 20;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(118, 91);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(198, 24);
            this.dtpNgaySinh.TabIndex = 18;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(118, 31);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(198, 24);
            this.txtMaGV.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mã GV :";
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Location = new System.Drawing.Point(142, 247);
            this.btnSuaGV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(58, 46);
            this.btnSuaGV.TabIndex = 16;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Họ tên :";
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(229, 247);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(58, 46);
            this.btnXoaGV.TabIndex = 15;
            this.btnXoaGV.Text = "Xóa ";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ngày Sinh :";
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(50, 247);
            this.btnThemGV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(58, 46);
            this.btnThemGV.TabIndex = 14;
            this.btnThemGV.Text = "Thêm ";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "Địa chỉ :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "Tên tài khoản :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(118, 124);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(198, 24);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(118, 156);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(198, 24);
            this.txtTenTaiKhoan.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(118, 62);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(198, 24);
            this.txtHoTen.TabIndex = 10;
            // 
            // tpKetQuaThi
            // 
            this.tpKetQuaThi.Location = new System.Drawing.Point(4, 27);
            this.tpKetQuaThi.Margin = new System.Windows.Forms.Padding(2);
            this.tpKetQuaThi.Name = "tpKetQuaThi";
            this.tpKetQuaThi.Padding = new System.Windows.Forms.Padding(2);
            this.tpKetQuaThi.Size = new System.Drawing.Size(1268, 530);
            this.tpKetQuaThi.TabIndex = 2;
            this.tpKetQuaThi.Tag = "KetQuaThi";
            this.tpKetQuaThi.Text = "Kết Quả Thi";
            this.tpKetQuaThi.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.dữLiệuToolStripMenuItem,
            this.quảnLýDToolStripMenuItem,
            this.KetQuaMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoiMatKhauMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // DoiMatKhauMenuItem
            // 
            this.DoiMatKhauMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DoiMatKhauMenuItem.Name = "DoiMatKhauMenuItem";
            this.DoiMatKhauMenuItem.Size = new System.Drawing.Size(167, 24);
            this.DoiMatKhauMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.phụcHồiToolStripMenuItem,
            this.ImportMenuItem,
            this.ExportMenuItem});
            this.dữLiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.dữLiệuToolStripMenuItem.Text = "Dữ liệu";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.phụcHồiToolStripMenuItem.Text = "Phục hồi";
            // 
            // ImportMenuItem
            // 
            this.ImportMenuItem.Name = "ImportMenuItem";
            this.ImportMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ImportMenuItem.Text = "Import danh sách";
            this.ImportMenuItem.Click += new System.EventHandler(this.ImportMenuItem_Click);
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.Name = "ExportMenuItem";
            this.ExportMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ExportMenuItem.Text = "Export danh sách";
            this.ExportMenuItem.Click += new System.EventHandler(this.ExportMenuItem_Click);
            // 
            // quảnLýDToolStripMenuItem
            // 
            this.quảnLýDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSachGiaoVienMenuItem,
            this.DanhSachHocSinhMenuItem});
            this.quảnLýDToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.quảnLýDToolStripMenuItem.Name = "quảnLýDToolStripMenuItem";
            this.quảnLýDToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quảnLýDToolStripMenuItem.Text = "Quản lý người dùng";
            // 
            // DanhSachGiaoVienMenuItem
            // 
            this.DanhSachGiaoVienMenuItem.Name = "DanhSachGiaoVienMenuItem";
            this.DanhSachGiaoVienMenuItem.Size = new System.Drawing.Size(211, 24);
            this.DanhSachGiaoVienMenuItem.Text = "Danh sách giáo viên";
            this.DanhSachGiaoVienMenuItem.Click += new System.EventHandler(this.DanhSachGiaoVienMenuItem_Click);
            // 
            // DanhSachHocSinhMenuItem
            // 
            this.DanhSachHocSinhMenuItem.Name = "DanhSachHocSinhMenuItem";
            this.DanhSachHocSinhMenuItem.Size = new System.Drawing.Size(211, 24);
            this.DanhSachHocSinhMenuItem.Text = "Danh sách học sinh";
            this.DanhSachHocSinhMenuItem.Click += new System.EventHandler(this.DanhSachHocSinhMenuItem_Click);
            // 
            // KetQuaMenuItem
            // 
            this.KetQuaMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.KetQuaMenuItem.Name = "KetQuaMenuItem";
            this.KetQuaMenuItem.Size = new System.Drawing.Size(72, 24);
            this.KetQuaMenuItem.Text = "Kết quả";
            this.KetQuaMenuItem.Click += new System.EventHandler(this.KetQuaMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // maHSValidator1
            // 
            this.maHSValidator1.ControlToValidate = this.txtMaHS;
            this.maHSValidator1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("maHSValidator1.ErrorIcon")));
            this.maHSValidator1.ErrorMessage = "Mã học sinh đã tồn tại";
            // 
            // maGVValidator1
            // 
            this.maGVValidator1.ControlToValidate = this.txtMaGV;
            this.maGVValidator1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("maGVValidator1.ErrorIcon")));
            this.maGVValidator1.ErrorMessage = "Mã giáo viên đã tồn tại";
            // 
            // tenTaiKhoanValidator1
            // 
            this.tenTaiKhoanValidator1.ControlToValidate = this.txtTenTaiKhoanHS;
            this.tenTaiKhoanValidator1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("tenTaiKhoanValidator1.ErrorIcon")));
            this.tenTaiKhoanValidator1.ErrorMessage = "Tên tài khoản đã tồn tại";
            // 
            // tenTaiKhoanValidator2
            // 
            this.tenTaiKhoanValidator2.ControlToValidate = this.txtTenTaiKhoan;
            this.tenTaiKhoanValidator2.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("tenTaiKhoanValidator2.ErrorIcon")));
            this.tenTaiKhoanValidator2.ErrorMessage = "Tên tài khoản đã tồn tại";
            // 
            // requiredValidator1
            // 
            this.requiredValidator1.ControlToValidate = this.txtMaHS;
            this.requiredValidator1.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator1.ErrorIcon")));
            this.requiredValidator1.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator2
            // 
            this.requiredValidator2.ControlToValidate = this.txtHoTenHS;
            this.requiredValidator2.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator2.ErrorIcon")));
            this.requiredValidator2.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator3
            // 
            this.requiredValidator3.ControlToValidate = this.txtLop;
            this.requiredValidator3.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator3.ErrorIcon")));
            this.requiredValidator3.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator4
            // 
            this.requiredValidator4.ControlToValidate = this.txtDiaChiHS;
            this.requiredValidator4.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator4.ErrorIcon")));
            this.requiredValidator4.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator5
            // 
            this.requiredValidator5.ControlToValidate = this.txtTenTaiKhoanHS;
            this.requiredValidator5.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator5.ErrorIcon")));
            this.requiredValidator5.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator6
            // 
            this.requiredValidator6.ControlToValidate = this.txtMatKhauHS;
            this.requiredValidator6.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator6.ErrorIcon")));
            this.requiredValidator6.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator7
            // 
            this.requiredValidator7.ControlToValidate = this.txtMaGV;
            this.requiredValidator7.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator7.ErrorIcon")));
            this.requiredValidator7.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator8
            // 
            this.requiredValidator8.ControlToValidate = this.txtHoTen;
            this.requiredValidator8.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator8.ErrorIcon")));
            this.requiredValidator8.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator9
            // 
            this.requiredValidator9.ControlToValidate = this.txtDiaChi;
            this.requiredValidator9.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator9.ErrorIcon")));
            this.requiredValidator9.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator10
            // 
            this.requiredValidator10.ControlToValidate = this.txtTenTaiKhoan;
            this.requiredValidator10.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator10.ErrorIcon")));
            this.requiredValidator10.ErrorMessage = "Không được để rỗng";
            // 
            // requiredValidator11
            // 
            this.requiredValidator11.ControlToValidate = this.txtMatKhau;
            this.requiredValidator11.ErrorIcon = ((System.Drawing.Icon)(resources.GetObject("requiredValidator11.ErrorIcon")));
            this.requiredValidator11.ErrorMessage = "Không được để rỗng";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.tcAdmin.ResumeLayout(false);
            this.tpQuanLyHocSinh.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpQuanLyGiaoVien.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpQuanLyHocSinh;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpQuanLyGiaoVien;
        private System.Windows.Forms.TabPage tpKetQuaThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtDiaChiHS;
        private System.Windows.Forms.TextBox txtHoTenHS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhSachGiaoVienMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DanhSachHocSinhMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KetQuaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhauHash;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMatKhauHS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTenTaiKhoanHS;
        private System.Windows.Forms.Button btnSuaHS;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.Button btnThemHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinhHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoanHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhauHashHS;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhHS;
        private Validate.MaHSValidator maHSValidator1;
        private Validate.MaGVValidator maGVValidator1;
        private Validate.TenTaiKhoanValidator tenTaiKhoanValidator1;
        private Validate.TenTaiKhoanValidator tenTaiKhoanValidator2;
        private Validate.RequiredValidator requiredValidator1;
        private Validate.RequiredValidator requiredValidator2;
        private Validate.RequiredValidator requiredValidator3;
        private Validate.RequiredValidator requiredValidator4;
        private Validate.RequiredValidator requiredValidator5;
        private Validate.RequiredValidator requiredValidator6;
        private Validate.RequiredValidator requiredValidator7;
        private Validate.RequiredValidator requiredValidator8;
        private Validate.RequiredValidator requiredValidator9;
        private Validate.RequiredValidator requiredValidator10;
        private Validate.RequiredValidator requiredValidator11;
    }
}