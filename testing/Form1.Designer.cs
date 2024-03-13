namespace testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            uốngNướcToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbMaSV = new TextBox();
            tbHoTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            cbQueQuan = new ComboBox();
            cbLop = new ComboBox();
            cbKhoa = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btThem = new Button();
            btSua = new Button();
            btXoa = new Button();
            dgvSV = new DataGridView();
            btTimKiem = new Button();
            tbTimKiem = new TextBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ContextMenuStrip = contextMenuStrip1;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { uốngNướcToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // uốngNướcToolStripMenuItem
            // 
            uốngNướcToolStripMenuItem.Name = "uốngNướcToolStripMenuItem";
            uốngNướcToolStripMenuItem.Size = new Size(210, 24);
            uốngNướcToolStripMenuItem.Text = "Uống nước";
            uốngNướcToolStripMenuItem.Click += uốngNướcToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới tính";
            // 
            // tbMaSV
            // 
            tbMaSV.Location = new Point(94, 2);
            tbMaSV.Name = "tbMaSV";
            tbMaSV.Size = new Size(157, 27);
            tbMaSV.TabIndex = 4;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(94, 45);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(157, 27);
            tbHoTen.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(94, 79);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(157, 27);
            dtpNgaySinh.TabIndex = 6;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(94, 122);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 7;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(201, 122);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 8;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // cbQueQuan
            // 
            cbQueQuan.FormattingEnabled = true;
            cbQueQuan.Items.AddRange(new object[] { "VP", "HN" });
            cbQueQuan.Location = new Point(502, 6);
            cbQueQuan.Name = "cbQueQuan";
            cbQueQuan.Size = new Size(151, 28);
            cbQueQuan.TabIndex = 9;
            // 
            // cbLop
            // 
            cbLop.FormattingEnabled = true;
            cbLop.Items.AddRange(new object[] { "vc", "gg" });
            cbLop.Location = new Point(502, 45);
            cbLop.Name = "cbLop";
            cbLop.Size = new Size(151, 28);
            cbLop.TabIndex = 9;
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "dsaf", "fdsa" });
            cbKhoa.Location = new Point(502, 81);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(151, 28);
            cbKhoa.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 9);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "Quê quán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 48);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 10;
            label6.Text = "Lớp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 84);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 10;
            label7.Text = "Khoa";
            // 
            // btThem
            // 
            btThem.BackColor = Color.Green;
            btThem.FlatStyle = FlatStyle.Flat;
            btThem.ForeColor = Color.White;
            btThem.Location = new Point(399, 118);
            btThem.Name = "btThem";
            btThem.Size = new Size(104, 28);
            btThem.TabIndex = 11;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = false;
            btThem.Click += btThem_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(529, 118);
            btSua.Name = "btSua";
            btSua.Size = new Size(104, 28);
            btSua.TabIndex = 13;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(658, 120);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(104, 28);
            btXoa.TabIndex = 14;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // dgvSV
            // 
            dgvSV.AllowUserToResizeColumns = false;
            dgvSV.AllowUserToResizeRows = false;
            dgvSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSV.BackgroundColor = Color.White;
            dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSV.ContextMenuStrip = contextMenuStrip1;
            dgvSV.Location = new Point(12, 154);
            dgvSV.Name = "dgvSV";
            dgvSV.ReadOnly = true;
            dgvSV.RowHeadersVisible = false;
            dgvSV.RowHeadersWidth = 51;
            dgvSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSV.Size = new Size(1120, 479);
            dgvSV.TabIndex = 12;
            dgvSV.CellClick += dgvSV_CellClick;
            // 
            // btTimKiem
            // 
            btTimKiem.Location = new Point(1013, 111);
            btTimKiem.Name = "btTimKiem";
            btTimKiem.Size = new Size(94, 29);
            btTimKiem.TabIndex = 15;
            btTimKiem.Text = "Tìm kiếm";
            btTimKiem.UseVisualStyleBackColor = true;
            btTimKiem.Click += btTimKiem_Click;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(859, 113);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(125, 27);
            tbTimKiem.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 645);
            Controls.Add(tbTimKiem);
            Controls.Add(btTimKiem);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(dgvSV);
            Controls.Add(btThem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbKhoa);
            Controls.Add(cbLop);
            Controls.Add(cbQueQuan);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(tbHoTen);
            Controls.Add(tbMaSV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMaSV;
        private TextBox tbHoTen;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private ComboBox cbQueQuan;
        private ComboBox cbLop;
        private ComboBox cbKhoa;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btThem;
        private Button btSua;
        private Button btXoa;
        private DataGridView dgvSV;
        private Button btTimKiem;
        private TextBox tbTimKiem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem uốngNướcToolStripMenuItem;
    }
}
