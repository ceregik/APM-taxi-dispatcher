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
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=LoginA.mdb;";

        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = log.Text;
            string password = pas.Text;

            string comL = "SELECT admin FROM LoginA WHERE Login = " + '"' + login + '"' + " and Password =" + '"' + password + '"';
            string Fname = "SELECT fname FROM LoginA WHERE Login = " + '"' + login + '"' + " and Password =" + '"' + password + '"';
            string Sname = "SELECT sname FROM LoginA WHERE Login = " + '"' + login + '"' + " and Password =" + '"' + password + '"';


            OleDbCommand commandL = new OleDbCommand(comL, myConnection);
            OleDbCommand commandFname = new OleDbCommand(Fname, myConnection);
            OleDbCommand commandSname = new OleDbCommand(Sname, myConnection);
            try
            {
                string name = commandL.ExecuteScalar().ToString();
                fname.Value = commandFname.ExecuteScalar().ToString();
                fname.Value2 = commandSname.ExecuteScalar().ToString();
                if (name == "0")
                {
                    WorkTable newForm = new WorkTable();
                    this.Hide();
                    if (newForm.ShowDialog() == DialogResult.OK)
                        this.Show();
                    log.Text = "";
                    pas.Text = "";

                } else

                {
                    WorkTableA newForm = new WorkTableA();
                    this.Hide();
                    if (newForm.ShowDialog() == DialogResult.OK)
                        this.Show();
                    log.Text = "";
                    pas.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка");
            }
            
        }
    }
}
