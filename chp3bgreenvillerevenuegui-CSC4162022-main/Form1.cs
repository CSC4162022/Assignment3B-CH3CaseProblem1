using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        int lastYearCont = 0;
        int thisYearCont = 0;
        int revenue = 0;
        string outComeMessage = "It is outcome that this year's competition is bigger than last year's.";
        public Form1()
        {
            InitializeComponent();
        }

        /*
        expectedOutcome.AppendLine("Enter number of contestants last year >> ");
        expectedOutcome.AppendLine("Enter number of contestants this year >> ");
        expectedOutcome.AppendLine(string.Format("Last year's competition had {0} contestants, and this year's has {1} contestants",lastYearInput,thisYearInput));
        expectedOutcome.AppendLine("Revenue expected this year is $350.00");
        expectedOutcome.AppendLine("It is True that this year's competition is bigger than last year's.");
         * 
        /*
        private void HelloButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Hello, " + textBox1.Text + "!";
        }

        private void GoodbyeButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Goodbye, " + textBox1.Text + "!";
        }
        */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            thisYearCont = Int32.Parse(thisYearContestantsTxt.Text);
            lastYearCont = Int32.Parse(lastYearContestantsTxt.Text);
            revenue = thisYearCont * 25;


            string contestantsResult = "Last year's competition had " + lastYearCont + " contestants, and this year's has " + thisYearCont + " constestants";
            string revenueResult = "Revenue expected this year is " + revenue.ToString("C");
            bool thisYearLarger = false;
            if (thisYearCont > lastYearCont)
            {
                thisYearLarger = true;
            }
            string finalResult = "It is " + thisYearLarger + " that this year's competition is bigger than last year's.";


            Resultlbl.Text = contestantsResult + '\r' + revenueResult + '\r' + finalResult;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
