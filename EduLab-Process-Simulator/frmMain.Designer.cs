﻿
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
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxSimulationAcceleration = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBatchStatus = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDebug = new System.Windows.Forms.ToolStripButton();
            this.txtLT02 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLT03 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLT04 = new System.Windows.Forms.TextBox();
            this.txtCV02 = new System.Windows.Forms.TextBox();
            this.txtCV04 = new System.Windows.Forms.TextBox();
            this.txtSV40 = new System.Windows.Forms.TextBox();
            this.txtSV50 = new System.Windows.Forms.TextBox();
            this.txtSV21 = new System.Windows.Forms.TextBox();
            this.txtSV31 = new System.Windows.Forms.TextBox();
            this.txtSV41 = new System.Windows.Forms.TextBox();
            this.txtSV10 = new System.Windows.Forms.TextBox();
            this.txtSV51 = new System.Windows.Forms.TextBox();
            this.txtSV12 = new System.Windows.Forms.TextBox();
            this.txtSV05A = new System.Windows.Forms.TextBox();
            this.txtSV05B = new System.Windows.Forms.TextBox();
            this.txtSV01 = new System.Windows.Forms.TextBox();
            this.txtCV03 = new System.Windows.Forms.TextBox();
            this.txtSV22 = new System.Windows.Forms.TextBox();
            this.txtKE01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPO02 = new System.Windows.Forms.TextBox();
            this.txtPO03 = new System.Windows.Forms.TextBox();
            this.txtPO04 = new System.Windows.Forms.TextBox();
            this.txtPO01 = new System.Windows.Forms.TextBox();
            this.txtPO05 = new System.Windows.Forms.TextBox();
            this.txtTA01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
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
            this.btnStop,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbxSimulationAcceleration,
            this.toolStripSeparator2,
            this.txtBatchStatus,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.btnDebug});
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
            this.btnStart.Size = new System.Drawing.Size(141, 46);
            this.btnStart.Text = "Simulatie starten";
            this.btnStart.ToolTipText = "Start de simulatie van een enkele batch.";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_media_playback_stop_svg;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 46);
            this.btnStop.Text = "toolStripButton1";
            this.btnStop.ToolTipText = "Stop de simulatie.";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(118, 46);
            this.toolStripLabel1.Text = "Versnelling simulatie:";
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
            "16x",
            "32x",
            "64x",
            "MAX"});
            this.cbxSimulationAcceleration.Name = "cbxSimulationAcceleration";
            this.cbxSimulationAcceleration.Size = new System.Drawing.Size(75, 49);
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
            // btnDebug
            // 
            this.btnDebug.Image = global::EduLab_Process_Simulator.Properties.Resources.Gnome_view_fullscreen_svg;
            this.btnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(88, 46);
            this.btnDebug.Text = "Debug";
            this.btnDebug.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.label5.Location = new System.Drawing.Point(762, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "[L]";
            // 
            // txtLT04
            // 
            this.txtLT04.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLT04.Location = new System.Drawing.Point(716, 155);
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
            // txtSV21
            // 
            this.txtSV21.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV21.Location = new System.Drawing.Point(210, 263);
            this.txtSV21.Name = "txtSV21";
            this.txtSV21.ReadOnly = true;
            this.txtSV21.Size = new System.Drawing.Size(40, 20);
            this.txtSV21.TabIndex = 21;
            this.txtSV21.Text = "-";
            // 
            // txtSV31
            // 
            this.txtSV31.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV31.Location = new System.Drawing.Point(348, 263);
            this.txtSV31.Name = "txtSV31";
            this.txtSV31.ReadOnly = true;
            this.txtSV31.Size = new System.Drawing.Size(40, 20);
            this.txtSV31.TabIndex = 22;
            this.txtSV31.Text = "-";
            // 
            // txtSV41
            // 
            this.txtSV41.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV41.Location = new System.Drawing.Point(716, 263);
            this.txtSV41.Name = "txtSV41";
            this.txtSV41.ReadOnly = true;
            this.txtSV41.Size = new System.Drawing.Size(40, 20);
            this.txtSV41.TabIndex = 23;
            this.txtSV41.Text = "-";
            // 
            // txtSV10
            // 
            this.txtSV10.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV10.Location = new System.Drawing.Point(559, 357);
            this.txtSV10.Name = "txtSV10";
            this.txtSV10.ReadOnly = true;
            this.txtSV10.Size = new System.Drawing.Size(40, 20);
            this.txtSV10.TabIndex = 24;
            this.txtSV10.Text = "-";
            // 
            // txtSV51
            // 
            this.txtSV51.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV51.Location = new System.Drawing.Point(716, 357);
            this.txtSV51.Name = "txtSV51";
            this.txtSV51.ReadOnly = true;
            this.txtSV51.Size = new System.Drawing.Size(40, 20);
            this.txtSV51.TabIndex = 25;
            this.txtSV51.Text = "-";
            // 
            // txtSV12
            // 
            this.txtSV12.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV12.Location = new System.Drawing.Point(716, 611);
            this.txtSV12.Name = "txtSV12";
            this.txtSV12.ReadOnly = true;
            this.txtSV12.Size = new System.Drawing.Size(40, 20);
            this.txtSV12.TabIndex = 26;
            this.txtSV12.Text = "-";
            // 
            // txtSV05A
            // 
            this.txtSV05A.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV05A.Location = new System.Drawing.Point(686, 495);
            this.txtSV05A.Name = "txtSV05A";
            this.txtSV05A.ReadOnly = true;
            this.txtSV05A.Size = new System.Drawing.Size(40, 20);
            this.txtSV05A.TabIndex = 27;
            this.txtSV05A.Text = "-";
            // 
            // txtSV05B
            // 
            this.txtSV05B.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV05B.Location = new System.Drawing.Point(841, 518);
            this.txtSV05B.Name = "txtSV05B";
            this.txtSV05B.ReadOnly = true;
            this.txtSV05B.Size = new System.Drawing.Size(40, 20);
            this.txtSV05B.TabIndex = 28;
            this.txtSV05B.Text = "-";
            // 
            // txtSV01
            // 
            this.txtSV01.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV01.Location = new System.Drawing.Point(892, 518);
            this.txtSV01.Name = "txtSV01";
            this.txtSV01.ReadOnly = true;
            this.txtSV01.Size = new System.Drawing.Size(40, 20);
            this.txtSV01.TabIndex = 29;
            this.txtSV01.Text = "-";
            // 
            // txtCV03
            // 
            this.txtCV03.BackColor = System.Drawing.SystemColors.Info;
            this.txtCV03.Location = new System.Drawing.Point(589, 238);
            this.txtCV03.Name = "txtCV03";
            this.txtCV03.ReadOnly = true;
            this.txtCV03.Size = new System.Drawing.Size(40, 20);
            this.txtCV03.TabIndex = 30;
            this.txtCV03.Text = "-";
            // 
            // txtSV22
            // 
            this.txtSV22.BackColor = System.Drawing.SystemColors.Info;
            this.txtSV22.Location = new System.Drawing.Point(281, 368);
            this.txtSV22.Name = "txtSV22";
            this.txtSV22.ReadOnly = true;
            this.txtSV22.Size = new System.Drawing.Size(40, 20);
            this.txtSV22.TabIndex = 31;
            this.txtSV22.Text = "-";
            // 
            // txtKE01
            // 
            this.txtKE01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtKE01.Location = new System.Drawing.Point(860, 313);
            this.txtKE01.Name = "txtKE01";
            this.txtKE01.ReadOnly = true;
            this.txtKE01.Size = new System.Drawing.Size(40, 20);
            this.txtKE01.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "[L]";
            // 
            // txtPO02
            // 
            this.txtPO02.BackColor = System.Drawing.Color.Yellow;
            this.txtPO02.Location = new System.Drawing.Point(210, 395);
            this.txtPO02.Name = "txtPO02";
            this.txtPO02.ReadOnly = true;
            this.txtPO02.Size = new System.Drawing.Size(60, 20);
            this.txtPO02.TabIndex = 34;
            this.txtPO02.Text = "-";
            // 
            // txtPO03
            // 
            this.txtPO03.BackColor = System.Drawing.Color.Yellow;
            this.txtPO03.Location = new System.Drawing.Point(457, 357);
            this.txtPO03.Name = "txtPO03";
            this.txtPO03.ReadOnly = true;
            this.txtPO03.Size = new System.Drawing.Size(60, 20);
            this.txtPO03.TabIndex = 35;
            this.txtPO03.Text = "-";
            // 
            // txtPO04
            // 
            this.txtPO04.BackColor = System.Drawing.Color.Yellow;
            this.txtPO04.Location = new System.Drawing.Point(627, 464);
            this.txtPO04.Name = "txtPO04";
            this.txtPO04.ReadOnly = true;
            this.txtPO04.Size = new System.Drawing.Size(60, 20);
            this.txtPO04.TabIndex = 36;
            this.txtPO04.Text = "-";
            // 
            // txtPO01
            // 
            this.txtPO01.BackColor = System.Drawing.Color.Yellow;
            this.txtPO01.Location = new System.Drawing.Point(589, 635);
            this.txtPO01.Name = "txtPO01";
            this.txtPO01.ReadOnly = true;
            this.txtPO01.Size = new System.Drawing.Size(60, 20);
            this.txtPO01.TabIndex = 37;
            this.txtPO01.Text = "-";
            // 
            // txtPO05
            // 
            this.txtPO05.BackColor = System.Drawing.Color.Yellow;
            this.txtPO05.Location = new System.Drawing.Point(788, 546);
            this.txtPO05.Name = "txtPO05";
            this.txtPO05.ReadOnly = true;
            this.txtPO05.Size = new System.Drawing.Size(60, 20);
            this.txtPO05.TabIndex = 38;
            this.txtPO05.Text = "-";
            // 
            // txtTA01
            // 
            this.txtTA01.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTA01.Location = new System.Drawing.Point(417, 594);
            this.txtTA01.Name = "txtTA01";
            this.txtTA01.ReadOnly = true;
            this.txtTA01.Size = new System.Drawing.Size(40, 20);
            this.txtTA01.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "[L]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTA01);
            this.Controls.Add(this.txtPO05);
            this.Controls.Add(this.txtPO01);
            this.Controls.Add(this.txtPO04);
            this.Controls.Add(this.txtPO03);
            this.Controls.Add(this.txtPO02);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKE01);
            this.Controls.Add(this.txtSV22);
            this.Controls.Add(this.txtCV03);
            this.Controls.Add(this.txtSV01);
            this.Controls.Add(this.txtSV05B);
            this.Controls.Add(this.txtSV05A);
            this.Controls.Add(this.txtSV12);
            this.Controls.Add(this.txtSV51);
            this.Controls.Add(this.txtSV10);
            this.Controls.Add(this.txtSV41);
            this.Controls.Add(this.txtSV31);
            this.Controls.Add(this.txtSV21);
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
            this.MinimumSize = new System.Drawing.Size(1200, 726);
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
        private System.Windows.Forms.ToolStripButton btnStop;
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
        private System.Windows.Forms.TextBox txtSV21;
        private System.Windows.Forms.TextBox txtSV31;
        private System.Windows.Forms.TextBox txtSV41;
        private System.Windows.Forms.TextBox txtSV10;
        private System.Windows.Forms.TextBox txtSV51;
        private System.Windows.Forms.TextBox txtSV12;
        private System.Windows.Forms.TextBox txtSV05A;
        private System.Windows.Forms.TextBox txtSV05B;
        private System.Windows.Forms.TextBox txtSV01;
        private System.Windows.Forms.TextBox txtCV03;
        private System.Windows.Forms.TextBox txtSV22;
        private System.Windows.Forms.TextBox txtKE01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPO02;
        private System.Windows.Forms.TextBox txtPO03;
        private System.Windows.Forms.TextBox txtPO04;
        private System.Windows.Forms.TextBox txtPO01;
        private System.Windows.Forms.TextBox txtPO05;
        private System.Windows.Forms.TextBox txtTA01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnDebug;
    }
}

