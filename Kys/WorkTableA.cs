using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kys
{
    public partial class WorkTableA : Kys.WorkTable
    {
        public WorkTableA()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDis newForm = new AddDis();

            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDriver newForm1 = new AddDriver();

            newForm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Change newForm2 = new Change();

            newForm2.Show();
        }
    }
}
