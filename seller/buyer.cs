using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seller
{
    public partial class buyer : Form
    {
        public buyer()
        {
            InitializeComponent();
        }
        iSpanProjectEntities6 isp4 = new iSpanProjectEntities6();
        private void buyer_Load(object sender, EventArgs e)
        {
            renew();
        }

        void renew()
        {
           
            var p = from b in isp4.Products
                    select  new { 
                        b.ProductID,
                        b.ProductName,
                        b.AdFee,
                        b.Description,
                        b.SmallTypeID,
                        b.ShipperID,
                        b.RegionID
                    };
            
            dataGridView2.DataSource = p.ToList();

          
        }
        #region
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buyer_MouseClick(object sender, MouseEventArgs e)
        {
        
        }
        #endregion
        #region
        //private void dataGridView1_MouseClick(object sender, MouseEventArgs e)  //商品細項圖
        //{
        //    Byte[] data = (Byte[])dataGridView2.CurrentRow.Cells["picture"].Value;

        //    MemoryStream stream = new MemoryStream(data);
        //    picb_product.Image = Image.FromStream(stream);  //丟給誰接
        //    stream.Close();
        //}
        #endregion
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)  //商品總覽
        {


            int pid = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ProductID"].Value);
            var s = from b in isp4.ProductDetails
                    where b.ProductID == pid
                    select b;

            foreach(var prd in s)
            {
                txt_style.Text = prd.Style.ToString();
                txt_unitprice.Text = prd.UnitPrice.ToString();
                txt_quantity.Text = prd.Quantity.ToString();
            }

            
            byte[] data = null;

            var q = from a in isp4.ProductPics
                    where a.ProductID == pid
                    select a;


            foreach (var pic in q)                  //圖片這邊卡關
            {
                data = pic.picture;
            }

            MemoryStream stream = new MemoryStream(data);
            picb_product.Image = Image.FromStream(stream);
            stream.Close();


            //想用cmb讓使用者選擇購買的數量
            //int count = 0;
            //var q = from a in isp4.ProductDetail
            //        select new
            //        {
            //            count = a.Quantity
            //        }.ToString();

            //for (int i = 0; i < count; i++)
            //{
            //    cmb_buy.Items.Add(i.ToString());
            //}

            //foreach (var pd in q)
            //{
            //    cmb_buy.Items.Add(pd.Quantity);
            //}

        }



        private void btn_buy_Click(object sender, EventArgs e)
        {
            int buy_origin = 0;

            var q = from a in isp4.ProductDetails
                    select new
                    {
                        buy_origin = a.Quantity
                    };
            int buy_min = Convert.ToInt32(cmb_buy.Text);

            MessageBox.Show(""+(buy_origin - buy_min));

            renew();
        }
    }
}
