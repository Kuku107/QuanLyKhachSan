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
    public partial class DichVuVaThanhToan : Form
    {
        private SqlConnection DSPconnection;
        private SqlCommand command;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        public DichVuVaThanhToan()
        {
            InitializeComponent();
        }

        public void loadDataGridView()
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = "SELECT * FROM DanhSAchPhong where [Trạng thái] = N'Kín'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhongKin.DataSource = table;
        }

        public void loadDataGridViewWithQuery(string query)
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhongKin.DataSource = table;
        }

        private void bt_DichVu_Click(object sender, EventArgs e)
        {
            SuDungDichVu suDungDichVu = new SuDungDichVu();
            suDungDichVu.ShowDialog();
        }

        private void DichVuVaThanhToan_Load(object sender, EventArgs e)
        {
            DSPconnection = new SqlConnection(ConstantVariable.connectionString);
            DSPconnection.Open();
            loadDataGridView();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DanhSachPhong WHERE [Trạng thái] = N'Kín' AND [Tên phòng] = N'" + tb_TenPhong.Text
                            + "' AND [Loại phòng] = N'" + cb_LoaiPhong.Text + "'";
            loadDataGridViewWithQuery(query);
        }

        private void DichVuVaThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DSPconnection.Close();
        }
    }
}
