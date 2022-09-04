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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public byte[] picture {
            //get { }
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pictureBox1.Image = Image.FromStream(ms);
            }

        }
    }
}
