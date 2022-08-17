using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView2
{
    public partial class Form1 : Form
    {
        int init;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text);


            

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            if (dataGridView1.Rows.Count == 0)
            {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox5.Text;
            }
;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            

           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
