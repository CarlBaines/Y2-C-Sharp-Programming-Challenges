namespace PythagorasTheorem
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
            txt1stShortSide = new TextBox();
            label1 = new Label();
            lbl1stShortSide = new Label();
            lbl2ndShortSide = new Label();
            txt2ndShortSide = new TextBox();
            txtOutput = new TextBox();
            btnCalcHypotenuse = new Button();
            SuspendLayout();
            // 
            // txt1stShortSide
            // 
            txt1stShortSide.Location = new Point(55, 44);
            txt1stShortSide.Multiline = true;
            txt1stShortSide.Name = "txt1stShortSide";
            txt1stShortSide.Size = new Size(225, 38);
            txt1stShortSide.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // lbl1stShortSide
            // 
            lbl1stShortSide.AutoSize = true;
            lbl1stShortSide.Location = new Point(56, 25);
            lbl1stShortSide.Name = "lbl1stShortSide";
            lbl1stShortSide.Size = new Size(224, 15);
            lbl1stShortSide.TabIndex = 2;
            lbl1stShortSide.Text = "Enter the length of the most shortest side";
            lbl1stShortSide.Click += label2_Click;
            // 
            // lbl2ndShortSide
            // 
            lbl2ndShortSide.AutoSize = true;
            lbl2ndShortSide.Location = new Point(55, 109);
            lbl2ndShortSide.Name = "lbl2ndShortSide";
            lbl2ndShortSide.Size = new Size(217, 15);
            lbl2ndShortSide.TabIndex = 3;
            lbl2ndShortSide.Text = "Enter the length of the 2nd shortest side";
            lbl2ndShortSide.Click += label3_Click;
            // 
            // txt2ndShortSide
            // 
            txt2ndShortSide.Location = new Point(55, 127);
            txt2ndShortSide.Multiline = true;
            txt2ndShortSide.Name = "txt2ndShortSide";
            txt2ndShortSide.Size = new Size(224, 38);
            txt2ndShortSide.TabIndex = 4;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(103, 364);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(158, 38);
            txtOutput.TabIndex = 6;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // btnCalcHypotenuse
            // 
            btnCalcHypotenuse.Location = new Point(120, 305);
            btnCalcHypotenuse.Name = "btnCalcHypotenuse";
            btnCalcHypotenuse.Size = new Size(119, 40);
            btnCalcHypotenuse.TabIndex = 7;
            btnCalcHypotenuse.Text = "Calculate hypotenuse";
            btnCalcHypotenuse.UseVisualStyleBackColor = true;
            btnCalcHypotenuse.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(358, 450);
            Controls.Add(btnCalcHypotenuse);
            Controls.Add(txtOutput);
            Controls.Add(txt2ndShortSide);
            Controls.Add(lbl2ndShortSide);
            Controls.Add(lbl1stShortSide);
            Controls.Add(label1);
            Controls.Add(txt1stShortSide);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1stShortSide;
        private Label label1;
        private Label lbl1stShortSide;
        private Label lbl2ndShortSide;
        private TextBox txt2ndShortSide;
        private Button btnCalcHypotenuse;
        private TextBox txtOutput;
    }
}