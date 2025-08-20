namespace Pharmacy
{
    partial class searchCustomer
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearchCustomer = new System.Windows.Forms.DataGridView();
            this.btnfindCust = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(278, 75);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(141, 26);
            this.txtCustomerID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // dgvSearchCustomer
            // 
            this.dgvSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCustomer.Location = new System.Drawing.Point(44, 154);
            this.dgvSearchCustomer.Name = "dgvSearchCustomer";
            this.dgvSearchCustomer.RowHeadersWidth = 62;
            this.dgvSearchCustomer.RowTemplate.Height = 28;
            this.dgvSearchCustomer.Size = new System.Drawing.Size(723, 150);
            this.dgvSearchCustomer.TabIndex = 2;
            // 
            // btnfindCust
            // 
            this.btnfindCust.Location = new System.Drawing.Point(464, 72);
            this.btnfindCust.Name = "btnfindCust";
            this.btnfindCust.Size = new System.Drawing.Size(118, 32);
            this.btnfindCust.TabIndex = 3;
            this.btnfindCust.Text = "search";
            this.btnfindCust.UseVisualStyleBackColor = true;
            this.btnfindCust.Click += new System.EventHandler(this.btnfindCust_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prescriptions Information:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Customer Name to find all his prescriptions ";
            // 
            // searchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfindCust);
            this.Controls.Add(this.dgvSearchCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Name = "searchCustomer";
            this.Text = "searchCustomer";
            this.Load += new System.EventHandler(this.searchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearchCustomer;
        private System.Windows.Forms.Button btnfindCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}