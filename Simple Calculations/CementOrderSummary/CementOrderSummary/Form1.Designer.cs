namespace CementOrderSummary
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumCementBags = new System.Windows.Forms.TextBox();
            this.lblNumCementBags = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.textOrderName = new System.Windows.Forms.TextBox();
            this.txtCementBags = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 54);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 49);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumCementBags
            // 
            this.txtNumCementBags.Location = new System.Drawing.Point(55, 146);
            this.txtNumCementBags.Multiline = true;
            this.txtNumCementBags.Name = "txtNumCementBags";
            this.txtNumCementBags.Size = new System.Drawing.Size(215, 49);
            this.txtNumCementBags.TabIndex = 2;
            // 
            // lblNumCementBags
            // 
            this.lblNumCementBags.AutoSize = true;
            this.lblNumCementBags.Location = new System.Drawing.Point(55, 130);
            this.lblNumCementBags.Name = "lblNumCementBags";
            this.lblNumCementBags.Size = new System.Drawing.Size(182, 13);
            this.lblNumCementBags.TabIndex = 3;
            this.lblNumCementBags.Text = "Enter number of cement bags bought";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(91, 227);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(128, 39);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "print summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(55, 355);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(260, 28);
            this.txtCost.TabIndex = 5;
            this.txtCost.Text = "Total Cost:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(421, 191);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(214, 35);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "Cement bags are 93p per bag";
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(55, 292);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(50, 13);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Summary";
            this.lblCost.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textOrderName
            // 
            this.textOrderName.Location = new System.Drawing.Point(55, 332);
            this.textOrderName.Multiline = true;
            this.textOrderName.Name = "textOrderName";
            this.textOrderName.Size = new System.Drawing.Size(260, 26);
            this.textOrderName.TabIndex = 9;
            this.textOrderName.Text = "Order for: ";
            this.textOrderName.TextChanged += new System.EventHandler(this.textOrderName_TextChanged);
            // 
            // txtCementBags
            // 
            this.txtCementBags.Location = new System.Drawing.Point(55, 380);
            this.txtCementBags.Multiline = true;
            this.txtCementBags.Name = "txtCementBags";
            this.txtCementBags.Size = new System.Drawing.Size(260, 28);
            this.txtCementBags.TabIndex = 10;
            this.txtCementBags.Text = "Num of Cement Bags Ordered:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CementOrderSummary.Properties.Resources.ezgif_com_webp_to_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCementBags);
            this.Controls.Add(this.textOrderName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblNumCementBags);
            this.Controls.Add(this.txtNumCementBags);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumCementBags;
        private System.Windows.Forms.Label lblNumCementBags;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox textOrderName;
        private System.Windows.Forms.TextBox txtCementBags;
    }
}

