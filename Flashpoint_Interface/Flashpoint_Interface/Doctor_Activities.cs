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
		//string myConnString = "server=localhost; User ID=root; Password=fL@$##0$P_db; Database=flashpointhospital_db";

        //VARIABLES 
        string docName, docSurname, docDepart;

		public Doctor_Activities(MySqlConnection connSql, string DocName, string DocSurname)
        {
            InitializeComponent();

            sqlConn = connSql;
            docName = DocName;
            docSurname = DocSurname;
        }

        private void Doctor_Activities_Load(object sender, EventArgs e)
        {
            lblDocIDAndName.Text = "Welcome Doctor " + docName + " " + docSurname;
        }
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			
			string insertQuery = "INSERT INTO flashPointhospital_db(Superscription,listOfDrugs,therapeuticReason,signa,operationChecked,Credential) VALUES('" + txtSuperscription.Text + "','" + cmbDrugs.Text + "','" + txtReason.Text + "','" + txtSigna.Text + "','" + chkOperation.Checked+ "','" + txtCredentials.Text + "',)";
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
 
        private void tbPgWelcome_Click(object sender, EventArgs e)
        {

        }

        private void tbPgAppoint_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
		{
			groupDrugs.Visible = true;
			chkOperation.Visible = true;
			groupONames.Visible = true;

		}

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
