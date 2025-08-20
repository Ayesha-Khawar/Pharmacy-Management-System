namespace Pharmacy
{
    partial class addMedicine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtMedicineDosage = new System.Windows.Forms.TextBox();
            this.txtMedicinePrice = new System.Windows.Forms.TextBox();
            this.txtMedicineQuantity = new System.Windows.Forms.TextBox();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(333, 197);
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
            this.label5.Location = new System.Drawing.Point(46, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dosage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medicine ID:";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(522, 20);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(100, 26);
            this.txtMedicineName.TabIndex = 20;
            // 
            // txtMedicineDosage
            // 
            this.txtMedicineDosage.Location = new System.Drawing.Point(139, 84);
            this.txtMedicineDosage.Name = "txtMedicineDosage";
            this.txtMedicineDosage.Size = new System.Drawing.Size(100, 26);
            this.txtMedicineDosage.TabIndex = 19;
            // 
            // txtMedicinePrice
            // 
            this.txtMedicinePrice.Location = new System.Drawing.Point(522, 84);
            this.txtMedicinePrice.Name = "txtMedicinePrice";
            this.txtMedicinePrice.Size = new System.Drawing.Size(100, 26);
            this.txtMedicinePrice.TabIndex = 18;
            // 
            // txtMedicineQuantity
            // 
            this.txtMedicineQuantity.Location = new System.Drawing.Point(139, 145);
            this.txtMedicineQuantity.Name = "txtMedicineQuantity";
            this.txtMedicineQuantity.Size = new System.Drawing.Size(100, 26);
            this.txtMedicineQuantity.TabIndex = 17;
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Location = new System.Drawing.Point(139, 17);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.Size = new System.Drawing.Size(100, 26);
            this.txtMedicineID.TabIndex = 16;
            // 
            // addMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.txtMedicineDosage);
            this.Controls.Add(this.txtMedicinePrice);
            this.Controls.Add(this.txtMedicineQuantity);
            this.Controls.Add(this.txtMedicineID);
            this.Name = "addMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addMedicine";
            this.Load += new System.EventHandler(this.addMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtMedicineDosage;
        private System.Windows.Forms.TextBox txtMedicinePrice;
        private System.Windows.Forms.TextBox txtMedicineQuantity;
        private System.Windows.Forms.TextBox txtMedicineID;
    }
}