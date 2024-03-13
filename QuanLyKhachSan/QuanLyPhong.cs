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
    public partial class QuanLyPhong : Form
    {
        private SqlConnection DSPconnection;
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void btThemP_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
        }

        public void loadDataGridView()
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = "SELECT * FROM DANHSACHPHONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhong.DataSource = table;
        }

        public void loadDataGridViewWithQuery(string query)
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhong.DataSource = table;
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            DSPconnection = new SqlConnection(ConstantVariable.connectionString);
            DSPconnection.Open();
            loadDataGridView();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DANHSACHPHONG WHERE [Tên Phòng] = N'" + tb_TenPhongTim.Text + "'";
            loadDataGridViewWithQuery(query);
        }

        private void QuanLyPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DSPconnection.Close();
        }
    }
}
