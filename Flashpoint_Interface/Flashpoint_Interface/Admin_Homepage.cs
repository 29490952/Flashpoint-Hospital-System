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
        string myConnString = "server=196.253.108.211;user id=karabo;database=flashpointhospital_db;password=fL@$##0$P_db,Sslmode=none";

        public Admin_Homepage()
        {
            InitializeComponent();
        }
        int number = 10;

        private void Admin_Homepage_Load(object sender, EventArgs e)
        {
            /*sqlConn.Open();
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
            }*/
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

       

        private void button6_Click(object sender, EventArgs e)
        {
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = true;
            grpSeachResults.Visible = false;
            grpAdd.Visible = false;
            grpExit.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnAddPatient.Visible = false;
            
            grpAdd.Visible = true;
            grpSeachResults.Visible = false;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = false;
            grpExit.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpSeachResults.Visible = true;
            grpExit.Visible = false;
            String name = txtSearchName.Text;
            String surname = txtSearchSurname.Text;
            String idNumber = txtSearchID.Text;

            string inputString = "call sp_PatientInfo('" + idNumber + "','" + name + "','" + surname + "')";
            MySqlCommand command = new MySqlCommand(inputString, sqlConn);

            MessageBox.Show("Search Results ");





        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            btnAddPatient.Visible = false;
            grpAdd.Visible = true;
            grpSeachResults.Visible = false;
            grpOptions1.Visible = false;
            grpSearch.Visible = false;
            grpExit.Visible = false;


        }

        private void btnAllPatients_Click(object sender, EventArgs e)
        {
            
            grpSearch.Visible = false;
            grpSeachResults.Visible = false;
            grpAdd.Visible = false;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
           
            grpExit.Visible = false;


        }

        private void btnViewAllPats_Click(object sender, EventArgs e)
        {
            
            grpSearch.Visible = false;
            grpSeachResults.Visible = false;
            grpAdd.Visible = false;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpExit.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            grpOptions1.Visible = true;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            
            grpSearch.Visible = false;
            grpSeachResults.Visible = false;
            grpAdd.Visible = false;
            grpOptions1.Visible = true;
            grpOptions2.Visible = false;
            grpExit.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPatients_Click(object sender, EventArgs e)
        {

            
            grpSearch.Visible = false;
            grpSeachResults.Visible = false;
            grpAdd.Visible = false;
            grpOptions1.Visible = true;
            grpOptions2.Visible = false;
        }

        private void btnAddPat3_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = false;
           
            btnUpdate1.Visible = false;
        }

        

        private void btnAddPatientsOp1_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = false;
            
            btnUpdate1.Visible = false;
            grpExit.Visible = false;
        }

        private void btnUpdatePatDetails_Click(object sender, EventArgs e)
        {
            btnAddPatient.Visible = false;
            grpAdd.Visible = false;
            
            grpSeachResults.Visible = false;
            grpOptions1.Visible = false;
            grpSearch.Visible = true;
        }

        private void btnAddPat2_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = false;
           
            btnUpdate1.Visible = false;
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            grpAdd.Visible=false;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = true;
           
            grpSeachResults.Visible = false;

        }

        private void btnSearchPat2_Click(object sender, EventArgs e)
        {
            
            grpAdd.Visible = false;
            grpOptions1.Visible = false;
            grpOptions2.Visible = true;
            grpSearch.Visible = true;
           
            grpSeachResults.Visible = false;

        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            grpRoomAssignment.Visible = true;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            String idNumber = txtIDNum.Text;
            String name =txtName.Text;
            String Surname = txtSurname.Text;
            String Age = txtAge.Text;
            String Gender = cmbGender.ToString();
            Double Weight = Convert.ToDouble(txtWeight.Text);
            String Address = txtAddress.Text;
            String phoneNum = txtPhoneNum.Text;
            String password = txtPassword.Text;
            String Allergies = txtAllergies.Text;
            Double FeesPayable = Convert.ToDouble(txtFeesPayable.Text);



            string inputString = "call sp_AddPatient('" + idNumber + "','" + name + "','" + Surname + "','" + Age + "','" + Gender + "','" + Weight + "','" + Address + "' ,'" + phoneNum+ "','" + password + "','" + Allergies + "','" + FeesPayable + "')";
            MySqlCommand command = new MySqlCommand(inputString, sqlConn);


            MessageBox.Show(" Inserted Successfully ");

           


        }
    }
}
