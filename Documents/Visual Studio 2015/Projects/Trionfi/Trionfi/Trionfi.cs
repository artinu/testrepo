using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using engine;
using System.IO;
using System.Web.Script.Serialization;





namespace Trionfi
{
    public partial class Trionfi : Form
    {
        List<Cards> listCards;
        
        public Trionfi()
        {
            CardsLoader();
           InitializeComponent();
        }

        public void CardsLoader()
        {
            listCards = new List<Cards>();
            try
            {
                String JSONstring = File.ReadAllText("Cards_Description.json");
                String JSONstring1 = File.ReadAllText("Chakra_Description.json");
                JavaScriptSerializer ser = new JavaScriptSerializer();
                // listCards = ser.Deserialize<List<Cards>>(JSONstring);

                Cards test = ser.Deserialize<Cards>(JSONstring1);
                lCardHebrewLetter.Text = test.Descripton.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            Cards card0 = new Cards(1, "the fool", 1, "Air", "2", 2, "description");
            listCards.Add(card0);
        }

        private void pCardInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lHebrewLetter_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Cards card1 = listCards.First();
            lCardNum.Text = card1.Id.ToString();
            lCardNumercalValue.Text = card1.Numerical_Value.ToString();
        }
    }
}
