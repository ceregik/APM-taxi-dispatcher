using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kys
{
    public partial class AddDis : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginA.mdb;";

        private OleDbConnection myConnection;

        public AddDis()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                 string LOG = login.Text;

                 string p = "SELECT login FROM LoginA WHERE NOT login ='" + LOG + "'";

                 OleDbCommand commandt = new OleDbCommand(p, myConnection);

                if (LOG != commandt.ExecuteScalar().ToString())
                {
                        string FN = fname.Text;
                        string SN = sname.Text;
                        string PAS = password.Text;

                        string insert = "INSERT INTO LoginA ([Login],[Password],[Fname],[Sname]) VALUES( '" + LOG + "', '" + PAS + "', '" + FN + "', '" + SN + "' )";

                        OleDbCommand command = new OleDbCommand(insert, myConnection);

                        command.ExecuteNonQuery();

                        this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Введите данные во все строки или выберите другой логин.", "Ошибка");
            }
        }

        private void AddDis_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
