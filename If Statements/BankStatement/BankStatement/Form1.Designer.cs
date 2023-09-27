namespace BankStatement
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
            this.txtBankBalance = new System.Windows.Forms.TextBox();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.lblNewBalance = new System.Windows.Forms.Label();
            this.txtNewBalance = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBankBalance
            // 
            this.txtBankBalance.Location = new System.Drawing.Point(275, 49);
            this.txtBankBalance.Multiline = true;
            this.txtBankBalance.Name = "txtBankBalance";
            this.txtBankBalance.Size = new System.Drawing.Size(263, 47);
            this.txtBankBalance.TabIndex = 0;
            this.txtBankBalance.TextChanged += new System.EventHandler(this.txtBankBalance_TextChanged);
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Location = new System.Drawing.Point(272, 33);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(100, 13);
            this.lblBankBalance.TabIndex = 1;
            this.lblBankBalance.Text = "Enter bank balance";
            this.lblBankBalance.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNewBalance
            // 
            this.lblNewBalance.AutoSize = true;
            this.lblNewBalance.Location = new System.Drawing.Point(272, 211);
            this.lblNewBalance.Name = "lblNewBalance";
            this.lblNewBalance.Size = new System.Drawing.Size(112, 13);
            this.lblNewBalance.TabIndex = 2;
            this.lblNewBalance.Text = "Your new balance is...";
            this.lblNewBalance.Click += new System.EventHandler(this.lblNewBalance_Click);
            // 
            // txtNewBalance
            // 
            this.txtNewBalance.Location = new System.Drawing.Point(275, 227);
            this.txtNewBalance.Multiline = true;
            this.txtNewBalance.Name = "txtNewBalance";
            this.txtNewBalance.Size = new System.Drawing.Size(263, 47);
            this.txtNewBalance.TabIndex = 3;
            this.txtNewBalance.TextChanged += new System.EventHandler(this.txtNewBalance_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(272, 301);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(83, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Status Message";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(275, 317);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(263, 47);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.Location = new System.Drawing.Point(275, 143);
            this.txtWithdrawAmount.Multiline = true;
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(263, 47);
            this.txtWithdrawAmount.TabIndex = 6;
            this.txtWithdrawAmount.TextChanged += new System.EventHandler(this.txtBankBalance_TextChanged);
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.Location = new System.Drawing.Point(272, 127);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(197, 13);
            this.lblWithdrawAmount.TabIndex = 7;
            this.lblWithdrawAmount.Text = "Enter amount you would like to withdraw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankStatement.Properties.Resources.maxresdefault__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWithdrawAmount);
            this.Controls.Add(this.txtWithdrawAmount);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtNewBalance);
            this.Controls.Add(this.lblNewBalance);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.txtBankBalance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBankBalance;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.Label lblNewBalance;
        private System.Windows.Forms.TextBox txtNewBalance;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label lblWithdrawAmount;
    }
}

