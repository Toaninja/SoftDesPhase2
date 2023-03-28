using SoftDesPhase2Engine.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftDesPhase2
{
    public partial class ProductListing : Form
    {
        public ProductListing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage newForm = new HomePage();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard newForm = new Dashboard();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShoppingCart newForm = new ShoppingCart();
            newForm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductListing_Load(object sender, EventArgs e)
        {

        }
    }
}
