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
    public partial class QuanLyDichVu : Form
    {
        private SqlConnection DSDVconnection;
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        public QuanLyDichVu()
        {
            InitializeComponent();
        }

        public void loadDataGridView()
        {
            command = DSDVconnection.CreateCommand();
            command.CommandText = "SELECT * FROM DanhSachDichVu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachDichVu.DataSource = table;
        }

        public void loadDataGridViewWithQuery(string query)
        {
            command = DSDVconnection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachDichVu.DataSource = table;
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVu = new ThemDichVu();
            themDichVu.ShowDialog();
        }

        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            DSDVconnection = new SqlConnection(ConstantVariable.connectionString);
            DSDVconnection.Open();
            loadDataGridView();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DanhSachDichVu where [Loại dịch vụ] = N'" + cb_LoaiDichVuTim.Text + "'";
            loadDataGridViewWithQuery(query);
        }

        private void QuanLyDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DSDVconnection.Close();
        }
    }
}
