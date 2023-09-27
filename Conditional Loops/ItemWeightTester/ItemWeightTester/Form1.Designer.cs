namespace ItemWeightTester
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
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRejectOrAccept = new System.Windows.Forms.Button();
            this.lblTestAgain = new System.Windows.Forms.Label();
            this.txtTestAgain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(66, 53);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(175, 42);
            this.txtWeight.TabIndex = 0;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(63, 37);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(153, 13);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Input the weight of the tin in kg";
            this.lblWeight.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(66, 172);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(175, 42);
            this.txtOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnRejectOrAccept
            // 
            this.btnRejectOrAccept.Location = new System.Drawing.Point(46, 121);
            this.btnRejectOrAccept.Name = "btnRejectOrAccept";
            this.btnRejectOrAccept.Size = new System.Drawing.Size(212, 23);
            this.btnRejectOrAccept.TabIndex = 4;
            this.btnRejectOrAccept.Text = "Reject or Accept?";
            this.btnRejectOrAccept.UseVisualStyleBackColor = true;
            this.btnRejectOrAccept.Click += new System.EventHandler(this.btnRejectOrAccept_Click);
            // 
            // lblTestAgain
            // 
            this.lblTestAgain.AutoSize = true;
            this.lblTestAgain.Location = new System.Drawing.Point(63, 256);
            this.lblTestAgain.Name = "lblTestAgain";
            this.lblTestAgain.Size = new System.Drawing.Size(158, 13);
            this.lblTestAgain.TabIndex = 5;
            this.lblTestAgain.Text = "Do you want to test another tin?";
            this.lblTestAgain.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTestAgain
            // 
            this.txtTestAgain.Location = new System.Drawing.Point(66, 272);
            this.txtTestAgain.Multiline = true;
            this.txtTestAgain.Name = "txtTestAgain";
            this.txtTestAgain.Size = new System.Drawing.Size(175, 42);
            this.txtTestAgain.TabIndex = 6;
            this.txtTestAgain.TextChanged += new System.EventHandler(this.btnOnChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ItemWeightTester.Properties.Resources.royal_dansk_tins_b4f6852baa6c1910f058d70a0a2bad75c6af3ded;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestAgain);
            this.Controls.Add(this.lblTestAgain);
            this.Controls.Add(this.btnRejectOrAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRejectOrAccept;
        private System.Windows.Forms.Label lblTestAgain;
        private System.Windows.Forms.TextBox txtTestAgain;
    }
}

