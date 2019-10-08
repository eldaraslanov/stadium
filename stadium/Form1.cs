using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stadium
{
    public partial class Form1 : Form
    {
        stadiumDB db = new stadiumDB();
        public Form1()
        {
            InitializeComponent();
        }

        #region lbl Click Close
        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region  User Name desigin
        private void TxtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            pa1.BackColor = Color.FromArgb(70, 52, 181);
            txtUserName.ForeColor = Color.FromArgb(70, 52, 181);
        }
        #endregion

        #region Password Color
        private void TxtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            pa2.BackColor = Color.FromArgb(70, 52, 181);
            txtPassword.ForeColor = Color.FromArgb(70, 52, 181);
        }
        #endregion

        #region CheckBox Color
        private void CheckBox1_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1.ForeColor = Color.FromArgb(70, 52, 181);
        }
        #endregion

        #region  btn funcion
        private void Button1_Click(object sender, EventArgs e)
        {
            string mail = txtUserName.Text;
            string password = txtPassword.Text;

            if (mail!=""&& password!="")
            {
                admin selecetadmin = db.admins.FirstOrDefault(ad => ad.emaile == mail);
                if (selecetadmin != null)
                {
                    if (selecetadmin.password == password)
                    {
                        Form2 frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        lblerror.Text = "please all the fill!";
                        lblerror.Visible = true;
                    }
                }
                else
                {
                    lblerror.Text = "please all the fill!";
                    lblerror.Visible = true;
                }
            }

        }

        #endregion


    }
}
