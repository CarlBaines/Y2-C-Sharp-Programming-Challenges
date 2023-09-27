namespace VowelOrConsonant
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
            this.txtoneLetter = new System.Windows.Forms.TextBox();
            this.lbloneLetter = new System.Windows.Forms.Label();
            this.btnVorC = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtoneLetter
            // 
            this.txtoneLetter.Location = new System.Drawing.Point(146, 55);
            this.txtoneLetter.Multiline = true;
            this.txtoneLetter.Name = "txtoneLetter";
            this.txtoneLetter.Size = new System.Drawing.Size(240, 34);
            this.txtoneLetter.TabIndex = 0;
            this.txtoneLetter.TextChanged += new System.EventHandler(this.txtoneLetter_TextChanged);
            // 
            // lbloneLetter
            // 
            this.lbloneLetter.AutoSize = true;
            this.lbloneLetter.Location = new System.Drawing.Point(143, 39);
            this.lbloneLetter.Name = "lbloneLetter";
            this.lbloneLetter.Size = new System.Drawing.Size(79, 13);
            this.lbloneLetter.TabIndex = 1;
            this.lbloneLetter.Text = "Enter one letter";
            // 
            // btnVorC
            // 
            this.btnVorC.Location = new System.Drawing.Point(95, 112);
            this.btnVorC.Name = "btnVorC";
            this.btnVorC.Size = new System.Drawing.Size(337, 23);
            this.btnVorC.TabIndex = 2;
            this.btnVorC.Text = "Is the letter a vowel or consonant?";
            this.btnVorC.UseVisualStyleBackColor = true;
            this.btnVorC.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(146, 189);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(240, 34);
            this.txtOutput.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(143, 173);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VowelOrConsonant.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnVorC);
            this.Controls.Add(this.lbloneLetter);
            this.Controls.Add(this.txtoneLetter);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtoneLetter;
        private System.Windows.Forms.Label lbloneLetter;
        private System.Windows.Forms.Button btnVorC;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

