using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashpoint_Interface
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_Login adminlogin = new Admin_Login();
            adminlogin.Show();

            this.Close();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Doctor_login doctorLogin = new Doctor_login();
            doctorLogin.ShowDialog();

            this.Close();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            PharmacyHomeTabs myPhamar = new Flashpoint_Interface.PharmacyHomeTabs();
                myPhamar.ShowDialog();

            this.Close();
        }
    }
}
