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
    public partial class 賣家中心 : Form
    {
        public string account;
        public 賣家中心()
        {
            InitializeComponent();
        }

        public 賣家中心(string acc)
        {
            InitializeComponent();
            account = acc;
        }

        iSpanProjectEntities6 isp = new iSpanProjectEntities6();
        private void 賣家中心_Load(object sender, EventArgs e)
        {
            label2.Text = account;      
            label4.Text = account;
            int mem_id = 0;

            var j = (from i in isp.MemberAccounts
                    where i.MemberAcc == account
                    select i).ToList();
            mem_id = j[0].MemberID;
            

            var q = from a in isp.Products
                    where a.MemberID == mem_id
                    select a;

            lbl_sel_count.Text = q.Count().ToString();

            List<int> prod = new List<int>();
            var product = from a in isp.Products
                          select a;
            
            foreach(var pd in product)
            {
                prod.Add(pd.ProductID);
            }


            for (int i = 0; i < prod.Count(); i++)
            {
                UserControl_賣家總覽 seller = new UserControl_賣家總覽();
                int produ = prod[i];

                var main_picture = (from a in isp.ProductPics
                                   where a.ProductID == produ
                                   select a).ToList();

                seller.picture = main_picture[0].picture;

                var descript = (from a in isp.Products
                               where a.ProductID == produ
                               select a).ToList();

                seller.desciption = descript[0].Description;
                this.flowLayoutPanel1.Controls.Add(seller);

                Application.DoEvents();
            }
            


        }

        private void lklb_upload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            上架 sel = new 上架(account);
            sel.Show();
        }
    }
}
