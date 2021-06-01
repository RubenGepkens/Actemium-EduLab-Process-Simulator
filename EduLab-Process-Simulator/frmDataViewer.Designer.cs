
namespace EduLab_Process_Simulator
{
    partial class frmDataViewer
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExportData = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnMnuExportData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 76);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 373);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMnuClose,
            this.btnMnuExportData});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.bestandToolStripMenuItem.Text = "&Simulatiedata";
            // 
            // btnMnuClose
            // 
            this.btnMnuClose.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_system_log_out_svg;
            this.btnMnuClose.Name = "btnMnuClose";
            this.btnMnuClose.Size = new System.Drawing.Size(180, 22);
            this.btnMnuClose.Text = "Afsluiten";
            this.btnMnuClose.ToolTipText = "Sluit dit venster.";
            this.btnMnuClose.Click += new System.EventHandler(this.btnMnuClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnExportData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 49);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExportData
            // 
            this.btnExportData.Image = global::EduLab_Process_Simulator.Properties.Resources._240px_Gnome_accessories_text_editor_svg;
            this.btnExportData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(110, 46);
            this.btnExportData.Text = "Exporteren";
            this.btnExportData.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_system_log_out_svg;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 46);
            this.btnClose.Text = "Afsluiten";
            this.btnClose.ToolTipText = "Sluit dit venster.";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMnuExportData
            // 
            this.btnMnuExportData.Image = global::EduLab_Process_Simulator.Properties.Resources._240px_Gnome_accessories_text_editor_svg;
            this.btnMnuExportData.Name = "btnMnuExportData";
            this.btnMnuExportData.Size = new System.Drawing.Size(180, 22);
            this.btnMnuExportData.Text = "Exporteren";
            // 
            // frmDataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmDataViewer";
            this.ShowIcon = false;
            this.Text = "Simulatiedata bekijken..";
            this.Shown += new System.EventHandler(this.DataViewer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMnuClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExportData;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnMnuExportData;
    }
}