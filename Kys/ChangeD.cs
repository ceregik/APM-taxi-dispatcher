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
    public partial class ChangeD : Form
    {
        public static string connectD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Drivers.mdb;";

        private OleDbConnection myConnectionD;

        public ChangeD()
        {
            myConnectionD = new OleDbConnection(connectD);

            myConnectionD.Open();

            InitializeComponent();
        }

        private void ChangeD_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionD.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeD_Load(object sender, EventArgs e)
        {
            string comD = "SELECT fname FROM Drivers WHERE код = " + fname.Value3;

            OleDbCommand commandD = new OleDbCommand(comD, myConnectionD);

            textBox1.Text = commandD.ExecuteScalar().ToString();

            comD = "SELECT Sname FROM Drivers WHERE код = " + fname.Value3;

            commandD = new OleDbCommand(comD, myConnectionD);

            textBox2.Text = commandD.ExecuteScalar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string FN = textBox1.Text;
                string SN = textBox2.Text;

                string insert = "UPDATE Drivers SET [Fname]='" + FN + "',[Sname]='" + SN + "' WHERE код = " + fname.Value3;

                OleDbCommand command = new OleDbCommand(insert, myConnectionD);

                command.ExecuteNonQuery();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите данные во все строки", "Ошибка");
            }
        }
    }
}
