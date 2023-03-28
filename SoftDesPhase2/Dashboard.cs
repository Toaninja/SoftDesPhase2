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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage newForm = new HomePage();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductListing newForm = new ProductListing();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShoppingCart newForm = new ShoppingCart();
            newForm.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Farmer Lance = new Farmer("Lance", "Phone", "Ontario", "Big farm");
            Farmer Flavius = new Farmer("Flavius", "Phone", "Ontario", "Small farm");

            Product Peas = new Product(123, "Peas", "Green lil guys", 10.00, 30, Flavius);
            Product Carrots = new Product(123, "Carrots", "Pointy guys", 5.00, 60, Lance);
            Product Tomatoes = new Product(123, "Tomatoes", "Round red fellas", 15.00, 100, Lance);
            Product Potatoes = new Product(123, "Potatoes", "Healthy brownies", 20.00, 50, Flavius);
            Product Lettuce = new Product(123, "Lettuce", "Green leafy guys", 10.00, 40, Lance);
            Product Cucumber = new Product(123, "Cucumber", "Green pointy guys", 20.00, 75, Flavius);
            Product Cauliflower = new Product(123, "Cauliflower", "Broccoli but better", 15.00, 80, Lance);
            Product Broccoli = new Product(123, "Broccoli", "Cauliflower but worse", 10.00, 90, Flavius);
            Product SunflowerSeeds = new Product(123, "Sunflower Seeds", "Healthy snacks", 5.00, 100, Flavius);
        }
    }
}
