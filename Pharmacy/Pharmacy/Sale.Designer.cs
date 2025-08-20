namespace Pharmacy
{
    partial class Sale
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
            this.btnADD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalePrescriptionID = new System.Windows.Forms.TextBox();
            this.txtSaleStaffId = new System.Windows.Forms.TextBox();
            this.txtSaleTotalAmount = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(318, 140);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(100, 43);
            this.btnADD.TabIndex = 26;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "StaffID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Prescription ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sale ID:";
            // 
            // txtSalePrescriptionID
            // 
            this.txtSalePrescriptionID.Location = new System.Drawing.Point(568, 20);
            this.txtSalePrescriptionID.Name = "txtSalePrescriptionID";
            this.txtSalePrescriptionID.Size = new System.Drawing.Size(100, 26);
            this.txtSalePrescriptionID.TabIndex = 20;
            // 
            // txtSaleStaffId
            // 
            this.txtSaleStaffId.Location = new System.Drawing.Point(568, 70);
            this.txtSaleStaffId.Name = "txtSaleStaffId";
            this.txtSaleStaffId.Size = new System.Drawing.Size(100, 26);
            this.txtSaleStaffId.TabIndex = 19;
            // 
            // txtSaleTotalAmount
            // 
            this.txtSaleTotalAmount.Location = new System.Drawing.Point(139, 73);
            this.txtSaleTotalAmount.Name = "txtSaleTotalAmount";
            this.txtSaleTotalAmount.ReadOnly = true;
            this.txtSaleTotalAmount.Size = new System.Drawing.Size(100, 26);
            this.txtSaleTotalAmount.TabIndex = 18;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(152, 17);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(100, 26);
            this.txtSaleID.TabIndex = 16;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalePrescriptionID);
            this.Controls.Add(this.txtSaleStaffId);
            this.Controls.Add(this.txtSaleTotalAmount);
            this.Controls.Add(this.txtSaleID);
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalePrescriptionID;
        private System.Windows.Forms.TextBox txtSaleStaffId;
        private System.Windows.Forms.TextBox txtSaleTotalAmount;
        private System.Windows.Forms.TextBox txtSaleID;
    }
}