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
    public partial class 修改 : Form
    {
        public string account;
        public 修改()
        {
            InitializeComponent();
        }
        public 修改(string ac)
        {
            InitializeComponent();
            account = ac;
        }
        iSpanProjectEntities6 isp4 = new iSpanProjectEntities6();
        private void 修改_Load(object sender, EventArgs e)
        {
            renew();
        }

        void renew()
        {
            var q = from a in isp4.ProductPics
                    select a;

            var p = from b in isp4.Products
                    select b;

            var r = from c in isp4.ProductDetails
                    select c;

            dataGridView1.DataSource = p.ToList();
            dataGridView2.DataSource = r.ToList();
            dataGridView3.DataSource = q.ToList();
        }

        private void btn_change_Click(object sender, EventArgs e)   //先想清楚產品什麼時候會重複的情況
        {
           
            var q = from a in isp4.Products
                    where a.MemberID == Convert.ToInt32(account) && a.ProductName.ToString() == txt_pdname.Text
                    select a;

            foreach(var pd in q)
            {
                pd.ProductName = txt_pdname.Text;
                pd.AdFee = Convert.ToDecimal(txt_adfee);
                pd.Description = richTextBox_descript.Text;
            }

            //var p = from b in isp4.ProductDetail
            //        where b.ProductName == txt_pdname.Text
            //        select b;

            foreach (var pd in q)
            {
                pd.ProductName = txt_pdname.Text;
                pd.AdFee = Convert.ToDecimal(txt_adfee);
                pd.Description = richTextBox_descript.Text;
            }

        }
    }
}
