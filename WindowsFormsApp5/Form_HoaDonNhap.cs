﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form_HoaDonNhap : Form
    {
        public Form_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void Form_HoaDonNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.HoaDonNhap' table. You can move, or remove it, as needed.
            this.hoaDonNhapTableAdapter.Fill(this.quanLyBanHangDataSet.HoaDonNhap);

        }
    }
}
