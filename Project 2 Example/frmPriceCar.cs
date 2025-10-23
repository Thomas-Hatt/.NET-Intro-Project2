using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Project_2_Example
{
    public partial class frmPriceCar : Form
    {

        // CREATE LIST FOR AVAILABLE OPTION PRICES (parallel to listbox)
        List<decimal> availableOptionPrices = new List<decimal>() {
            // Power Windows
            775.18m,

            // Power Doorlocks
            567.99m,

            // Power Mirrors
            312.03m,

            // Automatic Transmission
            1934.99m,

            // Cloth Seats
            609.82m,

            // Air Conditioning
            1251.04m,
            
            // Keyless Entry
            190.08m,
            
            // Floormats
            82.00m,
            
            // Premium Paint
            600m
        };

        // CREATE LIST FOR SELECTED OPTION PRICES (parallel to listbox - empty to start)
        List<decimal> selectedOptionPrices = new List<decimal>();

        // CREATE BASE PRICE VARIABLE AND SET TO BASE PRICE OF CAR
        decimal basePrice = 22995.97m;

        // CREATE SALES TAX PERCENT CONSTANT
        const decimal salesTaxPercent = 0.06m; // 6%

        // CREATE DESTINATION FEE CONSTANT
        const decimal destinationFee = 995.00m;

        public frmPriceCar()
        {
            InitializeComponent();

            // Call CalculateTotal() to update the text on form load
            CalculateTotal();
        }

        private void lstAvailableOptions_DoubleClick(object sender, EventArgs e)
        {
            // DETERMINE IF OPTION HAS NOT ALREADY BEEN SELECTED
            if (lstAvailableOptions.SelectedIndex != -1 && !lstSelectedOptions.Items.Contains(lstAvailableOptions.SelectedItem))
            {
                // ADD OPTION TO SELECTED OPTIONS LISTBOX
                lstSelectedOptions.Items.Add(lstAvailableOptions.SelectedItem);

                // ADD OPTION PRICE TO SELECTED OPTIONS LIST
                selectedOptionPrices.Add(availableOptionPrices[lstAvailableOptions.SelectedIndex]);

                // CALL CALCULATE METHOD TO CALCULATE TOTALS AND DISPLAY TO SCREEN
                CalculateTotal();
            }

        }

        private void lstSelectedOptions_DoubleClick(object sender, EventArgs e)
        {
            // Make sure that an option was selected
            if (lstSelectedOptions.SelectedIndex != -1)
            {
                // REMOVE OPTION PRICE TO SELECTED OPTIONS LIST
                selectedOptionPrices.RemoveAt(lstSelectedOptions.SelectedIndex);

                // REMOVE OPTION FROM SELECTED OPTIONS LISTBOX
                lstSelectedOptions.Items.RemoveAt(lstSelectedOptions.SelectedIndex);

                // CALL CALCULATE METHOD TO CALCULATE TOTALS AND DISPLAY TO SCREEN
                CalculateTotal();
            }
        }

        private void tmrCar_Tick(object sender, EventArgs e)
        {
            // CAR MOVING JUST FOR FUN
            // MOVE CAR FORWARD UNTIL LOGO, THEN MOVE BACK TO FORM
            if (tmrCar.Tag.ToString() == "F")
            {
                picCar.Left -= 10; // MOVE FORWARD
                if (picCar.Left <= picLogo.Left + picLogo.Width) { tmrCar.Tag = "B"; } // IF AT LOGO, SET TO GO BACK
            }
            else
            {
                picCar.Left += 10; // MOVE BACK
                if (picCar.Left + picCar.Width >= this.Width) { tmrCar.Tag = "F"; } // IF AT EDGE, SET TO GO FORWARD
            }
        }
        private void CalculateTotal()
        {
            // Calculate the total price of selected options
            decimal optionsTotal = selectedOptionPrices.Sum();

            // Calculate the subtotal
            decimal subtotal = basePrice + optionsTotal;

            // Calculate the sales tax
            decimal salesTax = subtotal * salesTaxPercent;

            // Calculate the total cost
            decimal total = subtotal + salesTax + destinationFee;

            // Update the labels with just the calculated values
            lblBasePrice.Text = $"{basePrice:C}";
            lblOptions.Text = $"{optionsTotal:C}";
            lblDestination.Text = $"{destinationFee:C}";
            lblSalesTax.Text = $"{salesTax:C}";
            lblTotal.Text = $"{total:C}";
        }
    }
}
