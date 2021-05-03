/*
 * Author: Adrian Sawatzky 
 * April 23rd, 2021
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class variablePractice : Form
    {
        public variablePractice()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            //declare string variable with the name Wayne gretzky and an int variable with his number
            int playerNumber = 99;
            string playerName = "Wayne Gretzky";

            //display message with variables
            outputLabel.Text = playerName;
            outputLabel.Text += $" is number {playerNumber}";                      
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            //declare double variables that store the values of the radius, pi and area
            double radius = 15;
            double pi = 3.14;
            double area = pi * radius * radius;

            //display message with variables
            outputLabel.Text = $"The area of circle with a radius of {radius}cm is {area}cm^2";
        }

        private void carpetArea_Click(object sender, EventArgs e)
        {
            //declare double variables for width, length, costPerMeter, area, and totalCost
            double length = 8.5;
            double width = 6;
            double costPerMetre = 19.95;
            double area = length * width;
            double totalCost = area * costPerMetre;

            //display message with variables
            outputLabel.Text = $"The area of a room with the dimensions {length} x {width} is {area}m^2";
            outputLabel.Text += $"\n\nThe cost to carpet this area at {costPerMetre} per sqaure metre is {totalCost}";


        }

        private void billButton_Click(object sender, EventArgs e)
        {
            //declare double variables for tax, the price of the shirt, the $20 bill, the tax, the amount of tax owed, the total amount, and the amount of change owed 
            double shirtPrice = 12.49;
            double dollarBill = 20;
            double tax = 1.13;
            double owedTax = shirtPrice * tax - shirtPrice;
            double total = shirtPrice * tax;
            double change = dollarBill - total; 

            //display amounts owed and tendered
            outputLabel.Text = $"Bill of sale";
            outputLabel.Text += $"\n\nShirt: {shirtPrice}";
            outputLabel.Text += $"\n\nTax: {owedTax}\nTotal: {total}";
            outputLabel.Text += $"\n\nTendered: {dollarBill}\nChange: {change}";
                

        }
    }
}
