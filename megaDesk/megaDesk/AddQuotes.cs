using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaDesk
{
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
            this.comboBox1.Items.AddRange(new object[] {"laminate",
                        "oak",
                        "rosewood",
                        "veneer",
                        "pine"});
            this.comboBox2.Items.AddRange(new object[] {"Normal (14 Days)",
                        "3 Days",
                        "5 Days",
                        "7 Days"});
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = 7;
            numericUpDown1.Minimum = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void submitQuote_Click(object sender, EventArgs e)
        {

        }

        private void AddQuotes_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            string custName;
           
        }
    }
}
