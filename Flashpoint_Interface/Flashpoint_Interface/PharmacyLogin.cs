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
    public partial class PharmacyLogin : Form
    {
        public PharmacyLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PharmacyHomeTabs myPhamar = new Flashpoint_Interface.PharmacyHomeTabs();
            myPhamar.ShowDialog();

            // try
            //{

            //if(!(txtUserID.Text == string.Empty))
            //{
            //    if(!(txtPassword.Text == string.Empty))
            //    {
            //        String str = "TABLE FOR LOGIN CREDENTIALS";
            //        String query = "select * from DATABSE where UserID ='" + txtUserID.Text + "'and Password='" + this.txtPassword.Text + "'";

            //        SqlConnection con = new SqlConnection(str);
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        SqlDataReader dtr;

            //        con.Open();
            //        dtr = cmd.ExecuteReader();

            //        int count = 0;
            //        while(dtr.Read())
            //        {
            //            count = count + 1;
            //        }
            //        if(count == 1)
            //        {
            //            MessageBox.Show("Login Successful");
            //      }
            //    else if(count > 1)
            //  {
            //    MessageBox.Show("Invalid Loign Credentials");
            //}
            //else
            //{
            //  MessageBox.Show("");
            //}
            //}
            //}

            //}
            //catch (Exception es)
            //{
            //  MessageBox.Show(es.Message);
            //}

            //}
        }
    }
}
    
