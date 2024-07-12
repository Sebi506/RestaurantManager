namespace RestaurantManager.Forms
{
    partial class ManagerForm
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
            this.setOwnerButton = new System.Windows.Forms.Button();
            this.ownerEmailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addServerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.serverEmailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.restaurantStateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableNameTB = new System.Windows.Forms.TextBox();
            this.capacityTB = new System.Windows.Forms.TextBox();
            this.removeTableButton = new System.Windows.Forms.Button();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.vipTableButton = new System.Windows.Forms.Button();
            this.privateTableButton = new System.Windows.Forms.Button();
            this.tDetailsTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setOwnerButton
            // 
            this.setOwnerButton.Location = new System.Drawing.Point(42, 42);
            this.setOwnerButton.Name = "setOwnerButton";
            this.setOwnerButton.Size = new System.Drawing.Size(75, 23);
            this.setOwnerButton.TabIndex = 0;
            this.setOwnerButton.Text = "Set Owner";
            this.setOwnerButton.UseVisualStyleBackColor = true;
            // 
            // ownerEmailTB
            // 
            this.ownerEmailTB.Location = new System.Drawing.Point(199, 44);
            this.ownerEmailTB.Name = "ownerEmailTB";
            this.ownerEmailTB.Size = new System.Drawing.Size(153, 20);
            this.ownerEmailTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(32, 106);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(94, 23);
            this.addServerButton.TabIndex = 3;
            this.addServerButton.Text = "Add Server";
            this.addServerButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // serverEmailTB
            // 
            this.serverEmailTB.Location = new System.Drawing.Point(199, 125);
            this.serverEmailTB.Name = "serverEmailTB";
            this.serverEmailTB.Size = new System.Drawing.Size(153, 20);
            this.serverEmailTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 11;
            // 
            // restaurantStateButton
            // 
            this.restaurantStateButton.Location = new System.Drawing.Point(42, 263);
            this.restaurantStateButton.Name = "restaurantStateButton";
            this.restaurantStateButton.Size = new System.Drawing.Size(126, 23);
            this.restaurantStateButton.TabIndex = 12;
            this.restaurantStateButton.Text = "Open restaurant";
            this.restaurantStateButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Table Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Capacity";
            // 
            // tableNameTB
            // 
            this.tableNameTB.Location = new System.Drawing.Point(120, 385);
            this.tableNameTB.Name = "tableNameTB";
            this.tableNameTB.Size = new System.Drawing.Size(198, 20);
            this.tableNameTB.TabIndex = 17;
            // 
            // capacityTB
            // 
            this.capacityTB.Location = new System.Drawing.Point(120, 418);
            this.capacityTB.Name = "capacityTB";
            this.capacityTB.Size = new System.Drawing.Size(48, 20);
            this.capacityTB.TabIndex = 18;
            this.capacityTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // removeTableButton
            // 
            this.removeTableButton.Location = new System.Drawing.Point(139, 456);
            this.removeTableButton.Name = "removeTableButton";
            this.removeTableButton.Size = new System.Drawing.Size(85, 23);
            this.removeTableButton.TabIndex = 19;
            this.removeTableButton.Text = "Remove table";
            this.removeTableButton.UseVisualStyleBackColor = true;
            // 
            // updateTableButton
            // 
            this.updateTableButton.Location = new System.Drawing.Point(246, 456);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(85, 23);
            this.updateTableButton.TabIndex = 20;
            this.updateTableButton.Text = "Update table";
            this.updateTableButton.UseVisualStyleBackColor = true;
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(32, 135);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(94, 23);
            this.removeServerButton.TabIndex = 21;
            this.removeServerButton.Text = "Remove Server";
            this.removeServerButton.UseVisualStyleBackColor = true;
            // 
            // addTableButton
            // 
            this.addTableButton.Location = new System.Drawing.Point(32, 456);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(85, 23);
            this.addTableButton.TabIndex = 13;
            this.addTableButton.Text = "Add table";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // vipTableButton
            // 
            this.vipTableButton.Location = new System.Drawing.Point(32, 485);
            this.vipTableButton.Name = "vipTableButton";
            this.vipTableButton.Size = new System.Drawing.Size(85, 23);
            this.vipTableButton.TabIndex = 22;
            this.vipTableButton.Text = "Vip table";
            this.vipTableButton.UseVisualStyleBackColor = true;
            this.vipTableButton.Click += new System.EventHandler(this.vipTableButton_Click);
            // 
            // privateTableButton
            // 
            this.privateTableButton.Location = new System.Drawing.Point(139, 485);
            this.privateTableButton.Name = "privateTableButton";
            this.privateTableButton.Size = new System.Drawing.Size(85, 23);
            this.privateTableButton.TabIndex = 23;
            this.privateTableButton.Text = "Private table";
            this.privateTableButton.UseVisualStyleBackColor = true;
            this.privateTableButton.Click += new System.EventHandler(this.privateTableButton_Click);
            // 
            // tDetailsTB
            // 
            this.tDetailsTB.Location = new System.Drawing.Point(139, 520);
            this.tDetailsTB.Name = "tDetailsTB";
            this.tDetailsTB.Size = new System.Drawing.Size(179, 20);
            this.tDetailsTB.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Table details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tDetailsTB);
            this.Controls.Add(this.privateTableButton);
            this.Controls.Add(this.vipTableButton);
            this.Controls.Add(this.removeServerButton);
            this.Controls.Add(this.updateTableButton);
            this.Controls.Add(this.removeTableButton);
            this.Controls.Add(this.capacityTB);
            this.Controls.Add(this.tableNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.restaurantStateButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverEmailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownerEmailTB);
            this.Controls.Add(this.setOwnerButton);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setOwnerButton;
        private System.Windows.Forms.TextBox ownerEmailTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addServerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverEmailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button restaurantStateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tableNameTB;
        private System.Windows.Forms.TextBox capacityTB;
        private System.Windows.Forms.Button removeTableButton;
        private System.Windows.Forms.Button updateTableButton;
        private System.Windows.Forms.Button removeServerButton;
        private System.Windows.Forms.Button addTableButton;
        private System.Windows.Forms.Button vipTableButton;
        private System.Windows.Forms.Button privateTableButton;
        private System.Windows.Forms.TextBox tDetailsTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}