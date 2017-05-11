namespace South_Tech_Project
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.PatientToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsBtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.PatientToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientToolStrip
            // 
            this.PatientToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.PatientToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.tsBtnInfo,
            this.tsBtnExit});
            this.PatientToolStrip.Location = new System.Drawing.Point(0, 0);
            this.PatientToolStrip.Name = "PatientToolStrip";
            this.PatientToolStrip.Size = new System.Drawing.Size(931, 25);
            this.PatientToolStrip.TabIndex = 4;
            // 
            // tsBtnAdd
            // 
            this.tsBtnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsBtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAdd.Image")));
            this.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAdd.Name = "tsBtnAdd";
            this.tsBtnAdd.Size = new System.Drawing.Size(33, 22);
            this.tsBtnAdd.Text = "Add";
            this.tsBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // tsBtnInfo
            // 
            this.tsBtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnInfo.Image")));
            this.tsBtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnInfo.Name = "tsBtnInfo";
            this.tsBtnInfo.Size = new System.Drawing.Size(32, 22);
            this.tsBtnInfo.Text = "Info";
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(29, 22);
            this.tsBtnExit.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPatients);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 381);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patients Table";
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToResizeRows = false;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPatients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPatients.Location = new System.Drawing.Point(6, 19);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.ShowCellErrors = false;
            this.dgvPatients.ShowCellToolTips = false;
            this.dgvPatients.ShowEditingIcon = false;
            this.dgvPatients.ShowRowErrors = false;
            this.dgvPatients.Size = new System.Drawing.Size(895, 356);
            this.dgvPatients.TabIndex = 2;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PatientToolStrip);
            this.Name = "Patients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.PatientToolStrip.ResumeLayout(false);
            this.PatientToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip PatientToolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.ToolStripButton tsBtnInfo;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}