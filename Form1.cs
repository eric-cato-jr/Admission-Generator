using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Eric Cato Jr CIS:199-01 Due:09/29/2024
This program displays accepting and rejecting admissions based on gpa and test score
Porgram also displays running totals
 */
namespace Lab4
{
    public partial class Form1 : Form
    {
        private int acceptedCount = 0; // Holds the total count of accepted applications
        private int rejectedCount = 0; // Holds the total count of rejected applications
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            // Variables to store the GPA and Test Score
            float gpa;
            int testScore;

            // Try to parse the GPA
            bool isValidGpa = float.TryParse(txtGpa.Text, out gpa);

            // GPA validation
            if (!isValidGpa || gpa < 0.0 || gpa > 4.0)
            {
                MessageBox.Show("Please enter a valid GPA between 0.0 and 4.0.");
                txtGpa.Focus(); // Set focus back to the GPA input
                return;
            }

            // Shift focus to the test score input after valid GPA
            txtTestScore.Focus();

            // Try to parse the test score
            bool isValidTestScore = int.TryParse(txtTestScore.Text, out testScore);

            // Test score validation
            if (!isValidTestScore || testScore < 0 || testScore > 100)
            {
                MessageBox.Show("Please enter a valid test score between 0 and 100.");
                txtTestScore.Focus();  // Set focus back to the test score input
                return;
            }

            // Admission decision
            if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
            {
                lblDecisionOutput.Text = "Accept";
                acceptedCount++;  // Increment accepted count
            }
            else
            {
                lblDecisionOutput.Text = "Reject";
                rejectedCount++;  // Increment rejected count
            }

            // Update the running totals
            lblAcceptedOutput.Text = acceptedCount.ToString();
            lblRejectedOutput.Text = rejectedCount.ToString();

            // Set focus back to the GPA input after processing
            txtGpa.Focus();
        }
    }
}
