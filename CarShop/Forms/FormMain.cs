using CarShop.Repositories;
using CarShop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class FormOtomoto : Form
    {
        private UsersRepository userRepository = new UsersRepository();
        public static int IdUser { get; private set; }
        public FormOtomoto()
        {
            InitializeComponent();
        }


        private void loginUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if(loginUserControl.IsLogged == true)
            {
                offersUserControl.Visible = true;
                IdUser = loginUserControl.GetId();
            }
        }

        private void offersUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if(offersUserControl.IsHide == true)
            {
                ownOffersUserControl.Visible = true;
                ownOffersUserControl.IsHiden = false;
                ownOffersUserControl.SetDataGrid();
            }
        }

        private void ownOffersUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if(ownOffersUserControl.IsHiden == true)
            {
                offersUserControl.Visible = true;
                offersUserControl.RefreshDataGrid();
            }
        }
    }
}
