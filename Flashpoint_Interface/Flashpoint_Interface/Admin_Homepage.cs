using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flashpoint_Interface
{
    public partial class Admin_Homepage : Form
    {
        MySqlConnection sqlConn;
        string myConnString = "server=196.253.108.211;user id=root;database=flashpointhospital_db;password=fL@$##0$P_db";

        public Admin_Homepage()
        {
            InitializeComponent();
        }
        int number = 10;

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            string mytext = "all";
            string sqlString = "CALL sp_PatientAppointment('" + mytext + "')";

            //ACTUALLY CHECKING DATABASE
            MySqlCommand cmd = new MySqlCommand(sqlString, sqlConn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Displaying the apointments 
                DataTable table = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                
                adapter.Fill(table);
                dataGridDisplayAppoint.DataSource = table;
                

            }
            else
            {
                dataGridDisplayAppoint.Visible = false;
            }
        }

       

        private void addStaffDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            grBNewStaffMember.Visible = true;
        }

        private void updateStaffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grBUpdateStaffDetails.Visible = true;
        }

        private void deleteStaffMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpDeleteStaffMember.Visible = true;
        }

        private void txtSearchAppoint_TextChanged(object sender, EventArgs e)
        {
            sqlConn.Open();
           
            string sqlString = "CALL sp_PatientAppointment('" + txtSearchAppoint.Text + "')";

            //ACTUALLY CHECKING DATABASE
            MySqlCommand cmd = new MySqlCommand(sqlString, sqlConn);
            MySqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                //Displaying the apointments 
                DataTable table = new DataTable();
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(table);
                dataGridDisplayAppoint.DataSource = table;


            }
            else
            {
                dataGridDisplayAppoint.Visible = false;
            }


        }

        private void btnAppointSave_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
           

            string sqlString = "CALL sp_MakeAppointment('" + GenerateAppointID() + "','" + txtNewAppointPatientID.Text + "','" + txtNewAppointDepartmentID.Text + "','" + txtAppointDoctor.Text + "','" + txtAppointdate.Text + "','" + txtAppointTime.Text + "')";

            //ACTUALLY CHECKING DATABASE
            MySqlCommand cmd = new MySqlCommand(sqlString, sqlConn);
            MySqlDataReader dr = cmd.ExecuteReader();
        }

        public int GenerateAppointID()
        {
    

            DateTime today = DateTime.Today;

            int appointid = number + Convert.ToInt16(today);
            number++;

            return appointid;
        }

        private void btnDeleteAppoint_Click(object sender, EventArgs e)
        {
            sqlConn.Open();

            string sqlString = "CALL sp_DeleteAppointment('" + Convert.ToInt16(txtDeleteAppointID.Text) + "')";

            //ACTUALLY CHECKING DATABASE
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlString, sqlConn);
                MySqlDataReader dr = cmd.ExecuteReader();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
           

          
        }
    }
}
