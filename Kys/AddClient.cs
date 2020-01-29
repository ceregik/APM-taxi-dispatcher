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
    public partial class AddClient : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Client.mdb;";

        public static string connectD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Drivers.mdb;";

        private OleDbConnection myConnection;

        private OleDbConnection myConnectionD;

        public AddClient()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);

            myConnection.Open();

            myConnectionD = new OleDbConnection(connectD);

            myConnectionD.Open();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            string l = DateTime.Now.ToString("yyyy.MM.dd HH:mm");

            l = l.Replace(".","/");

            l = l.Replace(".", "/");

            TimeV.Text = l;

            dataGridView1.Rows.Clear();

            string comD = "SELECT * FROM Drivers";

            OleDbCommand commandD = new OleDbCommand(comD, myConnectionD);

            OleDbDataReader readerD = commandD.ExecuteReader();

            List<string[]> dataD = new List<string[]>();

            while (readerD.Read())
            {
                dataD.Add(new string[9]);

                dataD[dataD.Count - 1][0] = readerD[0].ToString();
                dataD[dataD.Count - 1][1] = readerD[1].ToString();
                dataD[dataD.Count - 1][2] = readerD[2].ToString();

            }

            readerD.Close();

            foreach (string[] s in dataD)
                dataGridView1.Rows.Add(s);
        }

        private void AddClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();

            myConnectionD.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string TV = TimeV.Text;
                string PS = PlaceS.Text;
                string PF = PlaceF.Text;
                string At = Abonent.Text;
                string Phe = Phone.Text;
                string Pre = Price.Text;
                string Dri = Driver.Text;

                string insert = "INSERT INTO Client(TimeV,PlaceS,PlaceF,Abonent,Phone,Price,Driver) VALUES( #" + TV + "#, '" + PS + "', '" + PF + "', '" + At + "', '" + Phe + "', '" + Pre + "', '" + Dri + "' )";

                OleDbCommand command = new OleDbCommand(insert, myConnection);

                command.ExecuteNonQuery();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Пожалуйста введите данные во все строки.", "Ошибка");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
