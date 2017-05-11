namespace South_Tech_Project
{
    partial class FacilityManagement
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnEmplooyees = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnPatients);
            this.flowLayoutPanel1.Controls.Add(this.btnEmplooyees);
            this.flowLayoutPanel1.Controls.Add(this.btnStock);
            this.flowLayoutPanel1.Controls.Add(this.btnHistory);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(750, 328);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnPatients
            // 
            this.btnPatients.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPatients.Location = new System.Drawing.Point(3, 3);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(369, 158);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnEmplooyees
            // 
            this.btnEmplooyees.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmplooyees.Location = new System.Drawing.Point(378, 3);
            this.btnEmplooyees.Name = "btnEmplooyees";
            this.btnEmplooyees.Size = new System.Drawing.Size(369, 158);
            this.btnEmplooyees.TabIndex = 1;
            this.btnEmplooyees.Text = "Employees";
            this.btnEmplooyees.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStock.Location = new System.Drawing.Point(3, 167);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(369, 158);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistory.Location = new System.Drawing.Point(378, 167);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(369, 158);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Check in / Check Out";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // FacilityManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FacilityManagement";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Facility Management";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnEmplooyees;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnHistory;
    }
}