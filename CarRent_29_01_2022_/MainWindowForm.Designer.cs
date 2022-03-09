
namespace CarRent_29_01_2022_
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageVechicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRentalRecords = new System.Windows.Forms.DataGridView();
            this.bRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageVechicleToolStripMenuItem,
            this.manageRentalToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageVechicleToolStripMenuItem
            // 
            this.manageVechicleToolStripMenuItem.Name = "manageVechicleToolStripMenuItem";
            this.manageVechicleToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.manageVechicleToolStripMenuItem.Text = "Manage vechicle";
            // 
            // manageRentalToolStripMenuItem
            // 
            this.manageRentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalToolStripMenuItem,
            this.editRentalToolStripMenuItem,
            this.viewArchiveToolStripMenuItem});
            this.manageRentalToolStripMenuItem.Name = "manageRentalToolStripMenuItem";
            this.manageRentalToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.manageRentalToolStripMenuItem.Text = "Manage rental";
            // 
            // addRentalToolStripMenuItem
            // 
            this.addRentalToolStripMenuItem.Name = "addRentalToolStripMenuItem";
            this.addRentalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRentalToolStripMenuItem.Text = "Add rental";
            this.addRentalToolStripMenuItem.Click += new System.EventHandler(this.addRentalToolStripMenuItem_Click);
            // 
            // editRentalToolStripMenuItem
            // 
            this.editRentalToolStripMenuItem.Name = "editRentalToolStripMenuItem";
            this.editRentalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editRentalToolStripMenuItem.Text = "Edit rental";
            this.editRentalToolStripMenuItem.Click += new System.EventHandler(this.editRentalToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewArchiveToolStripMenuItem.Text = "View archive";
            this.viewArchiveToolStripMenuItem.Click += new System.EventHandler(this.viewArchiveToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.manageUsersToolStripMenuItem.Text = "Manage users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // dgvRentalRecords
            // 
            this.dgvRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecords.Location = new System.Drawing.Point(12, 31);
            this.dgvRentalRecords.Name = "dgvRentalRecords";
            this.dgvRentalRecords.RowHeadersWidth = 51;
            this.dgvRentalRecords.RowTemplate.Height = 24;
            this.dgvRentalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalRecords.Size = new System.Drawing.Size(776, 347);
            this.dgvRentalRecords.TabIndex = 1;
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(263, 399);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(210, 39);
            this.bRefresh.TabIndex = 2;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.dgvRentalRecords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageVechicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRentalRecords;
        private System.Windows.Forms.Button bRefresh;
    }
}