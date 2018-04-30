using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Kaipiao;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public static StreamWriter wr = new StreamWriter(@"C:\Documents and Settings\Administrator\×ÀÃæ\" + "data.txt");

        private void button1_Click(object sender, EventArgs e)
        {
            btn_kaipiao.Visible = true;
        }

        private void btn_kaipiao_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void _btn_bscl_Click(object sender, EventArgs e)
        {
            BaoShuiChuLi f = new BaoShuiChuLi();
            f.Show();
        }
    }
}