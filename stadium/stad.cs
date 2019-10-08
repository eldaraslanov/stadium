using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stadium
{
    public partial class stad : UserControl
    {
        stadiumDB db = new stadiumDB();
        public stad()
        {
            InitializeComponent();
        }

        #region Add Click
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string staName = txtstadName.Text;
            string staNo = txtstadNo.Text;
            string staPrice = txtStadPrice.Text;
            string roName = txtRoomName.Text;
            string roNo = txtRoomNo.Text;
            int nmPerson = (int)nmUpRoomPerson.Value;
            stadium selectStat = db.stadia.FirstOrDefault(st => st.meydanAd == staName);


            if (Extension.IsEmpty(
                new string[] {
                    staName,staNo,staPrice,roName,roNo,Convert.ToString(nmPerson)
                }, string.Empty
                ))
            {
                if (selectStat == null)
                {
                    lblerror.Visible = false;

                    if (true)
                    {

                    }
                    db.stadia.Add(new stadium
                    {
                        meydanAd = staName,
                        meydanNo = Convert.ToInt32(staNo),
                        price = Convert.ToDouble(staPrice),
                    });
                    db.SaveChanges();
                    db.rooms.Add(new room
                    {
                        roomAd = roName,
                        roomNo = Convert.ToInt32(roNo),
                        person = nmPerson,
                    });
                    db.SaveChanges();
                    MessageBox.Show("Stadium and Room create successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleareAllControlls();
                }
                else
                {
                    lblerror.Text = "Meydanca adi artiq movcuddur";
                    lblerror.Visible = true;
                }
            }
         

            else
            {
                lblerror.Text = "Please all the fill!";
                lblerror.Visible = true;
            }
        }
        #endregion

        #region keychar Price
        private void TxtStadPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                {
                    e.Handled = true;
                } 
        }
        #endregion

        #region keychar stadNo
        private void TxtstadNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region keyChar room no
        private void TxtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region clear All Controlls
        private void cleareAllControlls()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)item;
                    num.Value = 0;
                }
            }
        }
        #endregion

        #region data Stadium

        private void dtgStadium()
        {
            dataGridViewStad.DataSource = db.stadia.Select(st => new
            {
                st.meydanAd,
                st.meydanNo,
                st.price,
            }).ToList();
        }
        #endregion

        #region data Room
        private void dtgRoom()
        {
            dataGridViewRoom.DataSource = db.rooms.Select(ro => new
            {
                ro.roomAd,
                ro.roomNo,
                ro.person,
            }).ToList();
        }
        #endregion

        #region stad load
        private void Stad_Load(object sender, EventArgs e)
        {
            dtgRoom();
            dtgStadium();
        }

        #endregion

    }
}
