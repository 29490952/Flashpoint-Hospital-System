using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tulpep.NotificationWindow;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Flashpoint_Interface
{
	
    public partial class Doctor_login : Form
    {
        MySqlConnection sqlConn;
        string myConnString = "server=localhost;user id=root;database=flashpointhospital_db;password=fL@$##0$P_db";
        public Doctor_login()
        {
            InitializeComponent();
        }
        private void Doctor_login_Load(object sender, EventArgs e)
        {
           
            try
            {
                sqlConn = new MySqlConnection(myConnString);

                //CONNECTION CONFIRMATION
                sqlConn.Open();
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Database Connection";
                popup.ContentText = "Connected";
                popup.Popup();
                sqlConn.Close();
            }
            catch (MySqlException ex)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Database_error;
                popup.TitleText = "Database Connection";
                popup.ContentText = "Could not connect" + ex.Message;
                popup.Popup();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Open Connection
            sqlConn.Open();

            //Var to check Doctor ID
            string docName = "Not Found";
            string docSurname = "";
            string docID = "";
            string sqlString = "CALL sp_CheckStaffID('" + 12457896 + "')";//txtDocID.Text

            //ACTUALLY CHECKING DATABASE
            MySqlCommand cmd = new MySqlCommand(sqlString, sqlConn);
            MySqlDataReader dr = cmd.ExecuteReader();

            //CHECK IF IT READ SOMETHING FROM DATABASE
            if(dr.Read())
            {
                //PUTTING DOCTOR ID IN DOC VARIABLE
                docName = dr["firstName"].ToString();
                docSurname = dr["lastName"].ToString();
                docID = dr["staffID"].ToString();

                sqlConn.Close();
                Doctor_Activities doctor_Activities = new Doctor_Activities(sqlConn, docID, docName, docSurname);
                doctor_Activities.ShowDialog();
            }
            else
            {
                MessageBox.Show("Doctor Not Found");
            }
        }
	}
}
