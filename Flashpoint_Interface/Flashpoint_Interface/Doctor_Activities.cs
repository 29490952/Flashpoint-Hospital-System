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
        string docID, docName, docSurname, patientID, admissionID;
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
            try
            {
                DateTime vPrescribedTime = new DateTime();
                vPrescribedTime = DateTime.Now;

                string vSubscript = rtxtSubscript.Text;
                string vDrugs = cmbDrugs.SelectedItem.ToString();
                string vPurpose = rtxtReason.Text;
                string vSigna = rtxtSigna.Text;

                Random rnd = new Random();
                int prescriptionID = rnd.Next(10000000, 99999999);

                string inputString = "call sp_MakePresciption('" + prescriptionID + "', '" + patientID + "','" + docID + "','" + vDrugs + "','" + vPrescribedTime + "','" + vPurpose + "','" + vSubscript + "','" + vSigna + "' )";
                MySqlCommand command = new MySqlCommand(inputString, sqlConn);

                MessageBox.Show("command == INSERT Successful ");

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

	    private void btnRecordOp_Click(object sender, EventArgs e)
	    {
            Random random = new Random();
		    lstPatient_Report_DerivedFrom_MakePrescription.Visible = true;

		    string deptID = cmbDepID.SelectedValue.ToString();
		    string docInvolved = rtxtDocsInvolved.Text;
		    string opPreCondition = txtPreOpCon.Text;
		    string opPostCondition = txtPostOpCon.Text;
		    string opStartTime = txtStartTime.Text;
		    string opEndTime = txtEndTime.Text;
		    string opDescription = rtxtOpDescript.Text;

            admissionID = random.Next(00000000, 99999999).ToString();
            MySqlCommand cmd = new MySqlCommand("CALL sp_RecordOperation('"+deptID+"', '"+admissionID+"', '"+ docInvolved + "', " +
                                            "'"+ opPreCondition + "', '"+ opPostCondition + "', '"+ opStartTime + "', '"+ opEndTime + "'," +
                                            " '"+ opDescription + "')", sqlConn);
	    }
        
        private void btnReferToOperate_Click(object sender, EventArgs e)
        {
            tabConDocActiv.SelectedIndex = 3;
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
