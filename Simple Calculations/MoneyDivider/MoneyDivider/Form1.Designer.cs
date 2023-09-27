namespace MoneyDivider
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSumMoney = new System.Windows.Forms.TextBox();
            this.lblMoneySum = new System.Windows.Forms.Label();
            this.lblNumOfPeople = new System.Windows.Forms.Label();
            this.txtNumOfPeople = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSumMoney
            // 
            this.txtSumMoney.Location = new System.Drawing.Point(101, 46);
            this.txtSumMoney.Multiline = true;
            this.txtSumMoney.Name = "txtSumMoney";
            this.txtSumMoney.Size = new System.Drawing.Size(187, 40);
            this.txtSumMoney.TabIndex = 0;
            // 
            // lblMoneySum
            // 
            this.lblMoneySum.AutoSize = true;
            this.lblMoneySum.Location = new System.Drawing.Point(98, 30);
            this.lblMoneySum.Name = "lblMoneySum";
            this.lblMoneySum.Size = new System.Drawing.Size(136, 13);
            this.lblMoneySum.TabIndex = 1;
            this.lblMoneySum.Text = "Enter amount of money in £";
            // 
            // lblNumOfPeople
            // 
            this.lblNumOfPeople.AutoSize = true;
            this.lblNumOfPeople.Location = new System.Drawing.Point(98, 125);
            this.lblNumOfPeople.Name = "lblNumOfPeople";
            this.lblNumOfPeople.Size = new System.Drawing.Size(117, 13);
            this.lblNumOfPeople.TabIndex = 2;
            this.lblNumOfPeople.Text = "Enter number of people";
            this.lblNumOfPeople.Click += new System.EventHandler(this.lblNumOfPeople_Click);
            // 
            // txtNumOfPeople
            // 
            this.txtNumOfPeople.Location = new System.Drawing.Point(101, 141);
            this.txtNumOfPeople.Multiline = true;
            this.txtNumOfPeople.Name = "txtNumOfPeople";
            this.txtNumOfPeople.Size = new System.Drawing.Size(187, 40);
            this.txtNumOfPeople.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(59, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(276, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate how much money each person gets";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(101, 267);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(187, 40);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(98, 251);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Each person gets...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MoneyDivider.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumOfPeople);
            this.Controls.Add(this.lblNumOfPeople);
            this.Controls.Add(this.lblMoneySum);
            this.Controls.Add(this.txtSumMoney);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSumMoney;
        private System.Windows.Forms.Label lblMoneySum;
        private System.Windows.Forms.Label lblNumOfPeople;
        private System.Windows.Forms.TextBox txtNumOfPeople;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

