using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenesV0.views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void hideAdminButton()
        {
            this.btnAddUser.Hide();
               
        }
        private void bntCrearViaje_Click(object sender, EventArgs e)
        {
            using (createTrainRide trainRideWindow = new createTrainRide())
                trainRideWindow.ShowDialog();
        }

        private void btnAddMaterialRodante_Click(object sender, EventArgs e)
        {
            using (AddMaterial addMaterialWindow = new AddMaterial())
                addMaterialWindow.ShowDialog();
        }

        private void btnEditMaterialRodante_Click(object sender, EventArgs e)
        {
            using (EditMaterial editMaterialWindow = new EditMaterial())
                editMaterialWindow.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login loginWindows = new Login())
                loginWindows.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (userManagment userManagmentWindow = new userManagment())
                userManagmentWindow.ShowDialog();
        }
    }
}
