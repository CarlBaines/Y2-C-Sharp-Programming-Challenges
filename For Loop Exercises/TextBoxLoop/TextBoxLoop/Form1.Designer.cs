namespace TextBoxLoop
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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtNameLoop = new System.Windows.Forms.TextBox();
            this.btnLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(72, 58);
            this.txtEnterName.Multiline = true;
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(153, 31);
            this.txtEnterName.TabIndex = 0;
            this.txtEnterName.TextChanged += new System.EventHandler(this.txtEnterName_TextChanged);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(72, 39);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(61, 13);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter name";
            this.lblEnterName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNameLoop
            // 
            this.txtNameLoop.Location = new System.Drawing.Point(72, 149);
            this.txtNameLoop.Multiline = true;
            this.txtNameLoop.Name = "txtNameLoop";
            this.txtNameLoop.Size = new System.Drawing.Size(153, 154);
            this.txtNameLoop.TabIndex = 2;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(106, 106);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 3;
            this.btnLoop.Text = "loop name";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.txtNameLoop);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtNameLoop;
        private System.Windows.Forms.Button btnLoop;
    }
}

