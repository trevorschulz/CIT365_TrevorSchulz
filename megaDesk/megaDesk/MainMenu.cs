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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var viewQuotes = new ViewAllQuotes();
            viewQuotes.Show();
        }

        private void addquote_Click(object sender, EventArgs e)
        {
            var addQuotes = new AddQuotes();
            addQuotes.Show();
        }

        private void searchQuote_Click(object sender, EventArgs e)
        {
            var searchQuotes = new SearchQuotes();
            searchQuotes.Show();
        }
    }
}
