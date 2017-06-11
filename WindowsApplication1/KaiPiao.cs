using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;


namespace WindowsApplication1
{
    public partial class KaiPiao : Form
    {
        public KaiPiao()
        {
            InitializeComponent();
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            p_x = 0;
            p_y = 0;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            List1[0, 0].Value = "abb";
        }

        public static bool succ = false;

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            PrintForm form = new PrintForm(this);
            form.ShowDialog();
            
            if (succ)
            {
                succ = false;
                string temp = _txt_fapiaoNum.Text + "@" + _txt_name.Text + "@" + _txt_shibie.Text + "@";

                try
                {
                    List1.CurrentCell = List1[0, 0];
                    string a = List1[5, 0].Value.ToString() + "@";
                    string b = List1[7, 0].Value.ToString() + "@";
                    //Form1.wr.WriteLine(temp + a + b);
                }
                catch
                {
                    MessageBox.Show("金额或税额格式不正确，请重新输入");
                }
            }        
        }

        private void List1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (List1[5, 0].Value != null)
            {
                label18.Text = List1[5, 0].Value.ToString();
            }
            if (List1[7, 0].Value != null)
            {
                label20.Text = List1[7, 0].Value.ToString();
            }
            if (!string.IsNullOrEmpty(label18.Text) && !string.IsNullOrEmpty(label20.Text))
            {
                try
                {
                    double a = double.Parse(label18.Text) + double.Parse(label20.Text);
                    label21.Text = a.ToString();
                }
                catch
                {
                    MessageBox.Show("金额或税额格式不正确，请重新输入");
                }
            }
        }

        private PrintDocument printDocument1 = new PrintDocument();

        int p_x, p_y;
        public void Print(int x,int y)
        {
            p_x = x;
            p_y = y;
            this.printDocument1.Print();//直接打印
        }
        //打印内容的设置
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //打印内容 为 局部的 this.groupBox9
            Bitmap _NewBitmap = new Bitmap(groupBox9.Width, groupBox9.Height);
            groupBox9.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            e.Graphics.DrawImage(_NewBitmap, p_x, p_y, _NewBitmap.Width, _NewBitmap.Height);

        }

    }
}