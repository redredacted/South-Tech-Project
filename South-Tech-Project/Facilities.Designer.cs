namespace South_Tech_Project
{
    partial class Facilities
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facilities));
            this.dgvFacilities = new System.Windows.Forms.DataGridView();
            this.ctxMenuDG = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacilityToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilities)).BeginInit();
            this.ctxMenuDG.SuspendLayout();
            this.FacilityToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacilities
            // 
            this.dgvFacilities.AllowUserToAddRows = false;
            this.dgvFacilities.AllowUserToDeleteRows = false;
            this.dgvFacilities.AllowUserToResizeRows = false;
            this.dgvFacilities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacilities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFacilities.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvFacilities.ContextMenuStrip = this.ctxMenuDG;
            this.dgvFacilities.Location = new System.Drawing.Point(6, 19);
            this.dgvFacilities.MultiSelect = false;
            this.dgvFacilities.Name = "dgvFacilities";
            this.dgvFacilities.ReadOnly = true;
            this.dgvFacilities.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFacilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacilities.ShowCellErrors = false;
            this.dgvFacilities.ShowCellToolTips = false;
            this.dgvFacilities.ShowEditingIcon = false;
            this.dgvFacilities.ShowRowErrors = false;
            this.dgvFacilities.Size = new System.Drawing.Size(894, 356);
            this.dgvFacilities.TabIndex = 2;
            this.dgvFacilities.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgvFacilities_RowContextMenuStripNeeded);
            // 
            // ctxMenuDG
            // 
            this.ctxMenuDG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ctxMenuDG.Name = "contextMenuStrip1";
            this.ctxMenuDG.Size = new System.Drawing.Size(153, 92);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FacilityToolStrip
            // 
            this.FacilityToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FacilityToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FacilityToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAdd,
            this.toolStripButton3});
            this.FacilityToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FacilityToolStrip.Name = "FacilityToolStrip";
            this.FacilityToolStrip.Size = new System.Drawing.Size(931, 25);
            this.FacilityToolStrip.TabIndex = 3;
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton3.Text = "Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFacilities);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 381);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facility Table";
            // 
            // Facilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FacilityToolStrip);
            this.Name = "Facilities";
            this.Text = "Medical Facilitites";
            this.Load += new System.EventHandler(this.Facilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilities)).EndInit();
            this.ctxMenuDG.ResumeLayout(false);
            this.FacilityToolStrip.ResumeLayout(false);
            this.FacilityToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacilities;
        private System.Windows.Forms.ToolStrip FacilityToolStrip;
        private System.Windows.Forms.ToolStripButton tsBtnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDG;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}

