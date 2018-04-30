using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class PrintForm : Form
    {
        KaiPiao KPfrm;
        public PrintForm(KaiPiao frm)
        {
            InitializeComponent();
            KPfrm = frm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KaiPiao.succ = true;
            double val = KaiPiao.total_value;
            int x = 0;
            int y = 0;
            try
            {
                x = Convert.ToInt16(textBox1.Text);
                y = Convert.ToInt16(textBox2.Text);
            }
            catch(Exception ex)
            {
            }
            KPfrm.Print(x,y);
            this.Close();
           
        }
    }
}