//Grading ID: A5196
//Program Number: Program 1
//Due Date: 14 February 2017
//Course Section: CIS 199-01
//This program will caulcate the relevant costs with a painting project, given some inputs.
//The user will input their wall space, their desired number of coats, and the cost of paint.
//The program will output the total square feet to be done, the gallons of paint required,
//the the hours of labor needed, the paint cost, the labor cost, and the total costs of the project.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class program1Form : Form
    {
        private const int SQUARE_FOOT_PER_GALLON = 330; //This constant is the square footage from one gallon of paint
        private const int HOURS_PER_GALLON = 6; //This constant is the hours to use paint one gallon
        private const double COST_PER_HOUR = 10.50; //This constant is the price of labor per hour
        public program1Form()
        {
            InitializeComponent();
        }
        
        //This event is what occurs when the Calculate button is clicked. It will calculate the desired outputs.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Inputs
            int coatsOfPaint; //This variable is the number of coats of paint desired
            coatsOfPaint = int.Parse(coatsDesiredTextBox.Text);
            double wallSpace; //This variable is the wall space that will be painted
            wallSpace = float.Parse(squareFeetTextBox.Text);
            double paintPrice; //This is the paint price (per Gallon)
            paintPrice = float.Parse(paintPriceTextBox.Text);
            //Calculations
            double totalPaintArea;//This variable is the total area to be painted, including all coats
            totalPaintArea = wallSpace * coatsOfPaint;
            double gallonsRequired;//This is the how much paint that will need to be bought (gallons)
            gallonsRequired = totalPaintArea / SQUARE_FOOT_PER_GALLON;
            double gallonsRequiredRounded;//This is the how many gallons, rounded up to an amount that is actually purchasable.
            gallonsRequiredRounded = Math.Ceiling(gallonsRequired);
            double hoursRequired; //This variable is the hours of labor that will be required
            hoursRequired = (gallonsRequired) * HOURS_PER_GALLON;
            double paintCost;//This is the cost of all gallons of paint
            paintCost = gallonsRequiredRounded * paintPrice;
            double laborCost;//This is the total cost of labor
            laborCost = hoursRequired * COST_PER_HOUR;
            double totalCost;//This is the total cost of paint and labor
            totalCost = paintCost + laborCost;
            //Outputs
            totalPaintAreaOutputLabel.Text = totalPaintArea.ToString("n1");//This sets the total paint area output label
            paintRequiredOutputLabel.Text = gallonsRequiredRounded.ToString("n0");//This sets the gallons of pant required output label
            hoursRequiredOutputLabel.Text = hoursRequired.ToString("n1");//this sets the hours of labor output label
            paintCostOutputLabel.Text = paintCost.ToString("c2");//This sets the paint cost output label
            laborCostOutputLabel.Text = laborCost.ToString("c2");//This set the labor cost output label
            totalCostOutputLabel.Text = totalCost.ToString("c2");//This sets the total cost output label

        }

        //This even serves as a clear button to reset the form should any mistakes be made by the user.
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear inputs
            squareFeetTextBox.Text = "";
            coatsDesiredTextBox.Text = "";
            paintPriceTextBox.Text = "";
            //Clear Outputs
            totalPaintAreaOutputLabel.Text = "";
            totalCostOutputLabel.Text = "";
            paintRequiredOutputLabel.Text = "";
            hoursRequiredOutputLabel.Text = "";
            laborCostOutputLabel.Text = "";
            paintCostOutputLabel.Text = "";
        }
    }
}
