using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class DichVuVaThanhToan : Form
    {
        public DichVuVaThanhToan()
        {
            InitializeComponent();
        }

        private void bt_DichVu_Click(object sender, EventArgs e)
        {
            SuDungDichVu suDungDichVu = new SuDungDichVu();
            suDungDichVu.ShowDialog();
        }
    }
}
