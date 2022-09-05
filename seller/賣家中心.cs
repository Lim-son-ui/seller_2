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

            var j = (from i in isp.MemberAccounts       //找出對應帳號的id
                    where i.MemberAcc == account
                    select i).ToList();
            mem_id = j[0].MemberID;
            

            var q = from a in isp.Products      //透過id找出賣家所要販賣的商品
                    where a.MemberID == mem_id
                    select a;


            lbl_sel_count.Text = q.Count().ToString();

            List<int> prod = new List<int>();


            if (q.Count() > 0)           //代表賣家有商品 可以顯示
            {

                foreach(var pid in q)       //抓取特定賣家的id存入list中使用
                {
                    prod.Add(pid.ProductID);
                }


                for (int i = 0; i < prod.Count(); i++)          //根據list中的proid內容把值放入usercontrol顯示
                {
                    UserControl_賣家總覽 seller = new UserControl_賣家總覽();
                    int produ = prod[i];

                    var main_picture = (from a in isp.ProductPics               //抓取販賣商品的圖片
                                        where a.ProductID == produ
                                        select a).ToList();

                    if(main_picture.Count() > 0)
                    {
                        seller.picture = main_picture[0].picture;
                    }
                    

                    var descript = (from a in isp.Products          //抓取商品的描述
                                    where a.ProductID == produ
                                    select a).ToList();

                    seller.desciption = descript[0].Description;
                    this.flowLayoutPanel1.Controls.Add(seller);

                    Application.DoEvents();
                }


            }

           
            //var product = from a in isp.Products  //抓取
            //              select a;
            
            //foreach(var pd in product)
            //{
            //    prod.Add(pd.ProductID);
            //}

        }

        private void lklb_upload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            上架 sel = new 上架(account);
            sel.Show();
        }
    }
}
