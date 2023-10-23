namespace VendingMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMenuItems = new System.Windows.Forms.Label();
            this.btnChocolate = new System.Windows.Forms.Button();
            this.btnCrisps = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(48, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(34, 13);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu";
            // 
            // lblMenuItems
            // 
            this.lblMenuItems.AutoSize = true;
            this.lblMenuItems.Location = new System.Drawing.Point(48, 47);
            this.lblMenuItems.Name = "lblMenuItems";
            this.lblMenuItems.Size = new System.Drawing.Size(124, 13);
            this.lblMenuItems.TabIndex = 6;
            this.lblMenuItems.Text = "Chocolate, Crisps, Water";
            // 
            // btnChocolate
            // 
            this.btnChocolate.Location = new System.Drawing.Point(93, 108);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(613, 23);
            this.btnChocolate.TabIndex = 7;
            this.btnChocolate.Text = "Vend Chocolate";
            this.btnChocolate.UseVisualStyleBackColor = true;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click_1);
            // 
            // btnCrisps
            // 
            this.btnCrisps.Location = new System.Drawing.Point(93, 153);
            this.btnCrisps.Name = "btnCrisps";
            this.btnCrisps.Size = new System.Drawing.Size(613, 23);
            this.btnCrisps.TabIndex = 8;
            this.btnCrisps.Text = "Vend Crisps";
            this.btnCrisps.UseVisualStyleBackColor = true;
            this.btnCrisps.Click += new System.EventHandler(this.btnCrisps_Click);
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(93, 200);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(613, 23);
            this.btnWater.TabIndex = 9;
            this.btnWater.Text = "Vend Water";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnCrisps);
            this.Controls.Add(this.btnChocolate);
            this.Controls.Add(this.lblMenuItems);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMenuItems;
        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnCrisps;
        private System.Windows.Forms.Button btnWater;
    }
}

