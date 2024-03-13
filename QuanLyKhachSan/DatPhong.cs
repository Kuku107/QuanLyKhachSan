using System.Data;
using System.Data.SqlClient;
using System.Drawing;
namespace QuanLyKhachSan
{
    public partial class DatPhong : Form
    {
        SqlConnection DSPconnection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public DatPhong()
        {
            InitializeComponent();
        }

        public void loadDataGridView()
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = "SELECT * from DANHSACHPHONG where [Trạng thái] = N'Trống'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhongTrong.DataSource = table;
        }

        public void loadDataGridViewWithQuery(string query)
        {
            command = DSPconnection.CreateCommand();
            command.CommandText = query;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_DanhSachPhongTrong.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DSPconnection = new SqlConnection(ConstantVariable.connectionString);
            DSPconnection.Open();
            loadDataGridView();
        }

        private void bt_DatPhong_Click(object sender, EventArgs e)
        {

        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from DANHSACHPHONG where [Trạng thái] = N'Trống' and [Loại phòng] = N'" + cb_LoaiPhong.Text
                            + "' and [Số người tối đa] >= " + nup_SoNguoiToiDa.Value + "";
            loadDataGridViewWithQuery(query);
        }

        private void DatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DSPconnection.Close();
        }
    }
}
