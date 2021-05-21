
namespace EduLab_Process_Simulator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overDezeApplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnPauze = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnStartFast = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartBatch = new System.Windows.Forms.Button();
            this.txtLevelIndicator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLT02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_settings_ui_behavior_svg;
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.bestandToolStripMenuItem.Text = "Programma";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_system_log_out_svg;
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overDezeApplicatieToolStripMenuItem});
            this.infoToolStripMenuItem.Image = global::EduLab_Process_Simulator.Properties.Resources._240px_Gnome_dialog_question_svg;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // overDezeApplicatieToolStripMenuItem
            // 
            this.overDezeApplicatieToolStripMenuItem.Image = global::EduLab_Process_Simulator.Properties.Resources._240px_Gnome_help_faq_svg;
            this.overDezeApplicatieToolStripMenuItem.Name = "overDezeApplicatieToolStripMenuItem";
            this.overDezeApplicatieToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.overDezeApplicatieToolStripMenuItem.Text = "Over deze applicatie..";
            this.overDezeApplicatieToolStripMenuItem.Click += new System.EventHandler(this.overDezeApplicatieToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnPauze,
            this.btnStop,
            this.btnStartFast});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 49);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_playback_start_svg;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(46, 46);
            this.btnStart.Text = "toolStripButton1";
            // 
            // btnPauze
            // 
            this.btnPauze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPauze.Image = global::EduLab_Process_Simulator.Properties.Resources._240px_Gnome_media_playback_pause_svg;
            this.btnPauze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPauze.Name = "btnPauze";
            this.btnPauze.Size = new System.Drawing.Size(46, 46);
            this.btnPauze.Text = "toolStripButton1";
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_playback_stop_svg;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 46);
            this.btnStop.Text = "toolStripButton1";
            // 
            // btnStartFast
            // 
            this.btnStartFast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartFast.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_seek_forward_svg;
            this.btnStartFast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartFast.Name = "btnStartFast";
            this.btnStartFast.Size = new System.Drawing.Size(46, 46);
            this.btnStartFast.Text = "toolStripButton1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartBatch
            // 
            this.btnStartBatch.Location = new System.Drawing.Point(493, 272);
            this.btnStartBatch.Name = "btnStartBatch";
            this.btnStartBatch.Size = new System.Drawing.Size(75, 23);
            this.btnStartBatch.TabIndex = 6;
            this.btnStartBatch.Text = "Start batch";
            this.btnStartBatch.UseVisualStyleBackColor = true;
            this.btnStartBatch.Click += new System.EventHandler(this.btnStartBatch_Click);
            // 
            // txtLevelIndicator
            // 
            this.txtLevelIndicator.Location = new System.Drawing.Point(493, 220);
            this.txtLevelIndicator.Name = "txtLevelIndicator";
            this.txtLevelIndicator.ReadOnly = true;
            this.txtLevelIndicator.Size = new System.Drawing.Size(150, 20);
            this.txtLevelIndicator.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Batch status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "LT02:";
            // 
            // txtLT02
            // 
            this.txtLT02.Location = new System.Drawing.Point(493, 246);
            this.txtLT02.Name = "txtLT02";
            this.txtLT02.ReadOnly = true;
            this.txtLT02.Size = new System.Drawing.Size(75, 20);
            this.txtLT02.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "[L]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLT02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLevelIndicator);
            this.Controls.Add(this.btnStartBatch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "frmMain";
            this.Text = "EduLab Process Simulator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem overDezeApplicatieToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStartBatch;
        private System.Windows.Forms.TextBox txtLevelIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLT02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnPauze;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnStartFast;
    }
}

