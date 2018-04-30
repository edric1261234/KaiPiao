using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using ShenBao;


namespace WindowsApplication1
{
    public partial class KaiPiao : Form
    {
        const float SHUILV = (float)0.17; //税率0.17
        const int COLUMN_SHUILV = 6;  // 税率
        const int COLUMN_COUNT = 3; //数量
        const int COLUMN_PRICE = 4; //单价
        const int COLUMN_JINER = 5; //金额，不含税
        const int COLUMN_SHUIER = 7; // 税额
        public KaiPiao()
        {
            InitializeComponent();
            List1[COLUMN_SHUILV, 0].Value = SHUILV;
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

        public static double total_value = 0;
        private void List1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int current_row = List1.RowCount - 2;
            if (current_row < 0)
                return;

            //金额=数量*单价
            if (List1[COLUMN_COUNT, current_row].Value != null && List1[COLUMN_PRICE, current_row].Value != null)
            {
                double total_price = double.Parse(List1[COLUMN_COUNT, current_row].Value.ToString()) * double.Parse(List1[COLUMN_PRICE, current_row].Value.ToString());

                List1[COLUMN_JINER, current_row].Value = total_price.ToString();
                List1[COLUMN_SHUIER, current_row].Value = (total_price * SHUILV).ToString("f2");
            }

            //
            double total_jiner = 0;
            double total_shuier = 0;
            for (int i = 0; i < List1.RowCount - 1; i++) 
            {
                if (List1[COLUMN_JINER, i].Value == null || List1[COLUMN_SHUIER, i].Value == null)
                    continue;

                total_jiner += double.Parse(List1[COLUMN_JINER, i].Value.ToString()) ;
                total_shuier += double.Parse(List1[COLUMN_SHUIER, i].Value.ToString()); 
            }

            _lbl_total_jiner.Text = total_jiner.ToString();
            _lbl_total_shuier.Text = total_shuier.ToString();
        

            if (!string.IsNullOrEmpty(_lbl_total_jiner.Text) && !string.IsNullOrEmpty(_lbl_total_shuier.Text))
            {
                try
                {
                    total_value = double.Parse(_lbl_total_jiner.Text);// +double.Parse(label20.Text);
                    label21.Text = total_value.ToString();
                }
                catch
                {
                    MessageBox.Show("金额或税额格式不正确，请重新输入");
                }
            }
        }

        private PrintDocument printDocument1 = new PrintDocument();


        public void Print(int x,int y)
        {
            save_data();
            MessageBox.Show("打印成功");
  
        }

        private void save_data()
        {
            INIClass ini_class = new INIClass("D:\\yinuo.ini");
            ini_class.IniWriteValue("KaiPiao", "HeJi", total_value.ToString());
            ini_class.IniWriteValue("KaiPiao", "ShuiEr", _lbl_total_shuier.Text);
          
        }


        private void List1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int row_count = List1.RowCount;
            List1[COLUMN_SHUILV, row_count - 1].Value = SHUILV;
        }

     

    }
}