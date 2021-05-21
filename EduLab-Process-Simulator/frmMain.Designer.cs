
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
            this.txtLT02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbxSimulationAcceleration = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBatchStatus = new System.Windows.Forms.ToolStripTextBox();
            this.txtLT03 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLT04 = new System.Windows.Forms.TextBox();
            this.txtCV02 = new System.Windows.Forms.TextBox();
            this.txtCV04 = new System.Windows.Forms.TextBox();
            this.txtSV40 = new System.Windows.Forms.TextBox();
            this.txtSV50 = new System.Windows.Forms.TextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 669);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.btnStartFast,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbxSimulationAcceleration,
            this.toolStripSeparator2,
            this.txtBatchStatus,
            this.toolStripLabel2,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 49);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_playback_start_svg;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 46);
            this.btnStart.Text = "Start batch";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPauze
            // 
            this.btnPauze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPauze.Image = global::EduLab_Process_Simulator.Properties.Resources._240px_Gnome_media_playback_pause_svg;
            this.btnPauze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPauze.Name = "btnPauze";
            this.btnPauze.Size = new System.Drawing.Size(46, 46);
            this.btnPauze.Text = "toolStripButton1";
            this.btnPauze.Click += new System.EventHandler(this.btnPauze_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_playback_stop_svg;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 46);
            this.btnStop.Text = "toolStripButton1";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartFast
            // 
            this.btnStartFast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartFast.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_seek_forward_svg;
            this.btnStartFast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartFast.Name = "btnStartFast";
            this.btnStartFast.Size = new System.Drawing.Size(46, 46);
            this.btnStartFast.Text = "toolStripButton1";
            this.btnStartFast.Click += new System.EventHandler(this.btnStartFast_Click);
            // 
            // txtLT02
            // 
            this.txtLT02.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLT02.Location = new System.Drawing.Point(244, 181);
            this.txtLT02.Name = "txtLT02";
            this.txtLT02.ReadOnly = true;
            this.txtLT02.Size = new System.Drawing.Size(40, 20);
            this.txtLT02.TabIndex = 10;
            this.txtLT02.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "[L]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 691);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // cbxSimulationAcceleration
            // 
            this.cbxSimulationAcceleration.BackColor = System.Drawing.SystemColors.Control;
            this.cbxSimulationAcceleration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSimulationAcceleration.Items.AddRange(new object[] {
            "1x",
            "2x",
            "4x",
            "8x",
            "16x"});
            this.cbxSimulationAcceleration.Name = "cbxSimulationAcceleration";
            this.cbxSimulationAcceleration.Size = new System.Drawing.Size(75, 49);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(118, 46);
            this.toolStripLabel1.Text = "Versnelling simulatie:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // txtBatchStatus
            // 
            this.txtBatchStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBatchStatus.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtBatchStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatchStatus.Name = "txtBatchStatus";
            this.txtBatchStatus.ReadOnly = true;
            this.txtBatchStatus.Size = new System.Drawing.Size(200, 49);
            // 
            // txtLT03
            // 
            this.txtLT03.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLT03.Location = new System.Drawing.Point(495, 181);
            this.txtLT03.Name = "txtLT03";
            this.txtLT03.ReadOnly = true;
            this.txtLT03.Size = new System.Drawing.Size(40, 20);
            this.txtLT03.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "[L]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "[L]";
            // 
            // txtLT04
            // 
            this.txtLT04.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLT04.Location = new System.Drawing.Point(713, 155);
            this.txtLT04.Name = "txtLT04";
            this.txtLT04.ReadOnly = true;
            this.txtLT04.Size = new System.Drawing.Size(40, 20);
            this.txtLT04.TabIndex = 15;
            // 
            // txtCV02
            // 
            this.txtCV02.BackColor = System.Drawing.SystemColors.Info;
            this.txtCV02.Location = new System.Drawing.Point(153, 87);
            this.txtCV02.Name = "txtCV02";
            this.txtCV02.ReadOnly = true;
            this.txtCV02.Size = new System.Drawing.Size(40, 20);
            this.txtCV02.TabIndex = 17;
            this.txtCV02.Text = "-";
            // 
            // txtCV04
            // 
            this.txtCV04.BackColor = System.Drawing.SystemColors.Info;
            this.txtCV04.Location = new System.Drawing.Point(408, 87);
            this.txtCV04.Name = "txtCV04";
            this.txtCV04.ReadOnly = true;
            this.txtCV04.Size = new System.Drawing.Size(40, 20);
            this.txtCV04.TabIndex = 18;
            this.txtCV04.Text = "-";
            // 
            // txtSV40
            // 
            this.txtSV40.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV40.Location = new System.Drawing.Point(655, 87);
            this.txtSV40.Name = "txtSV40";
            this.txtSV40.ReadOnly = true;
            this.txtSV40.Size = new System.Drawing.Size(40, 20);
            this.txtSV40.TabIndex = 19;
            this.txtSV40.Text = "-";
            // 
            // txtSV50
            // 
            this.txtSV50.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV50.Location = new System.Drawing.Point(776, 87);
            this.txtSV50.Name = "txtSV50";
            this.txtSV50.ReadOnly = true;
            this.txtSV50.Size = new System.Drawing.Size(40, 20);
            this.txtSV50.TabIndex = 20;
            this.txtSV50.Text = "-";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 46);
            this.toolStripLabel2.Text = "Status:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 691);
            this.Controls.Add(this.txtSV50);
            this.Controls.Add(this.txtSV40);
            this.Controls.Add(this.txtCV04);
            this.Controls.Add(this.txtCV02);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLT04);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLT03);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLT02);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 730);
            this.Name = "frmMain";
            this.Text = "EduLab Process Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtLT02;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnPauze;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnStartFast;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbxSimulationAcceleration;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtBatchStatus;
        private System.Windows.Forms.TextBox txtLT03;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLT04;
        private System.Windows.Forms.TextBox txtCV02;
        private System.Windows.Forms.TextBox txtCV04;
        private System.Windows.Forms.TextBox txtSV40;
        private System.Windows.Forms.TextBox txtSV50;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

