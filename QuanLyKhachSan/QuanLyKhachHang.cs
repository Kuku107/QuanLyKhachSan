using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class QuanLyKhachHang : Form
    {
        private SqlConnection DSKHconnection;
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        void loadDataGridView()
        {
            command = DSKHconnection.CreateCommand();
            command.CommandText = "SELECT * from DANHSACHKHACHHANG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachKhachHang.DataSource = table;
        }

        void loadDataGridViewWithQuery(string query)
        {
            command = DSKHconnection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachKhachHang.DataSource = table;
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            ThemKhachHang themKhachHang = new ThemKhachHang();
            themKhachHang.ShowDialog();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            DSKHconnection = new SqlConnection(ConstantVariable.connectionString);
            DSKHconnection.Open();
            loadDataGridView();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from DANHSACHKHACHHANG WHERE [Họ và tên] = N'" + tb_HoVaTenTim.Text + "'";
            loadDataGridViewWithQuery(query);
        }

        private void QuanLyKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DSKHconnection.Close();
        }
    }
}
