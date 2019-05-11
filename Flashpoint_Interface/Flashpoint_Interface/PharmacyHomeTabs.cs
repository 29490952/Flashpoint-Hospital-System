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
        string myConnString = "server=196.253.108.211; User ID=karabo; Password=fL@$##0$P_db; Database=flashpointhospital_db;Sslmode=none";
       
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
<<<<<<< HEAD
            tabControl1.SelectTab(1);
=======
            PresTab.Show();
            //sqlConn.Open();
            try
            {
                

                MySqlDataAdapter adapter = new MySqlDataAdapter("CALL ph_Access_Prescriptions('" + txtPatID + "')", sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "prescription");

                presDataGridView.DataSource = ds;
                presDataGridView.DataMember = "prescription";
>>>>>>> 0a6bfcc56deb502e094b12b6c958c8b05bab269a

        }

        private void btnDrugAvail_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(2);


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
                MessageBox.Show(er.Message);
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

        


        private void button3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Add_Drugs myDrugs = new Add_Drugs();
            myDrugs.ShowDialog();

        }


        private void btnViewPrescription_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
=======
            tabControl1.TabIndex = 2;

>>>>>>> 0a6bfcc56deb502e094b12b6c958c8b05bab269a
            try
            {


                MySqlDataAdapter adapter = new MySqlDataAdapter("CALL ph_Access_Prescription('" + txtPatID + "')", sqlConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "prescription");

                presDataGridView.DataSource = ds;
                presDataGridView.DataMember = "prescription";

                sqlConn.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void PresTab_Click(object sender, EventArgs e)
        {

        }

        private void HomeTab_Click(object sender, EventArgs e)
        {

        }
    }
}
