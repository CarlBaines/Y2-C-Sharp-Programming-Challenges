namespace WeightConverter
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
            this.txtInputWeight = new System.Windows.Forms.TextBox();
            this.lblInputWeight = new System.Windows.Forms.Label();
            this.btnConvertWeight = new System.Windows.Forms.Button();
            this.txtWeightToPounds = new System.Windows.Forms.TextBox();
            this.lblWeightToPounds = new System.Windows.Forms.Label();
            this.txtWeightToGrams = new System.Windows.Forms.TextBox();
            this.lblWeightToGrams = new System.Windows.Forms.Label();
            this.txtWeightToKg = new System.Windows.Forms.TextBox();
            this.lblWeightToKg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputWeight
            // 
            this.txtInputWeight.Location = new System.Drawing.Point(51, 52);
            this.txtInputWeight.Multiline = true;
            this.txtInputWeight.Name = "txtInputWeight";
            this.txtInputWeight.Size = new System.Drawing.Size(158, 41);
            this.txtInputWeight.TabIndex = 0;
            // 
            // lblInputWeight
            // 
            this.lblInputWeight.AutoSize = true;
            this.lblInputWeight.Location = new System.Drawing.Point(48, 36);
            this.lblInputWeight.Name = "lblInputWeight";
            this.lblInputWeight.Size = new System.Drawing.Size(148, 13);
            this.lblInputWeight.TabIndex = 1;
            this.lblInputWeight.Text = "Input weight of item in ounces";
            this.lblInputWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConvertWeight
            // 
            this.btnConvertWeight.Location = new System.Drawing.Point(63, 118);
            this.btnConvertWeight.Name = "btnConvertWeight";
            this.btnConvertWeight.Size = new System.Drawing.Size(133, 23);
            this.btnConvertWeight.TabIndex = 2;
            this.btnConvertWeight.Text = "Convert weights";
            this.btnConvertWeight.UseVisualStyleBackColor = true;
            this.btnConvertWeight.Click += new System.EventHandler(this.btnConvertWeight_Click);
            // 
            // txtWeightToPounds
            // 
            this.txtWeightToPounds.Location = new System.Drawing.Point(51, 176);
            this.txtWeightToPounds.Multiline = true;
            this.txtWeightToPounds.Name = "txtWeightToPounds";
            this.txtWeightToPounds.Size = new System.Drawing.Size(158, 41);
            this.txtWeightToPounds.TabIndex = 3;
            // 
            // lblWeightToPounds
            // 
            this.lblWeightToPounds.AutoSize = true;
            this.lblWeightToPounds.Location = new System.Drawing.Point(48, 160);
            this.lblWeightToPounds.Name = "lblWeightToPounds";
            this.lblWeightToPounds.Size = new System.Drawing.Size(140, 13);
            this.lblWeightToPounds.TabIndex = 4;
            this.lblWeightToPounds.Text = "Converted weight to pounds";
            // 
            // txtWeightToGrams
            // 
            this.txtWeightToGrams.Location = new System.Drawing.Point(242, 176);
            this.txtWeightToGrams.Multiline = true;
            this.txtWeightToGrams.Name = "txtWeightToGrams";
            this.txtWeightToGrams.Size = new System.Drawing.Size(158, 41);
            this.txtWeightToGrams.TabIndex = 5;
            // 
            // lblWeightToGrams
            // 
            this.lblWeightToGrams.AutoSize = true;
            this.lblWeightToGrams.Location = new System.Drawing.Point(239, 160);
            this.lblWeightToGrams.Name = "lblWeightToGrams";
            this.lblWeightToGrams.Size = new System.Drawing.Size(133, 13);
            this.lblWeightToGrams.TabIndex = 6;
            this.lblWeightToGrams.Text = "Converted weight to grams";
            // 
            // txtWeightToKg
            // 
            this.txtWeightToKg.Location = new System.Drawing.Point(431, 176);
            this.txtWeightToKg.Multiline = true;
            this.txtWeightToKg.Name = "txtWeightToKg";
            this.txtWeightToKg.Size = new System.Drawing.Size(158, 41);
            this.txtWeightToKg.TabIndex = 7;
            // 
            // lblWeightToKg
            // 
            this.lblWeightToKg.AutoSize = true;
            this.lblWeightToKg.Location = new System.Drawing.Point(428, 160);
            this.lblWeightToKg.Name = "lblWeightToKg";
            this.lblWeightToKg.Size = new System.Drawing.Size(149, 13);
            this.lblWeightToKg.TabIndex = 8;
            this.lblWeightToKg.Text = "Converted weight to kilograms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeightConverter.Properties.Resources.gettyimages_sb10067216n_001_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.lblWeightToKg);
            this.Controls.Add(this.txtWeightToKg);
            this.Controls.Add(this.lblWeightToGrams);
            this.Controls.Add(this.txtWeightToGrams);
            this.Controls.Add(this.lblWeightToPounds);
            this.Controls.Add(this.txtWeightToPounds);
            this.Controls.Add(this.btnConvertWeight);
            this.Controls.Add(this.lblInputWeight);
            this.Controls.Add(this.txtInputWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputWeight;
        private System.Windows.Forms.Label lblInputWeight;
        private System.Windows.Forms.Button btnConvertWeight;
        private System.Windows.Forms.TextBox txtWeightToPounds;
        private System.Windows.Forms.Label lblWeightToPounds;
        private System.Windows.Forms.TextBox txtWeightToGrams;
        private System.Windows.Forms.Label lblWeightToGrams;
        private System.Windows.Forms.TextBox txtWeightToKg;
        private System.Windows.Forms.Label lblWeightToKg;
    }
}

