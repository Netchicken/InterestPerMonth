using System.Diagnostics;

namespace EndingBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Constant for the monthly interest rate.


            // Local variables
            Single balance;           // The account balance
            Single interestRate;      // the interest rate

            int totalMonths;                // The number of totalMonths
            int count = 1;             // Loop counter, initialized with 1

            // Get the starting balance.
            if (Single.TryParse(txtStartingBal.Text, out balance))
            {
                // Get the number of totalMonths.
                if (int.TryParse(txtMonths.Text, out totalMonths))
                {
                    if (Single.TryParse(txtinterestRate.Text, out interestRate))
                    {
                        //get the monthy interest rate
                        Single monthlyRate = interestRate / 12;

                        // The following loop calculates the ending balance.
                        while (count <= totalMonths)
                        {
                            // Add this month's interest to the balance.
                            balance *= (1 + monthlyRate);

                            lbxOutput.Items.Add("Month " + count + " " + balance);

                            // Add one to the loop counter.
                            count++;
                        }
                    }
                    // Display the ending balance.
                    LblEndingBalance.Text = balance.ToString("c");
                }
                else
                {
                    // Invalid number of totalMonths was entered.
                    MessageBox.Show("Invalid value for totalMonths.");
                }
            }
            else
            {
                // Invalid starting balance was entered.
                MessageBox.Show("Invalid value for starting balance.");
            }
            chatGPT();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the endingBalanceLabel control.
            txtStartingBal.Text = "";
            txtMonths.Text = "";
            LblEndingBalance.Text = "";

            // Reset the focus.
            txtStartingBal.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void lbxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
        }



        private void chatGPT()
        {
            double principal = 100; // Initial amount
            double yearInterest = 0.05;

            double monthlyRate = yearInterest / 12; // Monthly interest rate
            int months = 6; // Number of months

            double amount = principal;
            int currentMonth = 1;

            Debug.WriteLine("Month\tAmount");

            while (currentMonth <= months)
            {
                amount *= (1 + monthlyRate);
                Debug.WriteLine($"{currentMonth}\t{amount:C2}");
                currentMonth++;
            }

            double interest = amount - principal;

            Debug.WriteLine($"\nTotal amount after {months} months: {amount:C2}");
            Debug.WriteLine($"Total interest earned: {interest:C2}");
        }

    }
}