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
    public partial class SuDungDichVu : Form
    {
        private SqlConnection SDDVconnection;
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        public SuDungDichVu()
        {
            InitializeComponent();
        }

        public void loadDataGridView()
        {
            command = SDDVconnection.CreateCommand();
            command.CommandText = "SELECT * FROM DanhSachDichVu";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachDichVu.DataSource = table;
        }

        public void loadDataGridViewWithQuery(string query)
        {
            command = SDDVconnection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachDichVu.DataSource = table;
        }

        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            SDDVconnection = new SqlConnection(ConstantVariable.connectionString);
            SDDVconnection.Open();
            loadDataGridView();
        }

        private void cb_LoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DanhSachDichVu where [Loại dịch vụ] = N'" + cb_LoaiDichVu.Text + "'";
            loadDataGridViewWithQuery(query);
        }

        private void SuDungDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SDDVconnection.Close();
        }
    }
}
