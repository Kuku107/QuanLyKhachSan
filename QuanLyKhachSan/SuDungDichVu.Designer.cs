namespace QuanLyKhachSan
{
    partial class SuDungDichVu
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
            label1 = new Label();
            tb_MaPhong = new TextBox();
            dgv_DanhSachDichVu = new DataGridView();
            label2 = new Label();
            nud_SoLuong = new NumericUpDown();
            bt_SuDung = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_SoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng";
            // 
            // tb_MaPhong
            // 
            tb_MaPhong.Font = new Font("Segoe UI", 10F);
            tb_MaPhong.Location = new Point(127, 9);
            tb_MaPhong.Name = "tb_MaPhong";
            tb_MaPhong.ReadOnly = true;
            tb_MaPhong.Size = new Size(157, 30);
            tb_MaPhong.TabIndex = 1;
            // 
            // dgv_DanhSachDichVu
            // 
            dgv_DanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachDichVu.Location = new Point(12, 45);
            dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            dgv_DanhSachDichVu.RowHeadersWidth = 51;
            dgv_DanhSachDichVu.Size = new Size(661, 346);
            dgv_DanhSachDichVu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(394, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 3;
            label2.Text = "Số lượng";
            // 
            // nud_SoLuong
            // 
            nud_SoLuong.Location = new Point(501, 9);
            nud_SoLuong.Name = "nud_SoLuong";
            nud_SoLuong.Size = new Size(172, 27);
            nud_SoLuong.TabIndex = 4;
            // 
            // bt_SuDung
            // 
            bt_SuDung.Font = new Font("Segoe UI", 12F);
            bt_SuDung.ForeColor = Color.Green;
            bt_SuDung.Location = new Point(679, 66);
            bt_SuDung.Name = "bt_SuDung";
            bt_SuDung.Size = new Size(111, 294);
            bt_SuDung.TabIndex = 5;
            bt_SuDung.Text = "Sử dụng";
            bt_SuDung.UseVisualStyleBackColor = true;
            // 
            // SuDungDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 403);
            Controls.Add(bt_SuDung);
            Controls.Add(nud_SoLuong);
            Controls.Add(label2);
            Controls.Add(dgv_DanhSachDichVu);
            Controls.Add(tb_MaPhong);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SuDungDichVu";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_SoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_MaPhong;
        private DataGridView dgv_DanhSachDichVu;
        private Label label2;
        private NumericUpDown nud_SoLuong;
        private Button bt_SuDung;
    }
}