namespace QuanLyKhachSan
{
    partial class ThemPhong
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
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            nud_SoNguoiToiDa = new NumericUpDown();
            label7 = new Label();
            tb_GiaPhong = new TextBox();
            label6 = new Label();
            cb_LoaiPhong = new ComboBox();
            label5 = new Label();
            tb_TenPhong = new TextBox();
            label4 = new Label();
            tb_MaPhong = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            bt_ThemPhong = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_SoNguoiToiDa).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(13, 55);
            label2.MinimumSize = new Size(0, 1);
            label2.Name = "label2";
            label2.Size = new Size(790, 1);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 46);
            label1.TabIndex = 2;
            label1.Text = "Thêm Phòng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nud_SoNguoiToiDa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_GiaPhong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cb_LoaiPhong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tb_TenPhong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_MaPhong);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = Color.Green;
            groupBox1.Location = new Point(13, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 173);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // nud_SoNguoiToiDa
            // 
            nud_SoNguoiToiDa.Font = new Font("Segoe UI", 10F);
            nud_SoNguoiToiDa.Location = new Point(509, 104);
            nud_SoNguoiToiDa.Name = "nud_SoNguoiToiDa";
            nud_SoNguoiToiDa.Size = new Size(182, 30);
            nud_SoNguoiToiDa.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(509, 75);
            label7.Name = "label7";
            label7.Size = new Size(131, 23);
            label7.TabIndex = 14;
            label7.Text = "Số người tối đa:";
            // 
            // tb_GiaPhong
            // 
            tb_GiaPhong.Font = new Font("Segoe UI", 10F);
            tb_GiaPhong.Location = new Point(274, 130);
            tb_GiaPhong.Name = "tb_GiaPhong";
            tb_GiaPhong.Size = new Size(188, 30);
            tb_GiaPhong.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(275, 104);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 12;
            label6.Text = "Giá phòng:";
            // 
            // cb_LoaiPhong
            // 
            cb_LoaiPhong.Font = new Font("Segoe UI", 10F);
            cb_LoaiPhong.FormattingEnabled = true;
            cb_LoaiPhong.Location = new Point(274, 56);
            cb_LoaiPhong.Name = "cb_LoaiPhong";
            cb_LoaiPhong.Size = new Size(188, 31);
            cb_LoaiPhong.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(274, 30);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 10;
            label5.Text = "Loại Phòng:";
            // 
            // tb_TenPhong
            // 
            tb_TenPhong.Font = new Font("Segoe UI", 10F);
            tb_TenPhong.Location = new Point(5, 130);
            tb_TenPhong.Name = "tb_TenPhong";
            tb_TenPhong.Size = new Size(188, 30);
            tb_TenPhong.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(6, 104);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 8;
            label4.Text = "Tên Phòng:";
            // 
            // tb_MaPhong
            // 
            tb_MaPhong.Font = new Font("Segoe UI", 10F);
            tb_MaPhong.Location = new Point(5, 56);
            tb_MaPhong.Name = "tb_MaPhong";
            tb_MaPhong.ReadOnly = true;
            tb_MaPhong.Size = new Size(188, 30);
            tb_MaPhong.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 6;
            label3.Text = "Mã Phòng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_ThemPhong);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.Green;
            groupBox2.Location = new Point(13, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 124);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bt_ThemPhong
            // 
            bt_ThemPhong.Location = new Point(174, 48);
            bt_ThemPhong.Name = "bt_ThemPhong";
            bt_ThemPhong.Size = new Size(345, 50);
            bt_ThemPhong.TabIndex = 0;
            bt_ThemPhong.Text = "Thêm phòng";
            bt_ThemPhong.UseVisualStyleBackColor = true;
            // 
            // ThemPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 403);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ThemPhong";
            StartPosition = FormStartPosition.CenterParent;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_SoNguoiToiDa).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_MaPhong;
        private Label label3;
        private TextBox tb_TenPhong;
        private Label label4;
        private TextBox tb_GiaPhong;
        private Label label6;
        private ComboBox cb_LoaiPhong;
        private Label label5;
        private Label label7;
        private GroupBox groupBox2;
        private Button bt_ThemPhong;
        private NumericUpDown nud_SoNguoiToiDa;
    }
}