using SoftDesPhase2Engine.Classes;

namespace SoftDesPhase2
{
    public partial class ShoppingCart : Form
    {

        private bool infoDisplayed1, infoDisplayed2, infoDisplayed3, infoDisplayed4 = false;

        double button1Price, button2Price, button3Price, button4Price = 0;
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            
            textBox6.AppendText(Broccoli.Description + Environment.NewLine);
            textBox23.AppendText("$" + Broccoli.Price.ToString() + Environment.NewLine);
            textBox6.AppendText("Quantity: " + Broccoli.Quantity.ToString() + " left" + Environment.NewLine);
            textBox6.AppendText("Seller: " + Broccoli.Seller.Name);


            textBox7.AppendText(Carrots.Description + Environment.NewLine);
            textBox24.AppendText("$" + Carrots.Price.ToString() + Environment.NewLine);
            textBox7.AppendText("Quantity: " + Carrots.Quantity.ToString() + " left" + Environment.NewLine);
            textBox7.AppendText("Seller: " + Carrots.Seller.Name);

            textBox8.AppendText(Potatoes.Description + Environment.NewLine);
            textBox25.AppendText("$" + Potatoes.Price.ToString() + Environment.NewLine);
            textBox8.AppendText("Quantity: " + Potatoes.Quantity.ToString() + " left" + Environment.NewLine);
            textBox8.AppendText("Seller: " + Potatoes.Seller.Name);

            textBox9.AppendText(Peas.Description + Environment.NewLine);
            textBox26.AppendText("$" + Peas.Price.ToString() + Environment.NewLine);
            textBox9.AppendText("Quantity: " + Peas.Quantity.ToString() + " left" + Environment.NewLine);
            textBox9.AppendText("Seller: " + Peas.Seller.Name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!infoDisplayed1)
            {
                // display info only once from textBox2 to textBox10 when clicking on button1
                textBox12.AppendText(textBox3.Text + Environment.NewLine);
                infoDisplayed1 = true;

                // disable the TextBox to prevent further editing
                textBox12.Enabled = false;
                textBox12.ReadOnly = true;
            }

            button1Price += 5;
            textBox13.AppendText("$" + button1Price.ToString() + Environment.NewLine);
            textBox13.Clear();
            textBox13.AppendText("$" + button1Price.ToString() + Environment.NewLine);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!infoDisplayed2)
            {
                // display info only once from textBox2 to textBox10 when clicking on button1
                textBox10.AppendText(textBox2.Text + Environment.NewLine);
                infoDisplayed2 = true;

                // disable the TextBox to prevent further editing
                textBox10.Enabled = false;
                textBox10.ReadOnly = true;
            }

            button2Price += 10;
            
            textBox11.AppendText("$" + button2Price.ToString() + Environment.NewLine);
            textBox11.Clear();
            textBox11.AppendText("$" + button2Price.ToString() + Environment.NewLine);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            
            //erase contents from textBox10 when clicking on button5
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddToCart3_Click(object sender, EventArgs e)
        {
            if (!infoDisplayed3)
            {
                // display info only once from textBox2 to textBox10 when clicking on button1
                textBox14.AppendText(textBox4.Text + Environment.NewLine);
                infoDisplayed3 = true;

                // disable the TextBox to prevent further editing
                textBox14.Enabled = false;
                textBox14.ReadOnly = true;
            }

            button3Price += 50;

            textBox15.AppendText("$" + button3Price.ToString() + Environment.NewLine);
            textBox15.Clear();
            textBox15.AppendText("$" + button3Price.ToString() + Environment.NewLine);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddToCart4_Click(object sender, EventArgs e)
        {
            if (!infoDisplayed4)
            {
                // display info only once from textBox2 to textBox10 when clicking on button1
                textBox16.AppendText(textBox5.Text + Environment.NewLine);
                infoDisplayed4 = true;

                // disable the TextBox to prevent further editing
                textBox16.Enabled = false;
                textBox16.ReadOnly = true;
            }

            button4Price += 10;

            textBox17.AppendText("$" + button4Price.ToString() + Environment.NewLine);
            textBox17.Clear();
            textBox17.AppendText("$" + button4Price.ToString() + Environment.NewLine);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            HomePage newForm = new HomePage();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ProductListing newForm = new ProductListing();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Dashboard newForm = new Dashboard();
            newForm.Show();
            this.Hide();
        }
    }
}