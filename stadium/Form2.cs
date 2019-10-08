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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pnlsSlide.Height = btnReserv.Height;
            pnlsSlide.Top = btnReserv.Top;
            stad1.BringToFront();
            reservesion1.BringToFront();

        }

        #region x close form2
        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region panel Slide
        private void BtnReserv_Click(object sender, EventArgs e)
        {
            pnlsSlide.Height = btnReserv.Height;
            pnlsSlide.Top = btnReserv.Top;
            reservesion1.BringToFront();

        }

        private void Btnstadium_Click(object sender, EventArgs e)
        {
            pnlsSlide.Height = btnstadium.Height;
            pnlsSlide.Top = btnstadium.Top;
            stad1.BringToFront();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            pnlsSlide.Height = btnReport.Height;
            pnlsSlide.Top = btnReport.Top;
        }
        #endregion

    }
}
