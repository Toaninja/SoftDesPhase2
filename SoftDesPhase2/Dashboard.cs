using SoftDesPhase2Engine.Classes;
using SoftDesPhase2Engine.Classes.SoftDesPhase2Engine.Repositories;
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
            Customer John = new Customer(9999, "John", "John@gmail.com", "123 Street");

            Product Peas = new Product(1000, "Peas", "Green lil guys", 10.00, 30, Flavius);
            Product Carrots = new Product(2000, "Carrots", "Pointy guys", 5.00, 60, Lance);
            Product Broccoli = new Product(3000, "Broccoli", "Cauliflower but worse", 10.00, 90, Flavius);
            Product SunflowerSeeds = new Product(4000, "Sunflower Seeds", "Healthy snacks", 5.00, 100, Flavius);

            RatingRepository ratingRepository = new RatingRepository();
            Ratings CarrotReview1 = new Ratings(ratingRepository, 2000, 10, "Not orange enough", DateTime.Today, John, Carrots);
            Ratings CarrotReview2 = new Ratings(ratingRepository, 2000, 9, "Tastes like dirt", DateTime.Today, John, Carrots);
            Ratings CarrotReview3 = new Ratings(ratingRepository, 2000, 7, "Splendid", DateTime.Today, John, Carrots);
            Ratings CarrotReview4 = new Ratings(ratingRepository, 2000, 3, "Mid", DateTime.Today, John, Carrots);

            CarrotReview1.AddRating();
            CarrotReview2.AddRating();
            CarrotReview3.AddRating();
            CarrotReview4.AddRating();

            Ratings PeaReveiw1 = new Ratings(ratingRepository, 1000, 1, "Splendid", DateTime.Today, John, Peas);
            Ratings PeaReveiw2 = new Ratings(ratingRepository, 1000, 2, "Tastes like dirt", DateTime.Today, John, Peas);
            Ratings PeaReveiw3 = new Ratings(ratingRepository, 1000, 3, "Splendid", DateTime.Today, John, Peas);
            Ratings PeaReveiw4 = new Ratings(ratingRepository, 1000, 4, "Mid", DateTime.Today, John, Peas);

            PeaReveiw1.AddRating();
            PeaReveiw2.AddRating();
            PeaReveiw3.AddRating();
            PeaReveiw4.AddRating();

            Ratings BroccoliReview1 = new Ratings(ratingRepository, 3000, 5, "Tastes like dirt", DateTime.Today, John, Broccoli);
            Ratings BroccoliReview2 = new Ratings(ratingRepository, 3000, 6, "Tastes like dirt", DateTime.Today, John, Broccoli);
            Ratings BroccoliReview3 = new Ratings(ratingRepository, 3000, 7, "Splendid", DateTime.Today, John, Broccoli);
            Ratings BroccoliReview4 = new Ratings(ratingRepository, 3000, 10, "Mid", DateTime.Today, John, Broccoli);

            BroccoliReview1.AddRating();
            BroccoliReview2.AddRating();
            BroccoliReview3.AddRating();
            BroccoliReview4.AddRating();

            Ratings SeedReveiw1 = new Ratings(ratingRepository, 4000, 10, "The harvest was plentiful", DateTime.Today, John, SunflowerSeeds);
            Ratings SeedReveiw2 = new Ratings(ratingRepository, 4000, 3, "Tastes like dirt", DateTime.Today, John, SunflowerSeeds);
            Ratings SeedReveiw3 = new Ratings(ratingRepository, 4000, 1, "Splendid", DateTime.Today, John, SunflowerSeeds);
            Ratings SeedReveiw4 = new Ratings(ratingRepository, 4000, 1, "Mid", DateTime.Today, John, SunflowerSeeds);

            SeedReveiw1.AddRating();
            SeedReveiw2.AddRating();
            SeedReveiw3.AddRating();
            SeedReveiw4.AddRating();

            textBox2.AppendText("Average Rating: " + ratingRepository.GetAverageRating(Carrots).ToString("0.00") + Environment.NewLine);
            textBox3.AppendText("Average Rating: " + ratingRepository.GetAverageRating(Broccoli).ToString("0.00") + Environment.NewLine);
            textBox4.AppendText("Average Rating: " + ratingRepository.GetAverageRating(Peas).ToString("0.00") + Environment.NewLine);
            textBox5.AppendText("Average Rating: " + ratingRepository.GetAverageRating(SunflowerSeeds).ToString("0.00") + Environment.NewLine);

            textBox2.AppendText("Recent Review: " + CarrotReview1.Comment);
            textBox3.AppendText("Recent Review: " + BroccoliReview1.Comment);
            textBox4.AppendText("Recent Review: " + PeaReveiw1.Comment);
            textBox5.AppendText("Recent Review: " + SeedReveiw1.Comment);

            List<Order> MyList = new List<Order>() { };
            double TotalEarnings = Lance.CalculateEarnings(Lance, MyList);
            textBox6.AppendText("Total Earnings: $" + TotalEarnings.ToString("0.00"));


        }
    }
}
