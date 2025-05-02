using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairManagementSystem
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            
            // Create carousel timer
            System.Windows.Forms.Timer carouselTimer = new System.Windows.Forms.Timer();
            carouselTimer.Interval = 3000; // 3 seconds
            carouselTimer.Tick += CarouselTimer_Tick;
            carouselTimer.Start();
            
            // Initialize feature images
            LoadFeatureImages();
            
            // Set the current carousel index
            currentCarouselIndex = 0;
            UpdateCarouselDisplay();
        }

        private int currentCarouselIndex;
        private List<CarouselItem> carouselItems = new List<CarouselItem>();

        private void LoadFeatureImages()
        {
            // Create placeholder images and text for the carousel
            carouselItems.Add(new CarouselItem(
                CreateFeatureImage(Color.RoyalBlue, "CONNECT"),
                "Connect with Top Companies",
                "Access hundreds of job opportunities from leading companies in tech, finance, healthcare, and more."
            ));
            
            carouselItems.Add(new CarouselItem(
                CreateFeatureImage(Color.ForestGreen, "GROW"),
                "Grow Your Career",
                "Build your professional network, receive mentorship, and find the perfect job to advance your career."
            ));
            
            carouselItems.Add(new CarouselItem(
                CreateFeatureImage(Color.DarkOrange, "LEARN"),
                "Learn New Skills",
                "Attend workshops, seminars, and training sessions offered at our job fairs to enhance your skillset."
            ));
        }

        private Bitmap CreateFeatureImage(Color backgroundColor, string text)
        {
            Bitmap featureImage = new Bitmap(600, 300);
            using (Graphics g = Graphics.FromImage(featureImage))
            {
                // Fill background
                g.Clear(backgroundColor);
                
                // Add some decorative elements
                using (SolidBrush lightBrush = new SolidBrush(Color.FromArgb(50, Color.White)))
                {
                    g.FillEllipse(lightBrush, -100, -100, 300, 300);
                    g.FillEllipse(lightBrush, 400, 150, 300, 300);
                }
                
                // Add text
                using (Font font = new Font("Arial", 36, FontStyle.Bold))
                {
                    SizeF textSize = g.MeasureString(text, font);
                    g.DrawString(text, font, Brushes.White, 
                        (featureImage.Width - textSize.Width) / 2,
                        (featureImage.Height - textSize.Height) / 2);
                }
            }
            return featureImage;
        }

        private void CarouselTimer_Tick(object sender, EventArgs e)
        {
            // Move to the next carousel item
            currentCarouselIndex = (currentCarouselIndex + 1) % carouselItems.Count;
            UpdateCarouselDisplay();
        }

        private void UpdateCarouselDisplay()
        {
            CarouselItem currentItem = carouselItems[currentCarouselIndex];
            picFeature.Image = currentItem.Image;
            lblFeatureTitle.Text = currentItem.Title;
            lblFeatureDescription.Text = currentItem.Description;
            
            // Update indicator dots
            pnlIndicators.Controls.Clear();
            for (int i = 0; i < carouselItems.Count; i++)
            {
                Panel dot = new Panel
                {
                    Size = new Size(12, 12),
                    Margin = new Padding(5, 0, 5, 0),
                    BackColor = i == currentCarouselIndex ? Color.White : Color.FromArgb(150, 255, 255, 255)
                };
                pnlIndicators.Controls.Add(dot);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.FormClosed += (s, args) => this.Show();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void lnkUpcomingFairs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This would display the list of upcoming job fairs.", 
                "Upcoming Job Fairs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("CareerConnect is a comprehensive Job Fair Management System " +
                "designed to connect students with potential employers. " +
                "Our platform provides an easy way to discover, register for, and " +
                "participate in job fairs at your university.", 
                "About CareerConnect", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("For any inquiries, please contact:\n\nEmail: support@careerconnect.edu\nPhone: (123) 456-7890", 
                "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Helper class for carousel items
    public class CarouselItem
    {
        public Image Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public CarouselItem(Image image, string title, string description)
        {
            Image = image;
            Title = title;
            Description = description;
        }
    }
} 