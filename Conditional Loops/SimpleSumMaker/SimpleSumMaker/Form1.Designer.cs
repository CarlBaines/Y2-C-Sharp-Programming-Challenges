namespace SimpleSumMaker
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
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.lblUserAnswer = new System.Windows.Forms.Label();
            this.btnCorrectOrIncorrect = new System.Windows.Forms.Button();
            this.txtCorrectOrIncorrect = new System.Windows.Forms.TextBox();
            this.btnTryAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(58, 209);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(195, 44);
            this.txtSum.TabIndex = 0;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(58, 190);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "Sum";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Location = new System.Drawing.Point(58, 277);
            this.txtUserAnswer.Multiline = true;
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(195, 44);
            this.txtUserAnswer.TabIndex = 2;
            // 
            // lblUserAnswer
            // 
            this.lblUserAnswer.AutoSize = true;
            this.lblUserAnswer.Location = new System.Drawing.Point(55, 261);
            this.lblUserAnswer.Name = "lblUserAnswer";
            this.lblUserAnswer.Size = new System.Drawing.Size(91, 13);
            this.lblUserAnswer.TabIndex = 3;
            this.lblUserAnswer.Text = "Type your answer";
            // 
            // btnCorrectOrIncorrect
            // 
            this.btnCorrectOrIncorrect.Location = new System.Drawing.Point(281, 253);
            this.btnCorrectOrIncorrect.Name = "btnCorrectOrIncorrect";
            this.btnCorrectOrIncorrect.Size = new System.Drawing.Size(210, 28);
            this.btnCorrectOrIncorrect.TabIndex = 4;
            this.btnCorrectOrIncorrect.Text = "Did you answer the question correctly?";
            this.btnCorrectOrIncorrect.UseVisualStyleBackColor = true;
            this.btnCorrectOrIncorrect.Click += new System.EventHandler(this.btnCorrectOrIncorrect_Click);
            // 
            // txtCorrectOrIncorrect
            // 
            this.txtCorrectOrIncorrect.Location = new System.Drawing.Point(520, 242);
            this.txtCorrectOrIncorrect.Multiline = true;
            this.txtCorrectOrIncorrect.Name = "txtCorrectOrIncorrect";
            this.txtCorrectOrIncorrect.Size = new System.Drawing.Size(174, 54);
            this.txtCorrectOrIncorrect.TabIndex = 5;
            this.txtCorrectOrIncorrect.TextChanged += new System.EventHandler(this.txtCorrectOrIncorrect_TextChanged);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Location = new System.Drawing.Point(568, 302);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(75, 35);
            this.btnTryAgain.TabIndex = 6;
            this.btnTryAgain.Text = "Try Again";
            this.btnTryAgain.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleSumMaker.Properties.Resources._62facbc3d681c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTryAgain);
            this.Controls.Add(this.txtCorrectOrIncorrect);
            this.Controls.Add(this.btnCorrectOrIncorrect);
            this.Controls.Add(this.lblUserAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Label lblUserAnswer;
        private System.Windows.Forms.Button btnCorrectOrIncorrect;
        private System.Windows.Forms.TextBox txtCorrectOrIncorrect;
        private System.Windows.Forms.Button btnTryAgain;
    }
}

