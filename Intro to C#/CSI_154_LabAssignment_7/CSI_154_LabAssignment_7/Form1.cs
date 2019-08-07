/* Author: Matthew Powers
* Date: 6/9/17
* Assignment: Lab Assignment 7
* Class: CSI 154
* Description: Creates a virtual vending machine, and displays the price, quantity, and total sales of the soft drinks
*/

using System;
using System.Windows.Forms;

namespace CSI_154_LabAssignment_7
{
    public partial class frmDrinkMachine : Form
    {
        public frmDrinkMachine()
        {
            InitializeComponent();
        }

        // Soft Drinks struct
        struct SoftDrinks
        {
            // Fields for the soda
            private string _drinkName;
            private decimal _drinkCost;
            private int _drinksLeft;

            // Getters and setters for the soda
            public string DrinkName
            {
                get { return _drinkName; }
                set { _drinkName = value; }
            }

            public decimal DrinkCost
            {
                get { return _drinkCost; }
                set { _drinkCost = value; }
            }

            public int DrinksLeft
            {
                get { return _drinksLeft; }
                set { _drinksLeft = value; }
            }

            // Explicit constuctor for the soda
            public SoftDrinks(string dName, decimal dCost, int dLeft)
            {
                _drinkName = dName;
                _drinkCost = dCost;
                _drinksLeft = dLeft;
            }
        }

        // Array of struts for the soda that store the information about the soda
        SoftDrinks[] drinkArray = new SoftDrinks[5]
            {
            new SoftDrinks("Cola", 1.00m, 20),
            new SoftDrinks("Root Beer", 1.00m, 20),
            new SoftDrinks("Lemon Lime", 1.00m, 20),
            new SoftDrinks("Grape", 1.50m, 20),
            new SoftDrinks("Cream Soda", 1.50m, 20)
            };

        // Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Total sales that keeps track of the money
        decimal totalSales = 0.00m;

        // When the cola picture box is clicked, if the number of drinks left is more than 0, it will subtract one from the total drinks, then update the sales, as well as the label for the cola
        private void picbxCola_Click(object sender, EventArgs e)
        {
            if (drinkArray[0].DrinksLeft > 0)
            {
                drinkArray[0].DrinksLeft = drinkArray[0].DrinksLeft - 1;
                lblDLeftCola.Text = Convert.ToString(drinkArray[0].DrinksLeft);
                totalSales += drinkArray[0].DrinkCost;
                lblTotalSales.Text = "$" + totalSales.ToString();
            }
            else
            {
                MessageBox.Show("ERROR! Out of drinks!");
            }
        }

        // When the root beer picture box is clicked, if the number of drinks left is more than 0, it will subtract one from the total drinks, then update the sales, as well as the label for the
        // root beer
        private void picbxRootBeer_Click(object sender, EventArgs e)
        {
            if (drinkArray[1].DrinksLeft > 0)
            {
                drinkArray[1].DrinksLeft = drinkArray[1].DrinksLeft - 1;
                lblDLeftRootBeer.Text = Convert.ToString(drinkArray[1].DrinksLeft);
                totalSales += drinkArray[1].DrinkCost;
                lblTotalSales.Text = "$" + totalSales.ToString();
            }
            else
            {
                MessageBox.Show("ERROR! Out of drinks!");
            }
        }

        // When the lemon lime picture box is clicked, if the number of drinks left is more than 0, it will subtract one from the total drinks, then update the sales, as well as the label for the
        // lemon lime
        private void picbxLemonLime_Click(object sender, EventArgs e)
        {
            if (drinkArray[2].DrinksLeft > 0)
            {
                drinkArray[2].DrinksLeft = drinkArray[2].DrinksLeft - 1;
                lblDLeftLemonLime.Text = Convert.ToString(drinkArray[2].DrinksLeft);
                totalSales += drinkArray[2].DrinkCost;
                lblTotalSales.Text = "$" + totalSales.ToString();
            }
            else
            {
                MessageBox.Show("ERROR! Out of drinks!");
            }
        }

        // When the grape soda picture box is clicked, if the number of drinks left is more than 0, it will subtract one from the total drinks, then update the sales, as well as the label for the
        // grape soda
        private void picbxGrapeSoda_Click(object sender, EventArgs e)
        {
            if (drinkArray[3].DrinksLeft > 0)
            {
                drinkArray[3].DrinksLeft = drinkArray[3].DrinksLeft - 1;
                lblDLeftGrapeSoda.Text = Convert.ToString(drinkArray[3].DrinksLeft);
                totalSales += drinkArray[3].DrinkCost;
                lblTotalSales.Text = "$" + totalSales.ToString();
            }
            else
            {
                MessageBox.Show("ERROR! Out of drinks!");
            }
        }

        // When the cream soda picture box is clicked, if the number of drinks left is more than 0, it will subtract one from the total drinks, then update the sales, as well as the label for the
        // cream soda
        private void picbxCreamSoda_Click(object sender, EventArgs e)
        {
            if (drinkArray[4].DrinksLeft > 0)
            {
                drinkArray[4].DrinksLeft = drinkArray[4].DrinksLeft - 1;
                lblDLeftCreamSoda.Text = Convert.ToString(drinkArray[4].DrinksLeft);
                totalSales += drinkArray[4].DrinkCost;
                lblTotalSales.Text = "$" + totalSales.ToString();
            }
            else
            {
                MessageBox.Show("ERROR! Out of drinks!");
            }
        }
    }
}
