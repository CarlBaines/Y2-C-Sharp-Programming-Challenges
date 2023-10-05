namespace TaxiChargeFunction
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
            txtBaseFare = new TextBox();
            txtDistanceTravelled = new TextBox();
            lblDistanceTravelled = new Label();
            txtOutput = new TextBox();
            btnCalcTotalFare = new Button();
            SuspendLayout();
            // 
            // txtBaseFare
            // 
            txtBaseFare.Location = new Point(54, 31);
            txtBaseFare.Multiline = true;
            txtBaseFare.Name = "txtBaseFare";
            txtBaseFare.Size = new Size(163, 40);
            txtBaseFare.TabIndex = 0;
            // 
            // txtDistanceTravelled
            // 
            txtDistanceTravelled.Location = new Point(54, 112);
            txtDistanceTravelled.Multiline = true;
            txtDistanceTravelled.Name = "txtDistanceTravelled";
            txtDistanceTravelled.Size = new Size(163, 40);
            txtDistanceTravelled.TabIndex = 1;
            // 
            // lblDistanceTravelled
            // 
            lblDistanceTravelled.AutoSize = true;
            lblDistanceTravelled.Location = new Point(56, 92);
            lblDistanceTravelled.Name = "lblDistanceTravelled";
            lblDistanceTravelled.Size = new Size(182, 15);
            lblDistanceTravelled.TabIndex = 2;
            lblDistanceTravelled.Text = "Enter the distance travelled in km";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(56, 225);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(163, 40);
            txtOutput.TabIndex = 3;
            // 
            // btnCalcTotalFare
            // 
            btnCalcTotalFare.Location = new Point(62, 177);
            btnCalcTotalFare.Name = "btnCalcTotalFare";
            btnCalcTotalFare.Size = new Size(155, 23);
            btnCalcTotalFare.TabIndex = 4;
            btnCalcTotalFare.Text = "Calculate total fare";
            btnCalcTotalFare.UseVisualStyleBackColor = true;
            btnCalcTotalFare.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ezgif_com_webp_to_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcTotalFare);
            Controls.Add(txtOutput);
            Controls.Add(lblDistanceTravelled);
            Controls.Add(txtDistanceTravelled);
            Controls.Add(txtBaseFare);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBaseFare;
        private TextBox txtDistanceTravelled;
        private Label lblDistanceTravelled;
        private TextBox txtOutput;
        private Button btnCalcTotalFare;
    }
}