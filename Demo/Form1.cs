using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtRecommendation.Multiline = true;
            txtRecommendation.Font = new System.Drawing.Font("Mongolian Baiti", 12);
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string skinType = cboSkinType.SelectedItem.ToString();
            int age = (int)numAge.Value;


            string recommendation = GetSkincareRecommendation(skinType, age);

            
            txtRecommendation.Text = recommendation;
        }

        private string GetSkincareRecommendation(string skinType, int age)
        {
            string recommendation = "";

            
            switch (skinType)
            {
                case "Oily":
                    recommendation = "• Cleanser: Gel-based, Neutrogena Oil-Free Acne Wash\n";
                    recommendation += "• Toner: Alcohol-free, Thayers Witch Hazel\n";
                    recommendation += "• Moisturizer: Oil-free, Clinique Dramatically Different Gel\n";
                    recommendation += "• Sunscreen: Broad-spectrum SPF 30+, EltaMD UV Clear SPF 46\n";
                    break;
                case "Dry":
                    recommendation = "• Cleanser: Cream-based, CeraVe Hydrating Cleanser\n";
                    recommendation += "• Toner: Hydrating, Klairs Supple Preparation Unscented Toner\n";
                    recommendation += "• Moisturizer: Rich and creamy, Neutrogena Hydro Boost Water Gel\n";
                    recommendation += "• Sunscreen: Hydrating SPF 30+, La Roche-Posay Anthelios Melt-in Sunscreen\n";
                    break;
                case "Combination":
                    recommendation = "• Cleanser: Gentle foaming, Cetaphil Daily Facial Cleanser\n";
                    recommendation += "• Toner: Alcohol-free, Paula's Choice Enriched Calming Toner\n";
                    recommendation += "• Moisturizer: Light, non-greasy, Olay Regenerist Whip\n";
                    recommendation += "• Sunscreen: Broad-spectrum SPF 30+, Neutrogena Hydro Boost Water Gel SPF 30\n";
                    break;
                case "Sensitive":
                    recommendation = "• Cleanser: Hypoallergenic, fragrance-free, Vanicream Gentle Facial Cleanser\n";
                    recommendation += "• Toner: Alcohol-free, Bioderma Sensibio Toner\n";
                    recommendation += "• Moisturizer: Calming and soothing, Aveeno Ultra-Calming Daily Moisturizer\n";
                    recommendation += "• Sunscreen: Mineral sunscreen SPF 30+, EltaMD UV Physical SPF 41\n";
                    break;
                default:
                    return "Sorry, we couldn't identify your skin type. Please try again with valid input (Oily, Dry, Combination, Sensitive).";
            }

            if (age < 18)
            {
                recommendation += "\nAdditional Advice for Younger Skin:\n";
                recommendation += "• Focus on a simple routine, avoid heavy products, and always use sunscreen!\n";
            }
            else if (age >= 18 && age <= 35)
            {
                recommendation += "\nAdditional Advice for Ages 18-35:\n";
                recommendation += "• It's important to prevent signs of aging early. Consider adding a vitamin C serum in the morning.\n";
            }
            else if (age > 35 && age <= 50)
            {
                recommendation += "\nAdditional Advice for Ages 35-50:\n";
                recommendation += "• As skin begins to show signs of aging, consider incorporating a retinol or anti-aging serum into your routine.\n";
            }
            else if (age > 50)
            {
                recommendation += "\nAdditional Advice for Mature Skin:\n";
                recommendation += "• Focus on hydration and anti-aging ingredients like hyaluronic acid, peptides, and retinol.\n";
            }

            return recommendation;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            
            string skinType = cboSkinType.SelectedItem.ToString(); 
            int age = (int)numAge.Value; 

          
            string recommendation = GetSkincareRecommendation(skinType, age);

           
            txtRecommendation.Text = recommendation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
