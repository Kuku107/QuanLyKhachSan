﻿using System;
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
    public partial class QuanLyDichVu : Form
    {
        public QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVu = new ThemDichVu();
            themDichVu.ShowDialog();
        }
    }
}
