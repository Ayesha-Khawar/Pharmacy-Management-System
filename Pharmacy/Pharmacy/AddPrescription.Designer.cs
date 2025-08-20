namespace Pharmacy
{
    partial class AddPrescription
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
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.txtPrescriptionMedQTY = new System.Windows.Forms.TextBox();
            this.txtPrescriptionMedicineID = new System.Windows.Forms.TextBox();
            this.txtPrescriptionIssueDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtPrescriptionCustID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(167, 15);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.Size = new System.Drawing.Size(100, 26);
            this.txtPrescriptionID.TabIndex = 33;
            // 
            // txtPrescriptionMedQTY
            // 
            this.txtPrescriptionMedQTY.Location = new System.Drawing.Point(468, 74);
            this.txtPrescriptionMedQTY.Name = "txtPrescriptionMedQTY";
            this.txtPrescriptionMedQTY.Size = new System.Drawing.Size(100, 26);
            this.txtPrescriptionMedQTY.TabIndex = 34;
            // 
            // txtPrescriptionMedicineID
            // 
            this.txtPrescriptionMedicineID.Location = new System.Drawing.Point(136, 71);
            this.txtPrescriptionMedicineID.Name = "txtPrescriptionMedicineID";
            this.txtPrescriptionMedicineID.Size = new System.Drawing.Size(100, 26);
            this.txtPrescriptionMedicineID.TabIndex = 35;
            // 
            // txtPrescriptionIssueDate
            // 
            this.txtPrescriptionIssueDate.Location = new System.Drawing.Point(674, 24);
            this.txtPrescriptionIssueDate.Name = "txtPrescriptionIssueDate";
            this.txtPrescriptionIssueDate.Size = new System.Drawing.Size(100, 26);
            this.txtPrescriptionIssueDate.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Prescription ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Quantity Prescribed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Medicine Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Issue Date:";
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(346, 142);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(100, 43);
            this.btnADD.TabIndex = 42;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtPrescriptionCustID
            // 
            this.txtPrescriptionCustID.Location = new System.Drawing.Point(436, 15);
            this.txtPrescriptionCustID.Name = "txtPrescriptionCustID";
            this.txtPrescriptionCustID.Size = new System.Drawing.Size(100, 26);
            this.txtPrescriptionCustID.TabIndex = 45;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrescriptionCustID);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrescriptionIssueDate);
            this.Controls.Add(this.txtPrescriptionMedicineID);
            this.Controls.Add(this.txtPrescriptionMedQTY);
            this.Controls.Add(this.txtPrescriptionID);
            this.Name = "AddPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPrescription";
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.TextBox txtPrescriptionMedQTY;
        private System.Windows.Forms.TextBox txtPrescriptionMedicineID;
        private System.Windows.Forms.TextBox txtPrescriptionIssueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtPrescriptionCustID;
    }
}