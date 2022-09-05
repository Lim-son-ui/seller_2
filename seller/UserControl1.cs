using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace seller
{
    public partial class UserControl1 : UserControl
    {
        public 商品細項 index;
        public UserControl1()
        {
            InitializeComponent();
        }

        public string style
        {
            //get { }
            set
            {
                this.txt_style.Text = value;
            }
        }
        public int quantity
        {
            //get { }
            set
            {
                this.txt_quantity.Text = value.ToString();
            }
        }
        public decimal unitprice
        {
            //get { }
            set
            {
                this.txt_price.Text = value.ToString();
            }
        }

        public byte[] picture {
            //get { }
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        //public event EventHandler RemoveUserControl;
        private void btn_delete_detail_Click(object sender, EventArgs e)
        {
            //((上架)Form).
            //Application.Exit();
            //Window par = (Window)this.Parent;
            //par.clo
            
            //RemoveUserControl(sender, e);
            //return;
            //this.Controls.Clear();
            //int index = flowLayoutPanel1.
        }
    }
}
