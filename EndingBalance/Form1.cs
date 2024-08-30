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

            int months;                // The number of months
            int count = 1;             // Loop counter, initialized with 1

            // Get the starting balance.
            if (Single.TryParse(txtStartingBal.Text, out balance))
            {
                // Get the number of months.
                if (int.TryParse(txtMonths.Text, out months))
                {


                    if (Single.TryParse(txtinterestRate.Text, out interestRate))
                    {

                    }

                    // The following loop calculates the ending balance.
                    while (count <= months)
                    {
                        // Add this month's interest to the balance.
                        balance += (INTEREST_RATE * balance);

                        lbxOutput.Items.Add("Month " + count + " " + balance);

                        // Add one to the loop counter.
                        count++;
                    }

                    // Display the ending balance.
                    LblEndingBalance.Text = balance.ToString("c");
                }
                else
                {
                    // Invalid number of months was entered.
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else
            {
                // Invalid starting balance was entered.
                MessageBox.Show("Invalid value for starting balance.");
            }
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
    }
}