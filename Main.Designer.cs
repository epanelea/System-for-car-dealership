namespace Coursework
{
    partial class Main
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
            this.Admin1 = new System.Windows.Forms.Button();
            this.Customer1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin1
            // 
            this.Admin1.Location = new System.Drawing.Point(44, 133);
            this.Admin1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin1.Name = "Admin1";
            this.Admin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Admin1.Size = new System.Drawing.Size(172, 37);
            this.Admin1.TabIndex = 0;
            this.Admin1.Text = "Admin";
            this.Admin1.UseVisualStyleBackColor = true;
            this.Admin1.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Customer1
            // 
            this.Customer1.Location = new System.Drawing.Point(289, 133);
            this.Customer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Customer1.Name = "Customer1";
            this.Customer1.Size = new System.Drawing.Size(163, 37);
            this.Customer1.TabIndex = 1;
            this.Customer1.Text = "Customer";
            this.Customer1.UseVisualStyleBackColor = true;
            this.Customer1.Click += new System.EventHandler(this.Customer1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 319);
            this.Controls.Add(this.Customer1);
            this.Controls.Add(this.Admin1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Admin1;
        private System.Windows.Forms.Button Customer1;
    }
}

