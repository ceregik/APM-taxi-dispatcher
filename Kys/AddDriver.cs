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
    public partial class AddDriver : Form
    {
        public static string connectD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Drivers.mdb;";

        private OleDbConnection myConnectionD;

        public AddDriver()
        {
            InitializeComponent();

            myConnectionD = new OleDbConnection(connectD);

            myConnectionD.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sn = Sname.Text;
                string fn = Fname.Text;

                string insert = "INSERT INTO Drivers(Sname,Fname) VALUES( '" + sn + "', '" + fn + "')";

                OleDbCommand command = new OleDbCommand(insert, myConnectionD);

                command.ExecuteNonQuery();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Пожалуйста введите данные во все строки.", "Ошибка");
            }
        }

        private void AddDriver_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionD.Close();
        }
    }
}
