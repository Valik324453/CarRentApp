
namespace CarRent_29_01_2022_
{
    partial class AddEditRentalForm
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
            this.lCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lCost = new System.Windows.Forms.Label();
            this.lDateReturned = new System.Windows.Forms.Label();
            this.lDateRented = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lTypesOfCars = new System.Windows.Forms.Label();
            this.cbTypesOfCars = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.BackColor = System.Drawing.Color.White;
            this.lCustomerName.Location = new System.Drawing.Point(70, 90);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(105, 17);
            this.lCustomerName.TabIndex = 0;
            this.lCustomerName.Text = "CustomerName";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(229, 87);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(200, 22);
            this.tbCustomerName.TabIndex = 1;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(229, 147);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(200, 22);
            this.tbCost.TabIndex = 3;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(70, 150);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(36, 17);
            this.lCost.TabIndex = 2;
            this.lCost.Text = "Cost";
            // 
            // lDateReturned
            // 
            this.lDateReturned.AutoSize = true;
            this.lDateReturned.Location = new System.Drawing.Point(70, 269);
            this.lDateReturned.Name = "lDateReturned";
            this.lDateReturned.Size = new System.Drawing.Size(96, 17);
            this.lDateReturned.TabIndex = 6;
            this.lDateReturned.Text = "Date returned";
            // 
            // lDateRented
            // 
            this.lDateRented.AutoSize = true;
            this.lDateRented.Location = new System.Drawing.Point(70, 209);
            this.lDateRented.Name = "lDateRented";
            this.lDateRented.Size = new System.Drawing.Size(83, 17);
            this.lDateRented.TabIndex = 4;
            this.lDateRented.Text = "Date rented";
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Location = new System.Drawing.Point(229, 203);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(200, 22);
            this.dtpDateRented.TabIndex = 7;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Location = new System.Drawing.Point(229, 264);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(200, 22);
            this.dtpDateReturned.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(575, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 88);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lTypesOfCars
            // 
            this.lTypesOfCars.AutoSize = true;
            this.lTypesOfCars.Location = new System.Drawing.Point(70, 331);
            this.lTypesOfCars.Name = "lTypesOfCars";
            this.lTypesOfCars.Size = new System.Drawing.Size(94, 17);
            this.lTypesOfCars.TabIndex = 9;
            this.lTypesOfCars.Text = "Types of cars";
            // 
            // cbTypesOfCars
            // 
            this.cbTypesOfCars.FormattingEnabled = true;
            this.cbTypesOfCars.Location = new System.Drawing.Point(229, 328);
            this.cbTypesOfCars.Name = "cbTypesOfCars";
            this.cbTypesOfCars.Size = new System.Drawing.Size(200, 24);
            this.cbTypesOfCars.TabIndex = 10;
            // 
            // AddEditRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRent_29_01_2022_.Properties.Resources._117310488_16;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTypesOfCars);
            this.Controls.Add(this.lTypesOfCars);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.lDateReturned);
            this.Controls.Add(this.lDateRented);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lCustomerName);
            this.Name = "AddEditRentalForm";
            this.Text = "AddEditRentalForm";
            this.Load += new System.EventHandler(this.AddEditRentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Label lDateReturned;
        private System.Windows.Forms.Label lDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lTypesOfCars;
        private System.Windows.Forms.ComboBox cbTypesOfCars;
    }
}