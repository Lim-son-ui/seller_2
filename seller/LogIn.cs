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
    public partial class LogIn : Form
    {

        bool isclosed = true;
        public LogIn()
        {
            InitializeComponent();
            
        }

       
        iSpanProjectEntities6 isp4 = new iSpanProjectEntities6();

        //bool PWisCorrect;
        private void OK_Click(object sender, EventArgs e)
        {
            
            var q = from p in isp4.MemberAccounts
                    where (p.MemberAcc == account_txt.Text) && (p.MemberPw == PW_txt.Text)
                    select p;

            
            //MessageBox.Show(""+ q);
            //foreach(var a in q)
            //{
            //    MessageBox.Show(a.MemberAcc);
            //}



            if(q.ToList().Count() > 0)
            {
                MessageBox.Show("登入成功");
                isclosed = false;

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Frm_main))
                    {
                        ((Frm_main)form).account = account_txt.Text;
                    }

                }

                Close();
                return;
            }



            MessageBox.Show("密碼錯誤或電子郵件不存在");
             
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void NO_Click(object sender, EventArgs e)
        {
            isclosed = false;
            Application.Exit();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = isclosed;
        }

        private void lklb_regis_clk(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register rg = new register();
            rg.Show();
        }

        private void PW_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
