using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace testing
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string connectionString = @"Data Source=DESKTOP-E5D90BN;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void loadTable()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DanhSachSinhVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvSV.DataSource = table;
        }

        public void loadTableWithQuery(string query)
        {
            command = connection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvSV.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            loadTable();

        }
        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            tbMaSV.Text = dgvSV.Rows[i].Cells[0].Value.ToString();
            tbHoTen.Text = dgvSV.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvSV.Rows[i].Cells[2].Value.ToString());
            if (dgvSV.Rows[i].Cells[3].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            cbQueQuan.Text = dgvSV.Rows[i].Cells[4].Value.ToString();
            cbLop.Text = dgvSV.Rows[i].Cells[5].Value.ToString();
            cbKhoa.Text = dgvSV.Rows[i].Cells[6].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into DanhSachSinhVien values('" + tbMaSV.Text + "', N'" + tbHoTen.Text + "', '" + dtpNgaySinh.Value + "', N'" + (rbNam.Checked ? "Nam" : "Nữ") + "', N'" + cbQueQuan.Text + "', N'" + cbLop.Text + "', N'" + cbKhoa.Text + "')";
            command.ExecuteNonQuery();
            loadTable();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText =
                "update DanhSachSinhVien set HoTen = N'" + tbHoTen.Text + "', NgaySinh = '" + dtpNgaySinh.Value + "', GioiTinh = N'" + (rbNam.Checked ? "Nam" : "Nữ") + "', QueQuan = N'" + cbQueQuan.Text + "', Lop = N'" + cbLop.Text + "', Khoa = N'" + cbKhoa.Text + "' where MaSV = '" + tbMaSV.Text + "'";
            command.ExecuteNonQuery();
            loadTable();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from DanhSachSinhVien where MaSV = '" + tbMaSV.Text + "'";
            command.ExecuteNonQuery();
            loadTable();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string query = "select * from DanhSachSinhVien where queQuan = N'" + tbTimKiem.Text + "'";
            loadTableWithQuery(query);
        }

        private void uốngNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("M muốn uống nước", "Uống nước ư", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
