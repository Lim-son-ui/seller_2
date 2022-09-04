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
    public partial class register : Form
    {
        
        public register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        iSpanProjectEntities6 isp4 = new iSpanProjectEntities6();
        private void register_Load(object sender, EventArgs e)
        {
           
            var q = from a in isp4.RegionLists
                    select a;

            foreach(var place in q)
            {
                this.cmb_region.Items.Add(place.RegionName);
            }

        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog_selfpic.ShowDialog() == DialogResult.OK)           //從資料夾打開圖檔
            {
                this.pic_selfpic.Image = Image.FromFile(this.openFileDialog_selfpic.FileName);
            }
        }

        private void button_yes_Clk(object sender, EventArgs e)
        {
            MemberAccount ma = new MemberAccount();

            ma.MemberAcc = txt_memacc.Text;
            ma.MemberPw = txt_mempw.Text;
            
           
            ma.Phone = txt_phone.Text;
            ma.Email = txt_email.Text;
            ma.BackUpEmail = txt_bkemail.Text;
            ma.Address = txt_detai_add.Text;
            ma.NickName = txt_nickname.Text;
            ma.Name = txt_name.Text;
            ma.Birthday = dtpk_birth.Value;
            ma.Bio = txt_biogra.Text;


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pic_selfpic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            byte[] bytes = ms.GetBuffer();

            ma.MemPic = bytes;


            var v = from r in isp4.RegionLists
                    where r.RegionName == cmb_region.Text
                    select r;
            foreach (var rg in v)
            {
                ma.RegionID = rg.RegionID;
            }

           // ma.RegionID = (cmb_region.SelectedIndex+1);
            ma.TWorNOT = rdbt_twornot.Checked;
            this.isp4.MemberAccounts.Add(ma);
            this.isp4.SaveChanges();

            Close();
        }

        private void twornot(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
