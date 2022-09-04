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
    public partial class UserControl_賣家總覽 : UserControl
    {
        public UserControl_賣家總覽()
        {
            InitializeComponent();
        }


        public byte[] picture
        {
            //get { }
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.picb_賣家總覽.Image = Image.FromStream(ms);
            }
        }

        public string desciption
        {
            //get { }
            set
            {
                this.rtb_賣家總覽.Text = value;
            }
        }
    }
}
