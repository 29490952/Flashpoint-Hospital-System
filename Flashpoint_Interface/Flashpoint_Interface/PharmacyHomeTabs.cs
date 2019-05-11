using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using MySql.Data.MySqlClient;

namespace Flashpoint_Interface
{
    public partial class PharmacyHomeTabs : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        string myConnString = "server=196.253.108.211; User ID=thato; Password=fL@$##0$P_db; Database=flashpointhospital_db;Sslmode=none";
       
        public PharmacyHomeTabs()
        {
            InitializeComponent();

            try
            {
                sqlConn = new MySqlConnection(myConnString);

                sqlConn.Open();
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Database Connection";


                sqlConn.Close();
            }
            catch (MySqlException ex)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Database_error;
                popup.TitleText = "Database Connection";
                popup.ContentText = "Could not connect" + ex.Message;
            }
        }

        private void PharmacyHomeTabs_Load(object sender, EventArgs e)
        {

        }

        private void btnViewPres_Click(object sender, EventArgs e)
        {
            PresTab.Show();
            try
            {
                sqlConn.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("CALL ph_Access_Prescriptions('" + txtPatID + "')", sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "prescription");

                presDataGridView.DataSource = ds;
                presDataGridView.DataMember = "prescription";

                sqlConn.Close();
            }
            catch(MySqlException er)
            {

            }
           
           
        }

        private void btnDrugAvail_Click(object sender, EventArgs e)
        {

            DrugsTab.Show();

            sqlConn.Open();

            try
            {
                

                MySqlDataAdapter adapter = new MySqlDataAdapter("CALL ph_Access_Prescriptions()", sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "drug");

                dataGridDrugs.DataSource = ds;
                dataGridDrugs.DataMember = "drug";

                sqlConn.Close();
            }
            catch (MySqlException er)
            {

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to close this program?", "Exit", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tabConPharmacy.SelectedIndex = 1;
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
                //        }
                //        else if(count > 1)
                //        {
                //            MessageBox.Show("Invalid Loign Credentials");
                //        }
                //        else
                //        {
                //            MessageBox.Show("");
                //        }
                //    }
                //}
                //sqlConn.Close();
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void LoginTab_Click(object sender, EventArgs e)
        {
            PresTab.Hide();
            DrugsTab.Hide();
            tabConPharmacy.TabPages.Remove(PresTab);
            tabConPharmacy.TabPages.Remove(DrugsTab);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Drugs myDrugs = new Add_Drugs();
            myDrugs.ShowDialog();

        }
    }
}
