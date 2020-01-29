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
    public partial class ChangeL : Form
    {
        public static string connectL = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginA.mdb;";

        private OleDbConnection myConnectionL;

        public ChangeL()
        {
            myConnectionL = new OleDbConnection(connectL);

            myConnectionL.Open();

            InitializeComponent();
        }

        private void ChangeL_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionL.Close();
        }

        private void ChangeL_Load(object sender, EventArgs e)
        {
            string comL = "SELECT fname FROM LoginA WHERE Login = " + '"' + fname.Value3 + '"';

            OleDbCommand commandL = new OleDbCommand(comL, myConnectionL);

            textBox1.Text= commandL.ExecuteScalar().ToString();

            comL = "SELECT Sname FROM LoginA WHERE Login = " + '"' + fname.Value3 + '"';

            commandL = new OleDbCommand(comL, myConnectionL);

            textBox2.Text = commandL.ExecuteScalar().ToString();

            comL = "SELECT login FROM LoginA WHERE Login = " + '"' + fname.Value3 + '"';

            commandL = new OleDbCommand(comL, myConnectionL);

            textBox3.Text = commandL.ExecuteScalar().ToString();

            comL = "SELECT password FROM LoginA WHERE Login = " + '"' + fname.Value3 + '"';

            commandL = new OleDbCommand(comL, myConnectionL);

            textBox4.Text = commandL.ExecuteScalar().ToString();

            comL = "SELECT admin FROM LoginA WHERE Login = " + '"' + fname.Value3 + '"';

            commandL = new OleDbCommand(comL, myConnectionL);

            string l = commandL.ExecuteScalar().ToString();

            if (l =="1")
            {
                checkBox1.Checked = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string FN = textBox1.Text;
                string SN = textBox2.Text;
                string LOG = textBox3.Text;
                string PAS = textBox4.Text;

                string insert = "UPDATE LoginA SET [Login]='" + LOG + "', [Password]='" + PAS + "',[Fname]='" + FN + "',[Sname]='" + SN + "' WHERE Login = '" + fname.Value3 + "'";

                OleDbCommand command = new OleDbCommand(insert, myConnectionL);

                command.ExecuteNonQuery();

                if (checkBox1.Checked == true)
                {
                    insert = "UPDATE LoginA SET [admin]=1 WHERE Login = '" + fname.Value3 + "'";

                    command = new OleDbCommand(insert, myConnectionL);

                    command.ExecuteNonQuery();
                }
                else
                {

                    insert = "UPDATE LoginA SET [admin]=0 WHERE Login = '" + fname.Value3 + "'";

                    command = new OleDbCommand(insert, myConnectionL);

                    command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите данные во все строки или выберите другой логин.", "Ошибка");
            }
        }
    }
}
