namespace EndingBalance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startingBalancePromptLabel = new Label();
            monthsPromptLabel = new Label();
            outputDescriptionLabel = new Label();
            txtStartingBal = new TextBox();
            txtMonths = new TextBox();
            LblEndingBalance = new Label();
            BtnCalculate = new Button();
            BtnClear = new Button();
            BtnExit = new Button();
            lbxOutput = new ListBox();
            txtinterestRate = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // startingBalancePromptLabel
            // 
            startingBalancePromptLabel.AutoSize = true;
            startingBalancePromptLabel.Location = new Point(41, 17);
            startingBalancePromptLabel.Name = "startingBalancePromptLabel";
            startingBalancePromptLabel.Size = new Size(95, 15);
            startingBalancePromptLabel.TabIndex = 0;
            startingBalancePromptLabel.Text = "Starting Balance:";
            // 
            // monthsPromptLabel
            // 
            monthsPromptLabel.AutoSize = true;
            monthsPromptLabel.Location = new Point(24, 49);
            monthsPromptLabel.Name = "monthsPromptLabel";
            monthsPromptLabel.Size = new Size(112, 15);
            monthsPromptLabel.TabIndex = 1;
            monthsPromptLabel.Text = "Number of Months:";
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(45, 138);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(91, 15);
            outputDescriptionLabel.TabIndex = 2;
            outputDescriptionLabel.Text = "Ending Balance:";
            // 
            // txtStartingBal
            // 
            txtStartingBal.Location = new Point(141, 12);
            txtStartingBal.Name = "txtStartingBal";
            txtStartingBal.Size = new Size(100, 23);
            txtStartingBal.TabIndex = 3;
            // 
            // txtMonths
            // 
            txtMonths.Location = new Point(141, 45);
            txtMonths.Name = "txtMonths";
            txtMonths.Size = new Size(100, 23);
            txtMonths.TabIndex = 4;
            // 
            // LblEndingBalance
            // 
            LblEndingBalance.BorderStyle = BorderStyle.FixedSingle;
            LblEndingBalance.Location = new Point(141, 133);
            LblEndingBalance.Name = "LblEndingBalance";
            LblEndingBalance.Size = new Size(100, 23);
            LblEndingBalance.TabIndex = 5;
            LblEndingBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Location = new Point(2, 321);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(75, 23);
            BtnCalculate.TabIndex = 6;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += calculateButton_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(83, 321);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(75, 23);
            BtnClear.TabIndex = 7;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += clearButton_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(164, 321);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 8;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += exitButton_Click;
            // 
            // lbxOutput
            // 
            lbxOutput.FormattingEnabled = true;
            lbxOutput.ItemHeight = 15;
            lbxOutput.Location = new Point(2, 179);
            lbxOutput.Name = "lbxOutput";
            lbxOutput.Size = new Size(239, 139);
            lbxOutput.TabIndex = 9;
            // 
            // txtinterestRate
            // 
            txtinterestRate.Location = new Point(139, 74);
            txtinterestRate.Name = "txtinterestRate";
            txtinterestRate.Size = new Size(100, 23);
            txtinterestRate.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 78);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 10;
            label1.Text = "Interest Rate";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(382, 389);
            Controls.Add(txtinterestRate);
            Controls.Add(label1);
            Controls.Add(lbxOutput);
            Controls.Add(BtnExit);
            Controls.Add(BtnClear);
            Controls.Add(BtnCalculate);
            Controls.Add(LblEndingBalance);
            Controls.Add(txtMonths);
            Controls.Add(txtStartingBal);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(monthsPromptLabel);
            Controls.Add(startingBalancePromptLabel);
            Name = "Form1";
            Text = "Ending Balance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startingBalancePromptLabel;
        private Label monthsPromptLabel;
        private Label outputDescriptionLabel;
        private TextBox txtStartingBal;
        private TextBox txtMonths;
        private Label LblEndingBalance;
        private Button BtnCalculate;
        private Button BtnClear;
        private Button BtnExit;
        private ListBox lbxOutput;
        private TextBox txtinterestRate;
        private Label label1;
    }
}