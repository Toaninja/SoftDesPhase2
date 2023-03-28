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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftDesPhase2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductListing newForm = new ProductListing();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Farmer Flavius = new Farmer("Flavius", "Phone", "Ontario", "Small farm");
            Farmer Lance = new Farmer("Lance", "Phone", "Ontario", "Big farm");
            Product Peas = new Product(123, "Peas", "Green lil guys", 10.00, 30, Flavius);
            Product Carrots = new Product(123, "Carrots", "Pointy guys", 5.00, 60, Lance);
            Product Tomatoes = new Product(123, "Tomatoes", "Round red fellas", 15.00, 100, Lance);
            Product Potatoes = new Product(123, "Potatoes", "Healthy brownies", 20.00, 50, Flavius);
            Product Lettuce = new Product(123, "Lettuce", "Green leafy guys", 10.00, 40, Lance);
            Product Cucumber = new Product(123, "Cucumber", "Green pointy guys", 20.00, 75, Flavius);
            Product Cauliflower = new Product(123, "Cauliflower", "Broccoli but better", 15.00, 80, Lance);
            Product Broccoli = new Product(123, "Broccoli", "Cauliflower but worse", 10.00, 90, Flavius);
            Product SunflowerSeeds = new Product(123, "Sunflower Seeds", "Healthy snacks", 5.00, 100, Flavius);


            textBox2.AppendText(Peas.Description + Environment.NewLine);
            textBox2.AppendText("Price: $" + Peas.Price.ToString() + Environment.NewLine);
            textBox2.AppendText("Quantity: " + Peas.Quantity.ToString() + " left" + Environment.NewLine);
            textBox2.AppendText("Seller: " + Peas.Seller.Name);
            
            textBox3.AppendText(Carrots.Description + Environment.NewLine);
            textBox3.AppendText("Price: $" + Carrots.Price.ToString() + Environment.NewLine);
            textBox3.AppendText("Quantity: " + Carrots.Quantity.ToString() + " left" + Environment.NewLine);
            textBox3.AppendText("Seller: " + Carrots.Seller.Name);

            textBox4.AppendText(Broccoli.Description + Environment.NewLine);
            textBox4.AppendText("Price: $" + Broccoli.Price.ToString() + Environment.NewLine);
            textBox4.AppendText("Quantity: " + Broccoli.Quantity.ToString() + " left" + Environment.NewLine);
            textBox4.AppendText("Seller: " + Broccoli.Seller.Name);

            textBox5.AppendText(Cauliflower.Description + Environment.NewLine);
            textBox5.AppendText("Price: $" + Cauliflower.Price.ToString() + Environment.NewLine);
            textBox5.AppendText("Quantity: " + Cauliflower.Quantity.ToString() + " left" + Environment.NewLine);
            textBox5.AppendText("Seller: " + Cauliflower.Seller.Name); 
            
            textBox6.AppendText(Potatoes.Description + Environment.NewLine);
            textBox6.AppendText("Price: $" + Potatoes.Price.ToString() + Environment.NewLine);
            textBox6.AppendText("Quantity: " + Potatoes.Quantity.ToString() + " left" + Environment.NewLine);
            textBox6.AppendText("Seller: " + Potatoes.Seller.Name);

        }
    }
}
