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
    public partial class reservesion : UserControl
    {
        stadiumDB db = new stadiumDB();

        public reservesion()
        {
            InitializeComponent();
        }

        #region keychar telNumber
        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<48 || e.KeyChar>57) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region stadium combo fill

        private void StadiumComboFill()
        {
            cmbStadium.Items.AddRange(db.stadia.Select(fr=>fr.meydanAd).ToArray());
        }
        #endregion

        #region Room Combo Fill

        private void RoomComboFill()
        {
            cmbRoom.Items.AddRange(db.rooms.Select(cr => cr.roomAd).ToArray());
        }

        #endregion

        #region reservesion load

        private void Reservesion_Load(object sender, EventArgs e)
        {
            StadiumComboFill();
            RoomComboFill();
        }
        #endregion

    }
}
