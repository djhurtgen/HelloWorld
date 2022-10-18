using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listCity.GetItemText(listCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            String name = textName.Text;
            String address = textAddress.Text;
            MessageBox.Show(name + " " + address);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Object[] dataGridViewRowObject1 = new Object[] { "001", "Hurtgen", "David", "Active" };
            Object[] dataGridViewRowObject2 = new Object[] { "002", "Goetz", "Emma", "Inactive" };
            Object[] dataGridViewRowObject3 = new Object[] { "003", "Perry", "Nate", "Overdue" };
            Object[] dataGridViewRowObject4 = new Object[] { "004", "Panosky", "Renaldin", "Frozen" };

            dataGridView1.Rows.Add(dataGridViewRowObject1);
            dataGridView1.Rows.Add(dataGridViewRowObject2);
            dataGridView1.Rows.Add(dataGridViewRowObject3);
            dataGridView1.Rows.Add(dataGridViewRowObject4);
        }
    }
}
