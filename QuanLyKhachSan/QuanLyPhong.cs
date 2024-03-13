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
        private string connectionString = "Data Source=DESKTOP-E5D90BN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void btThemP_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
        }

        public void loadPhong()
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = "SELECT * FROM DANHSACHPHONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhong.DataSource = table;
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            DSPconnection = new SqlConnection(connectionString);
            DSPconnection.Open();
            loadPhong();
        }

        ~QuanLyPhong()
        {
            DSPconnection.Close();
        }
    }
}
