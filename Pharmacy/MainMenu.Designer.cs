namespace Pharmacy
{
    partial class MainMenu
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
            this.medicinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precriptionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicinesToolStripMenuItem,
            this.prescriptionsToolStripMenuItem,
            this.salesToolStripMenuItem1,
            this.inventoryToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // medicinesToolStripMenuItem
            // 
            this.medicinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addMedicineToolStripMenuItem,
            this.editMedicineToolStripMenuItem,
            this.deleteMedicineToolStripMenuItem});
            this.medicinesToolStripMenuItem.Name = "medicinesToolStripMenuItem";
            this.medicinesToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.medicinesToolStripMenuItem.Text = "Medicines";
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.showDetailsToolStripMenuItem.Text = "Medicines Stock";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addMedicineToolStripMenuItem
            // 
            this.addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            this.addMedicineToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.addMedicineToolStripMenuItem.Text = "Add Medicine";
            this.addMedicineToolStripMenuItem.Click += new System.EventHandler(this.addMedicineToolStripMenuItem_Click);
            // 
            // editMedicineToolStripMenuItem
            // 
            this.editMedicineToolStripMenuItem.Name = "editMedicineToolStripMenuItem";
            this.editMedicineToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.editMedicineToolStripMenuItem.Text = "Edit Medicine";
            this.editMedicineToolStripMenuItem.Click += new System.EventHandler(this.editMedicineToolStripMenuItem_Click);
            // 
            // deleteMedicineToolStripMenuItem
            // 
            this.deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
            this.deleteMedicineToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.deleteMedicineToolStripMenuItem.Text = "Delete Medicine";
            this.deleteMedicineToolStripMenuItem.Click += new System.EventHandler(this.deleteMedicineToolStripMenuItem_Click);
            // 
            // prescriptionsToolStripMenuItem
            // 
            this.prescriptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.precriptionInfoToolStripMenuItem,
            this.addPrescriptionToolStripMenuItem,
            this.deletePrescriptionToolStripMenuItem});
            this.prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            this.prescriptionsToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.prescriptionsToolStripMenuItem.Text = "Prescriptions";
            // 
            // precriptionInfoToolStripMenuItem
            // 
            this.precriptionInfoToolStripMenuItem.Name = "precriptionInfoToolStripMenuItem";
            this.precriptionInfoToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.precriptionInfoToolStripMenuItem.Text = "View Precriptions";
            this.precriptionInfoToolStripMenuItem.Click += new System.EventHandler(this.precriptionInfoToolStripMenuItem_Click);
            // 
            // addPrescriptionToolStripMenuItem
            // 
            this.addPrescriptionToolStripMenuItem.Name = "addPrescriptionToolStripMenuItem";
            this.addPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.addPrescriptionToolStripMenuItem.Text = "Add Prescription";
            this.addPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.addPrescriptionToolStripMenuItem_Click);
            // 
            // deletePrescriptionToolStripMenuItem
            // 
            this.deletePrescriptionToolStripMenuItem.Name = "deletePrescriptionToolStripMenuItem";
            this.deletePrescriptionToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.deletePrescriptionToolStripMenuItem.Text = "Delete Prescription";
            this.deletePrescriptionToolStripMenuItem.Click += new System.EventHandler(this.deletePrescriptionToolStripMenuItem_Click_1);
            // 
            // salesToolStripMenuItem1
            // 
            this.salesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesDetailToolStripMenuItem,
            this.makeSaleToolStripMenuItem});
            this.salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            this.salesToolStripMenuItem1.Size = new System.Drawing.Size(73, 29);
            this.salesToolStripMenuItem1.Text = "Sales";
            // 
            // salesDetailToolStripMenuItem
            // 
            this.salesDetailToolStripMenuItem.Name = "salesDetailToolStripMenuItem";
            this.salesDetailToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.salesDetailToolStripMenuItem.Text = "Show Sales";
            this.salesDetailToolStripMenuItem.Click += new System.EventHandler(this.salesDetailToolStripMenuItem_Click);
            // 
            // makeSaleToolStripMenuItem
            // 
            this.makeSaleToolStripMenuItem.Name = "makeSaleToolStripMenuItem";
            this.makeSaleToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.makeSaleToolStripMenuItem.Text = "Make Sale";
            this.makeSaleToolStripMenuItem.Click += new System.EventHandler(this.makeSaleToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // showInventoryToolStripMenuItem
            // 
            this.showInventoryToolStripMenuItem.Name = "showInventoryToolStripMenuItem";
            this.showInventoryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.showInventoryToolStripMenuItem.Text = "Show Inventory";
            this.showInventoryToolStripMenuItem.Click += new System.EventHandler(this.showInventoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aAToolStripMenuItem,
            this.viewCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.searchCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // aAToolStripMenuItem
            // 
            this.aAToolStripMenuItem.Name = "aAToolStripMenuItem";
            this.aAToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.aAToolStripMenuItem.Text = "Add Customer";
            this.aAToolStripMenuItem.Click += new System.EventHandler(this.aAToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.deleteToolStripMenuItem.Text = "Delete Customer";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchCustomerToolStripMenuItem
            // 
            this.searchCustomerToolStripMenuItem.Name = "searchCustomerToolStripMenuItem";
            this.searchCustomerToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.searchCustomerToolStripMenuItem.Text = "Search Customer";
            this.searchCustomerToolStripMenuItem.Click += new System.EventHandler(this.searchCustomerToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precriptionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerToolStripMenuItem;
    }
}