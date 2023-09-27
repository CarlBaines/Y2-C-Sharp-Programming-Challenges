namespace TimesTableDisplayer
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
            this.txtFourTimesTable = new System.Windows.Forms.TextBox();
            this.btnFourTimesTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFourTimesTable
            // 
            this.txtFourTimesTable.Location = new System.Drawing.Point(43, 44);
            this.txtFourTimesTable.Multiline = true;
            this.txtFourTimesTable.Name = "txtFourTimesTable";
            this.txtFourTimesTable.Size = new System.Drawing.Size(401, 229);
            this.txtFourTimesTable.TabIndex = 0;
            this.txtFourTimesTable.Text = "4 times table...";
            this.txtFourTimesTable.TextChanged += new System.EventHandler(this.txtFourTimesTable_TextChanged);
            // 
            // btnFourTimesTable
            // 
            this.btnFourTimesTable.Location = new System.Drawing.Point(137, 303);
            this.btnFourTimesTable.Name = "btnFourTimesTable";
            this.btnFourTimesTable.Size = new System.Drawing.Size(199, 23);
            this.btnFourTimesTable.TabIndex = 1;
            this.btnFourTimesTable.Text = "Display four times table";
            this.btnFourTimesTable.UseVisualStyleBackColor = true;
            this.btnFourTimesTable.Click += new System.EventHandler(this.btnFourTimesTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFourTimesTable);
            this.Controls.Add(this.txtFourTimesTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFourTimesTable;
        private System.Windows.Forms.Button btnFourTimesTable;
    }
}

