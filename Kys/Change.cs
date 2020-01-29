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
    public partial class Change : Form
    {
        public static string connectL = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginA.mdb;";
        public static string connectD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Drivers.mdb;";

        private OleDbConnection myConnectionL;
        private OleDbConnection myConnectionD;

        public Change()
        {
            InitializeComponent();


            myConnectionL = new OleDbConnection(connectL);

            myConnectionL.Open();

            myConnectionD = new OleDbConnection(connectD);

            myConnectionD.Open();
        }

        private void Change_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionL.Close();

            myConnectionD.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string log = textBox1.Text;
            try
            {
                if (radioButton1.Checked == true)
                {
                    string comL = "SELECT login FROM LoginA WHERE Login = " + '"' + log + '"';

                    OleDbCommand commandL = new OleDbCommand(comL, myConnectionL);

                    fname.Value3 = commandL.ExecuteScalar().ToString();

                    ChangeL NFL = new ChangeL();

                    NFL.Show();
                }
                else
                {
                    string comD = "SELECT код FROM drivers WHERE код = "  + log ;

                    OleDbCommand commandD = new OleDbCommand(comD, myConnectionD);

                    fname.Value3 = commandD.ExecuteScalar().ToString();

                    ChangeD NFD = new ChangeD();

                    NFD.Show();
                }
            }
            catch
            {
                MessageBox.Show("Неверный логин или позывной.", "Ошибка");
            }
        }
    }
}
