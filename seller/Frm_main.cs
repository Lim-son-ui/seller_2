using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seller
{
    public partial class Frm_main : Form
    {
       
        public string account;

        public Frm_main()
        {
            InitializeComponent();
        }

        public Frm_main(string acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            buyer buy = new buyer();
            buy.MdiParent = this;
            buy.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            賣家中心 sel = new 賣家中心(account);
            //上架 sel = new 上架(account);
            sel.MdiParent = this;
            sel.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            (new LogIn()).ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("目前帳號為:" + account);
        }
    }
}
