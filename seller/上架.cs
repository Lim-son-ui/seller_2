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
    public partial class 上架 : Form
    {
        public string account;
        public 上架()
        {
            InitializeComponent();
        }

        public 上架(string acc)
        {
            InitializeComponent();
            account = acc;
        }
       
        iSpanProjectEntities6 isp4 = new iSpanProjectEntities6();

        private void 上架_Load(object sender, EventArgs e)
        {

           
            var m = from b in isp4.SmallTypes
                    select b;

            foreach (var st in m)
            {
                this.cmb_smtype.Items.Add(st.SmallTypeName);
            }

            var q = from a in isp4.RegionLists
                    select a;

            foreach(var pd in q)
            {
                this.cmb_region.Items.Add(pd.RegionName);
            }

            var p = from c in isp4.Shippers
                    select c;

            foreach(var sp in p)
            {
                this.cmb_shipper.Items.Add(sp.ShipperName);
            }

            renew();

            foreach (Control items in Controls)
            {
                if (items.GetType().Name == "PictureBox")
                {
                    items.AllowDrop = true;//允許拖曳
                    items.DragDrop += Items_DragDrop;
                    items.DragEnter += Items_DragEnter;
                }
            }
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//PictureBox 顯示模式
        }

        private void Items_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            //throw new NotImplementedException();
        }

        private void Items_DragDrop(object sender, DragEventArgs e)
        {
            string filename = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];

            //if(pictureBox1.Image != null)
            //{
            //    pictureBox1.Image = null;
            //    GC.Collect();
            //}
            //pictureBox1.Image = Image.FromFile(filename);
            //throw new NotImplementedException();
        }
        
        void renew() {

            var q = (from a in isp4.MemberAccounts
                    where a.MemberAcc == account
                    select a).ToList();

            int memid = q[0].MemberID;
            var s = from d in isp4.Products
                    where d.MemberID == memid
                    select d;

            dataGridView1.DataSource = s.ToList();

            //var t = from v in isp4.ProductDetails
            //        select v;

            //dataGridView2.DataSource = t.ToList();

            //var w = from p in isp4.ProductPics
            //        select p;

           // dataGridView3.DataSource = w.ToList();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            if(this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_product.Image = Image.FromFile(this.ofd_product.FileName);
            }
        }
        public int product_id;
   
        private void refresh_Click(object sender, EventArgs e)
        {

            Product pd = new Product();
           

            var q = (from p in isp4.MemberAccounts
                    where p.MemberAcc == account
                    select p).ToList();
            pd.MemberID = q[0].MemberID;

            pd.ProductName = txt_pdname.Text;
            pd.Description = richTextBox_descript.Text;
            pd.AdFee = Convert.ToDecimal(txt_adfee.Text);

            var s = (from t in isp4.SmallTypes
                    where t.SmallTypeName == cmb_smtype.Text
                    select t).ToList();
            pd.SmallTypeID = s[0].SmallTypeID;
           
            
            var v = (from r in isp4.RegionLists
                    where r.RegionName == cmb_region.Text
                    select r).ToList();
            pd.RegionID = v[0].RegionID;
            

            var m = (from n in isp4.Shippers
                    where n.ShipperName == cmb_shipper.Text
                    select n).ToList();
            pd.ShipperID = m[0].ShipperID;
            


            this.isp4.Products.Add(pd);
            this.isp4.SaveChanges();
            product_id = pd.ProductID;

            for(int i = 0;i < pd_detail.Count; i++)
            {
                ProductDetail prd = new ProductDetail();
                prd.ProductID = product_id;
                prd.Style = pd_detail[i].Style;
                prd.Quantity = pd_detail[i].Quantity;
                prd.UnitPrice = pd_detail[i].UnitPrice;
                prd.Pic = pd_detail[i].pic;
                this.isp4.ProductDetails.Add(prd);
            }

            for(int i = 0; i < pd_pic.Count; i++)
            {
                ProductPic pdpic = new ProductPic();
                pdpic.ProductID = product_id;
                pdpic.picture = pd_pic[i].picture;
                this.isp4.ProductPics.Add(pdpic);
            }
            
            this.isp4.SaveChanges();


            pd_detail.Clear();
            pd_pic.Clear();
            renew();
        }

        private void dele_Click(object sender, EventArgs e)
        {

            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var del = (from a in isp4.ProductDetails
                       where a.ProductID == pdid
                       select a).FirstOrDefault();

            var delll = (from c in isp4.ProductPics
                         where c.ProductID == pdid
                         select c
                        ).FirstOrDefault();

            isp4.ProductDetails.Remove(del);
            isp4.ProductPics.Remove(delll);

            this.isp4.SaveChanges();


            var de = (from b in isp4.Products
                      where b.ProductID == pdid
                      select b).FirstOrDefault();

            isp4.Products.Remove(de);

            this.isp4.SaveChanges();

            renew();
            #region
            //var dell = (from d in isp.MemberAccount
            //          where (d.RegionID == 1)
            //          select d).FirstOrDefault();

            //var delll = (from c in isp.RegionList
            //             where (c.RegionID == 1)
            //             select c
            //            ).FirstOrDefault();


            //isp.MemberAccount.Remove(dell);
            //isp.RegionList.Remove(delll);


            //this.isp.SaveChanges();
            #endregion
        }

        private void alter_Click(object sender, EventArgs e)
        {
            //dataGridView1.CurrentRow.Cells[""]


            //修改 alter = new 修改(account);
            //alter.Show();
            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);


           
        //-----------------------------------------------------------------------
            var a = from b in isp4.ProductDetails
                    where b.ProductID == pdid
                    select b;

            foreach(var pdtt in a)
            {
                pdtt.Style = txt_style.Text;
                pdtt.Quantity = Convert.ToInt32(txt_quantity.Text);
                pdtt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            }

            var c = from d in isp4.ProductPics
                    where d.ProductID == pdid
                    select d;


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            foreach (var ppic in c)
            {
                ppic.picture = bytes;
            }
            this.isp4.SaveChanges();

            //var t = from k in isp4.Products
            //        where k.ProductID

            var j = (from s in isp4.SmallTypes
                    where s.SmallTypeName == cmb_smtype.Text
                    select s).ToList();
            

            var i = (from t in isp4.RegionLists
                    where t.RegionName == cmb_region.Text
                    select t).ToList();

            var x = (from z in isp4.Shippers
                    where z.ShipperName == cmb_shipper.Text
                    select z).ToList();

            var g = from f in isp4.Products
                    where f.ProductID == pdid
                    select f;

           
            foreach(var prds in g)
            {
                prds.ProductName = txt_pdname.Text;
                prds.Description = richTextBox_descript.Text;
                prds.AdFee = Convert.ToDecimal(txt_adfee.Text);
                prds.SmallTypeID = j[0].SmallTypeID;
                prds.RegionID = i[0].RegionID;
                prds.ShipperID = x[0].ShipperID;
            }

            this.isp4.SaveChanges();

            pd_detail.Clear();
            pd_pic.Clear();
            //-----------------------------------------------------------------------


            renew();
        }

    
        private void count_Click(object sender, EventArgs e)
        {

        }
      
        private void search_clk(object sender, EventArgs e)     //要重新清空背景顏色
        {
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                foreach(DataGridViewCell c in r.Cells)
                {
                    if (c.Value == null) continue;
                    if (c.Value.ToString().ToUpper().Contains(txt_srch.Text.ToUpper()))
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                    if (c.Value.ToString().Contains(txt_srch.Text))
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                }
            }
        }

        List<商品細項> pd_detail = new List<商品細項>();        //暫存的商品規格


        private void btn_remove_Click(object sender, EventArgs e)
        {
            //var inde = ((UserControl1)UserControl).index;
            //pd_detail.RemoveAt(1);
            //this.flowLayoutPanel1.Controls.Remove(inde);
            //flowLayoutPanel1.Controls.ind
            Application.DoEvents();

            //UserControl.
        }
        
        private void btn_show_format_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < pd_detail.Count; i++)
            {
                UserControl1 detail = new UserControl1();
                detail.style = pd_detail[i].Style;
                detail.quantity = pd_detail[i].Quantity;
                detail.unitprice = pd_detail[i].UnitPrice;
                detail.picture = pd_detail[i].pic;

                this.flowLayoutPanel1.Controls.Add(detail);

                Application.DoEvents();
            }
        }

        private void btn_newformat_Click(object sender, EventArgs e)
        {
            //format();       //加入文字輸入到list中
            商品細項 pd_dtail = new 商品細項();

            pd_dtail.Style = txt_style.Text;
            pd_dtail.Quantity = Convert.ToInt32(txt_quantity.Text);
            pd_dtail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
           

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_format.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            pd_dtail.pic = bytes;

           
            pd_detail.Add(pd_dtail);


        }

        void format()
        {

            商品細項 pd_dtail = new 商品細項();
            
            pd_dtail.Style = txt_style.Text;
            pd_dtail.Quantity = Convert.ToInt32(txt_quantity.Text);
            pd_dtail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            
            pd_detail.Add(pd_dtail);
        }

        //product圖
        #region
        List<商品圖> pd_pic = new List<商品圖>();               //暫存的商品圖

        private void btn_show_pic_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel2.Controls.Clear();
            for(int i = 0; i < pd_pic.Count(); i++)
            {
                UserControl2 pict = new UserControl2();
                pict.picture = pd_pic[i].picture;

                this.flowLayoutPanel2.Controls.Add(pict);
                
                Application.DoEvents();
            }
        }

        private void btn_new_pic_Click(object sender, EventArgs e)
        {
            pic();
        }

        void pic()
        {
            商品圖 pdpic = new 商品圖();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            pdpic.picture = bytes;

            pd_pic.Add(pdpic);
        }
        #endregion

        private void picb_product_MouseUp(object sender, MouseEventArgs e)      //想做圖片可以托拉進去
        {
            //foreach (Control items in Controls)
            //{
            //    if (items.GetType().Name == "picb_product")
            //    {
            //        items.AllowDrop = true;
            //        items.DragDrop += Items_DragDrop;
            //        items.DragEnter += Items_DragEnter;
            //    }
            //    picb_product.SizeMode = PictureBoxSizeMode.Zoom;
            //}

        }

        private void btn_open_formatpic_Click(object sender, EventArgs e)
        {
            if (this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_format.Image = Image.FromFile(this.ofd_product.FileName);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)          //想做統計
        {
            var q = (from a in isp4.Products
                     group a by a.SmallTypeID into g
                     select new { small = g.Key, cont = g.Count() }).OrderByDescending(b => b.small);

            chart1.ChartAreas.Add("FirstChart");
            chart1.Series.Add("Pie");

            foreach (var j in q)
            {
                
                chart1.Series[0].Points.AddXY(j.small, j.cont);
                chart1.Series[0].IsValueShownAsLabel = true;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)      //產生對應的可修改選項
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var q = from a in isp4.ProductDetails
                    where a.ProductID == index
                    select a;

            dataGridView2.DataSource = q.ToList();

            var viewpic = from a in isp4.ProductPics
                          where a.ProductID == index
                          select a;
            dataGridView3.DataSource = viewpic.ToList();
//-----------------------------------------------------------------------
            var deta = (from a in isp4.Products
                       where a.ProductID == index
                       select a).ToList();
            int smallid = deta[0].SmallTypeID;
            int regionid = deta[0].RegionID;
            
            foreach(var details in deta)
            {
                txt_pdname.Text = details.ProductName;
                txt_adfee.Text = details.AdFee.ToString();
                richTextBox_descript.Text = details.Description;
            }
            var small = (from a in isp4.SmallTypes
                        where a.SmallTypeID == smallid
                        select a).ToList();

            cmb_smtype.Text = small[0].SmallTypeName;

            var region = (from a in isp4.RegionLists
                         where a.RegionID == regionid
                         select a).ToList();

            cmb_region.Text = region[0].RegionName;
            //---------------------------------------------------------------
            byte[] data = null;

            var pics = (from a in isp4.ProductPics
                    where a.ProductID == index
                    select a).ToList();

            data = pics[0].picture;
            
            MemoryStream stream = new MemoryStream(data);
            picb_product.Image = Image.FromStream(stream);
            stream.Close();
            //---------------------------------------------------------------

            var detai = (from a in isp4.ProductDetails
                        where a.ProductID == index
                        select a).ToList();

            txt_style.Text = detai[0].Style;
            txt_quantity.Text = detai[0].Quantity.ToString();
            txt_unitprice.Text = detai[0].UnitPrice.ToString();
            data = detai[0].Pic;

            MemoryStream stream_format = new MemoryStream(data);
            picb_format.Image = Image.FromStream(stream_format);
            stream.Close();
        }
    }
}
