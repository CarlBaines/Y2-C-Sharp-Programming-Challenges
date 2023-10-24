namespace ATMMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterPin = new System.Windows.Forms.TextBox();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.btnDepositAmount = new System.Windows.Forms.Button();
            this.btnDisplayBalance = new System.Windows.Forms.Button();
            this.btnEnterPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your PIN number";
            // 
            // txtEnterPin
            // 
            this.txtEnterPin.Location = new System.Drawing.Point(109, 56);
            this.txtEnterPin.Multiline = true;
            this.txtEnterPin.Name = "txtEnterPin";
            this.txtEnterPin.Size = new System.Drawing.Size(200, 36);
            this.txtEnterPin.TabIndex = 1;
            this.txtEnterPin.TextChanged += new System.EventHandler(this.txtEnterPin_TextChanged);
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.Location = new System.Drawing.Point(106, 189);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(215, 13);
            this.lblWithdrawAmount.TabIndex = 2;
            this.lblWithdrawAmount.Text = "Enter the amount you would like to withdraw";
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(109, 216);
            this.txtWithdrawAmount.Multiline = true;
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(200, 36);
            this.txtWithdrawAmount.TabIndex = 3;
            this.txtWithdrawAmount.TextChanged += new System.EventHandler(this.txtWithdrawAmount_TextChanged);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(373, 281);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(111, 50);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw Amount";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(109, 136);
            this.txtDepositAmount.Multiline = true;
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(200, 36);
            this.txtDepositAmount.TabIndex = 6;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(106, 109);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(207, 13);
            this.lblDepositAmount.TabIndex = 5;
            this.lblDepositAmount.Text = "Enter the amount you would like to deposit";
            // 
            // btnDepositAmount
            // 
            this.btnDepositAmount.Location = new System.Drawing.Point(242, 281);
            this.btnDepositAmount.Name = "btnDepositAmount";
            this.btnDepositAmount.Size = new System.Drawing.Size(111, 50);
            this.btnDepositAmount.TabIndex = 7;
            this.btnDepositAmount.Text = "Deposit Amount";
            this.btnDepositAmount.UseVisualStyleBackColor = true;
            this.btnDepositAmount.Click += new System.EventHandler(this.btnDepositAmount_Click);
            // 
            // btnDisplayBalance
            // 
            this.btnDisplayBalance.Location = new System.Drawing.Point(109, 357);
            this.btnDisplayBalance.Name = "btnDisplayBalance";
            this.btnDisplayBalance.Size = new System.Drawing.Size(111, 50);
            this.btnDisplayBalance.TabIndex = 8;
            this.btnDisplayBalance.Text = "Display Balance";
            this.btnDisplayBalance.UseVisualStyleBackColor = true;
            this.btnDisplayBalance.Click += new System.EventHandler(this.btnDisplayBalance_Click);
            // 
            // btnEnterPin
            // 
            this.btnEnterPin.Location = new System.Drawing.Point(109, 281);
            this.btnEnterPin.Name = "btnEnterPin";
            this.btnEnterPin.Size = new System.Drawing.Size(111, 50);
            this.btnEnterPin.TabIndex = 9;
            this.btnEnterPin.Text = "Enter PIN";
            this.btnEnterPin.UseVisualStyleBackColor = true;
            this.btnEnterPin.Click += new System.EventHandler(this.btnEnterPin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterPin);
            this.Controls.Add(this.btnDisplayBalance);
            this.Controls.Add(this.btnDepositAmount);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.lblWithdrawAmount);
            this.Controls.Add(this.txtEnterPin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterPin;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Button btnDepositAmount;
        private System.Windows.Forms.Button btnDisplayBalance;
        private System.Windows.Forms.Button btnEnterPin;
    }
}

