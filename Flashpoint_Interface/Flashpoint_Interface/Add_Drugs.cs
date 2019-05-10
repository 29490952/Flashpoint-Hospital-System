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
      
    public partial class Add_Drugs : Form
    {
        MySqlConnection myConn = new MySqlConnection();
        public Add_Drugs()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
