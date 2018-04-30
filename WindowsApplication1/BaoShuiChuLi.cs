using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kaipiao
{
    public partial class BaoShuiChuLi : Form
    {
        public BaoShuiChuLi()
        {
            InitializeComponent();
        }

        private void btn_sbhz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("上报成功");
        }
    }
}