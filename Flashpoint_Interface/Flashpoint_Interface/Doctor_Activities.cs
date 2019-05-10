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
        public partial class Doctor_Activities : Form
        {
            //SQL CONNECTION
            MySqlConnection sqlConn = new MySqlConnection();
        
            //VARIABLES 
            string docID, docName, docSurname, patientID;
            public Doctor_Activities(MySqlConnection connSql, string DocID, string DocName, string DocSurname)
            {
                InitializeComponent();

                sqlConn = connSql;
                docID = DocID;
                docName = DocName;
                docSurname = DocSurname;
            }

            private void Doctor_Activities_Load(object sender, EventArgs e)
            {
                lblDocIDAndName.Text = "Welcome Doctor " + docName + " " + docSurname;

            }
            private void btnSubmit_Click(object sender, EventArgs e)
            {

                string insertQuery = "INSERT INTO flashPointhospital_db(Superscription,listOfDrugs,therapeuticReason,signa,operationChecked,Credential) VALUES('" + txtSuperscription.Text + "','" + cmbDrugs.Text + "','" + txtReason.Text + "','" + txtSigna.Text + "','" + chkOperation.Checked + "','" + txtCredentials.Text + "',)";
                sqlConn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(insertQuery, sqlConn);
                try
                {
                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data not Inserted");

                    }
                }
                catch (MySqlException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            private void tbPgAppoint_Click(object sender, EventArgs e)
            {
            }

        private void selectedIndex(object sender, EventArgs e)
        {
            if (tabConDocActiv.SelectedIndex == 1)
            {
                try
                {
                    sqlConn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("CALL sp_DocAppointments('" + docID + "')", sqlConn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "appointment");

                    dataGrid_checkAppoint.DataSource = ds;
                    dataGrid_checkAppoint.DataMember = "appointment";

                    sqlConn.Close();
                }
                catch (MySqlException er)
                {

                }
            }
        }

        private void btnMakePrescript_Click(object sender, EventArgs e)
        {
            tabConDocActiv.SelectedIndex = 2;
        }

        private void dataGrid_checkAppoint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblStorePatID.Visible = true;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGrid_checkAppoint.Rows[rowIndex];
            lblStorePatID.Text = "Make Prescription for: " + row.Cells[2].Value + " " + row.Cells[3].Value + " " + row.Cells[8].Value;

            patientID = row.Cells[8].Value.ToString();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            groupDrugs.Visible = true;
            chkOperation.Visible = true;
            groupONames.Visible = true;
            DateTime vPrescribedTime = new DateTime();
            vPrescribedTime = DateTime.Now;


            string vSubscript = txtSuperscription.Text;
            string vDrugs = cmbDrugs.SelectedItem.ToString();
            string vPurpose = txtReason.Text;
            string vSigna = txtSigna.Text;


            string inputString = "call sp_MakePresciption('"+patientID+ "','" +docID + "','" +vDrugs+ "','" + vPrescribedTime + "','" +vPurpose+ "','" +vSubscript+ "','" +vSigna+ "' )";
            MySqlCommand command = new MySqlCommand(inputString,sqlConn);

            MessageBox.Show("command == INSERT Successful ");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
