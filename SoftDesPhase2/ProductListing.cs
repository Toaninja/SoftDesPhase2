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

            textBox6.AppendText(Peas.Description + Environment.NewLine);
            textBox6.AppendText("Price: $" + Peas.Price.ToString() + Environment.NewLine);
            textBox6.AppendText("Quantity: " + Peas.Quantity.ToString() + Environment.NewLine);
            textBox6.AppendText("Seller: " + Peas.Seller.Name);

            textBox2.AppendText(Carrots.Description + Environment.NewLine);
            textBox2.AppendText("Price: $" + Carrots.Price.ToString() + Environment.NewLine);
            textBox2.AppendText("Quantity: " + Carrots.Quantity.ToString() + Environment.NewLine);
            textBox2.AppendText("Seller: " + Carrots.Seller.Name);

            textBox9.AppendText(Carrots.Description + Environment.NewLine);
            textBox9.AppendText("Price: $" + Carrots.Price.ToString() + Environment.NewLine);
            textBox9.AppendText("Quantity: " + Carrots.Quantity.ToString() + Environment.NewLine);
            textBox9.AppendText("Seller: " + Carrots.Seller.Name);

            textBox8.AppendText(Tomatoes.Description + Environment.NewLine);
            textBox8.AppendText("Price: $" + Tomatoes.Price.ToString() + Environment.NewLine);
            textBox8.AppendText("Quantity: " + Tomatoes.Quantity.ToString() + Environment.NewLine);
            textBox8.AppendText("Seller: " + Tomatoes.Seller.Name);

            textBox3.AppendText(Potatoes.Description + Environment.NewLine);
            textBox3.AppendText("Price: $" + Potatoes.Price.ToString() + Environment.NewLine);
            textBox3.AppendText("Quantity: " + Potatoes.Quantity.ToString() + Environment.NewLine);
            textBox3.AppendText("Seller: " + Potatoes.Seller.Name);

            textBox7.AppendText(Lettuce.Description + Environment.NewLine);
            textBox7.AppendText("Price: $" + Lettuce.Price.ToString() + Environment.NewLine);
            textBox7.AppendText("Quantity: " + Lettuce.Quantity.ToString() + Environment.NewLine);
            textBox7.AppendText("Seller: " + Lettuce.Seller.Name);

            textBox10.AppendText(Cucumber.Description + Environment.NewLine);
            textBox10.AppendText("Price: $" + Cucumber.Price.ToString() + Environment.NewLine);
            textBox10.AppendText("Quantity: " + Cucumber.Quantity.ToString() + Environment.NewLine);
            textBox10.AppendText("Seller: " + Cucumber.Seller.Name);

            textBox5.AppendText(Cauliflower.Description + Environment.NewLine);
            textBox5.AppendText("Price: $" + Cauliflower.Price.ToString() + Environment.NewLine);
            textBox5.AppendText("Quantity: " + Cauliflower.Quantity.ToString() + Environment.NewLine);
            textBox5.AppendText("Seller: " + Cauliflower.Seller.Name);

            textBox4.AppendText(Broccoli.Description + Environment.NewLine);
            textBox4.AppendText("Price: $" + Broccoli.Price.ToString() + Environment.NewLine);
            textBox4.AppendText("Quantity: " + Broccoli.Quantity.ToString() + Environment.NewLine);
            textBox4.AppendText("Seller: " + Broccoli.Seller.Name);

            textBox11.AppendText(SunflowerSeeds.Description + Environment.NewLine);
            textBox11.AppendText("Price: $" + SunflowerSeeds.Price.ToString() + Environment.NewLine);
            textBox11.AppendText("Quantity: " + SunflowerSeeds.Quantity.ToString() + Environment.NewLine);
            textBox11.AppendText("Seller: " + SunflowerSeeds.Seller.Name);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
