namespace RestaurantManager.Forms
{
    partial class ReservationsForm
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
            this.takeTableButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modifyTableStateButton = new System.Windows.Forms.Button();
            this.SelectStateLabel = new System.Windows.Forms.Label();
            this.stateDropDown = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(110, 246);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(87, 23);
            this.reserveButton.TabIndex = 0;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // takeTableButton
            // 
            this.takeTableButton.Location = new System.Drawing.Point(110, 286);
            this.takeTableButton.Name = "takeTableButton";
            this.takeTableButton.Size = new System.Drawing.Size(87, 23);
            this.takeTableButton.TabIndex = 4;
            this.takeTableButton.Text = "Take table";
            this.takeTableButton.UseVisualStyleBackColor = true;
            this.takeTableButton.Click += new System.EventHandler(this.takeTableButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Table name";
            // 
            // modifyTableStateButton
            // 
            this.modifyTableStateButton.Location = new System.Drawing.Point(110, 376);
            this.modifyTableStateButton.Name = "modifyTableStateButton";
            this.modifyTableStateButton.Size = new System.Drawing.Size(102, 23);
            this.modifyTableStateButton.TabIndex = 7;
            this.modifyTableStateButton.Text = "Modify table state";
            this.modifyTableStateButton.UseVisualStyleBackColor = true;
            this.modifyTableStateButton.Click += new System.EventHandler(this.modifyTableStateButton_Click);
            // 
            // SelectStateLabel
            // 
            this.SelectStateLabel.AutoSize = true;
            this.SelectStateLabel.Location = new System.Drawing.Point(34, 342);
            this.SelectStateLabel.Name = "SelectStateLabel";
            this.SelectStateLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectStateLabel.TabIndex = 8;
            this.SelectStateLabel.Text = "Select state";
            // 
            // stateDropDown
            // 
            this.stateDropDown.FormattingEnabled = true;
            this.stateDropDown.Location = new System.Drawing.Point(103, 339);
            this.stateDropDown.Name = "stateDropDown";
            this.stateDropDown.Size = new System.Drawing.Size(121, 21);
            this.stateDropDown.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(40, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 159);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.stateDropDown);
            this.Controls.Add(this.SelectStateLabel);
            this.Controls.Add(this.modifyTableStateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.takeTableButton);
            this.Controls.Add(this.reserveButton);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button takeTableButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modifyTableStateButton;
        private System.Windows.Forms.Label SelectStateLabel;
        private System.Windows.Forms.ComboBox stateDropDown;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}