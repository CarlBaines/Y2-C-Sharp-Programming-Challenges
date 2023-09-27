namespace VanType
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtNumItemsMoved = new System.Windows.Forms.TextBox();
            this.lblNumItemsMoved = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(83, 72);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(210, 43);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(83, 53);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Enter Customer Name";
            // 
            // txtNumItemsMoved
            // 
            this.txtNumItemsMoved.Location = new System.Drawing.Point(83, 170);
            this.txtNumItemsMoved.Multiline = true;
            this.txtNumItemsMoved.Name = "txtNumItemsMoved";
            this.txtNumItemsMoved.Size = new System.Drawing.Size(210, 43);
            this.txtNumItemsMoved.TabIndex = 2;
            // 
            // lblNumItemsMoved
            // 
            this.lblNumItemsMoved.AutoSize = true;
            this.lblNumItemsMoved.Location = new System.Drawing.Point(83, 154);
            this.lblNumItemsMoved.Name = "lblNumItemsMoved";
            this.lblNumItemsMoved.Size = new System.Drawing.Size(171, 13);
            this.lblNumItemsMoved.TabIndex = 3;
            this.lblNumItemsMoved.Text = "Enter number of items to be moved";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(129, 241);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(105, 23);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Print summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(83, 283);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(210, 43);
            this.txtSummary.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VanType.Properties.Resources._105504989_muscular_fitness_shirtless_man_moving_large_heavy_tire_in_street_gym_concept_lifting_workout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.lblNumItemsMoved);
            this.Controls.Add(this.txtNumItemsMoved);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtNumItemsMoved;
        private System.Windows.Forms.Label lblNumItemsMoved;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TextBox txtSummary;
    }
}

