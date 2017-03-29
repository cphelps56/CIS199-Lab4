// Colin Phelps
// Lab 4
// 2/17/15
// CIS 199-01
// This program is used to tell if students are accepted or rejected into a school. The user inputs the students GPA and test score and a message box is displayed telling whether the student was accepted or rejected. It also keeps a running total of the number of students who were accepted and rejected.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Variable to hold the amount accepted
        ushort amountAccepted;
        // Variable to hold the amount rejected
        ushort amountRejected;

        private void calculateScoresBtn_Click(object sender, EventArgs e)
        {
            // Variables to hold the data input from the textbox for use in the if statement
            double gpa = double.Parse(gpaTextbox.Text);
            byte testScore = byte.Parse(testScoreTextbox.Text);

            if (testScore >= 80)
            {
                MessageBox.Show("Accepted");
                amountAccepted += 1;
            }
            else if (gpa >= 3.0 && testScore >= 60)
            {
                MessageBox.Show("Accepted");
                amountAccepted += 1;
            }
            else
            {
                MessageBox.Show("Rejected");
                amountRejected += 1;
            }
           
            // Displays the amount accepted/rejected in their respective label.
            acceptedAmountLabel.Text = amountAccepted.ToString();
            rejectedAmountLabel.Text = amountRejected.ToString();

            gpaTextbox.Clear();
            testScoreTextbox.Clear();
        }
    }
}
