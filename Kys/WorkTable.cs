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
    public partial class WorkTable : Form
    {

        private void update()
        {
            dataGridView1.Rows.Clear();

            string com = "SELECT * FROM Client WHERE NOT status='Выполнен' ORDER bY Number";

            OleDbCommand command = new OleDbCommand(com, myConnectionC);

            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[10]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            dataGridView2.Rows.Clear();

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
                dataGridView2.Rows.Add(s);
        }

        public static string connectC = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Client.mdb;";
        public static string connectD = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Drivers.mdb;";

        private OleDbConnection myConnectionC;
        private OleDbConnection myConnectionD;

         
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("yyyy.MM.dd, HH.mm.ss");
        }

        public WorkTable()
        {
            InitializeComponent();

            button1.DialogResult = DialogResult.OK;

            myConnectionC = new OleDbConnection(connectC);

            myConnectionC.Open();

            myConnectionD = new OleDbConnection(connectD);

            myConnectionD.Open();

               label6.Text = DateTime.Now.ToString("yyyy.MM.dd, HH.mm.ss");
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void WorkTable_Load(object sender, EventArgs e)
        {
            update();

            label4.Text = fname.Value;
            label3.Text = fname.Value2;

        }
        
        private void WorkTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnectionC.Close();

            myConnectionD.Close();

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddClient newForm = new AddClient();

                newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string num = Del.Text;

                string comdel = "DELETE FROM Client WHERE number = " + num;

                OleDbCommand commanddel = new OleDbCommand(comdel, myConnectionC);

                commanddel.ExecuteNonQuery();

                update();
            }
            catch
            {
                MessageBox.Show("Для удаления, пожалуйста введите номер заказа.", "Ошибка");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    string num = Del.Text;

                    string comup1 = "UPDATE Client SET status='Ожидается' WHERE number = " + num;

                    OleDbCommand commandup1 = new OleDbCommand(comup1, myConnectionC);

                    commandup1.ExecuteNonQuery();
                    update();
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста введите номер заказа.", "Ошибка");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton2.Checked == true)
                {
                    string num = Del.Text;

                    string comup2 = "UPDATE Client SET status='Выполняется' WHERE number = " + num;

                    OleDbCommand commandup2 = new OleDbCommand(comup2, myConnectionC);

                    commandup2.ExecuteNonQuery();
                    update();
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста введите номер заказа.", "Ошибка");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton3.Checked == true)
                {
                    string num = Del.Text;

                    string comup2 = "UPDATE Client SET status='Выполнен' WHERE number = " + num;

                    OleDbCommand commandup2 = new OleDbCommand(comup2, myConnectionC);

                    commandup2.ExecuteNonQuery();
                    update();
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста введите  номер заказа.", "Ошибка");
            }
        }

        private void Del_TextChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
