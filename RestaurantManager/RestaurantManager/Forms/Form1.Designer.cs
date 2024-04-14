namespace RestaurantManager
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
            this.reserveButton = new System.Windows.Forms.Button();
            this.manageRestaurantButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(111, 158);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(115, 23);
            this.reserveButton.TabIndex = 0;
            this.reserveButton.Text = "Reservations";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // manageRestaurantButton
            // 
            this.manageRestaurantButton.Location = new System.Drawing.Point(111, 201);
            this.manageRestaurantButton.Name = "manageRestaurantButton";
            this.manageRestaurantButton.Size = new System.Drawing.Size(115, 23);
            this.manageRestaurantButton.TabIndex = 1;
            this.manageRestaurantButton.Text = "Restaurant Manager";
            this.manageRestaurantButton.UseVisualStyleBackColor = true;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(111, 293);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(115, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.manageRestaurantButton);
            this.Controls.Add(this.reserveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button manageRestaurantButton;
        private System.Windows.Forms.Button disconnectButton;
    }
}

