
namespace EduLab_Process_Simulator
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSimulation = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTA02FillRate = new System.Windows.Forms.NumericUpDown();
            this.txtTA02EmptyRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTA03EmptyRate = new System.Windows.Forms.NumericUpDown();
            this.txtTA03FillRate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTA04EmptyRate = new System.Windows.Forms.NumericUpDown();
            this.txtTA04FillRate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKE01EmptyRate = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA02FillRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA02EmptyRate)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA03EmptyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA03FillRate)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA04EmptyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA04FillRate)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKE01EmptyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(324, 516);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(243, 516);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpSimulation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instellingen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum en tijd simulatie:";
            // 
            // dtpSimulation
            // 
            this.dtpSimulation.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpSimulation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSimulation.Location = new System.Drawing.Point(170, 33);
            this.dtpSimulation.Name = "dtpSimulation";
            this.dtpSimulation.Size = new System.Drawing.Size(200, 20);
            this.dtpSimulation.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTA02EmptyRate);
            this.groupBox2.Controls.Add(this.txtTA02FillRate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TA02";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fill rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empty rate";
            // 
            // txtTA02FillRate
            // 
            this.txtTA02FillRate.DecimalPlaces = 2;
            this.txtTA02FillRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtTA02FillRate.Location = new System.Drawing.Point(170, 30);
            this.txtTA02FillRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTA02FillRate.Name = "txtTA02FillRate";
            this.txtTA02FillRate.Size = new System.Drawing.Size(100, 20);
            this.txtTA02FillRate.TabIndex = 4;
            this.txtTA02FillRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // txtTA02EmptyRate
            // 
            this.txtTA02EmptyRate.DecimalPlaces = 2;
            this.txtTA02EmptyRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtTA02EmptyRate.Location = new System.Drawing.Point(170, 56);
            this.txtTA02EmptyRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTA02EmptyRate.Name = "txtTA02EmptyRate";
            this.txtTA02EmptyRate.Size = new System.Drawing.Size(100, 20);
            this.txtTA02EmptyRate.TabIndex = 6;
            this.txtTA02EmptyRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "[l/s]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "[l/s]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTA03EmptyRate);
            this.groupBox3.Controls.Add(this.txtTA03FillRate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TA03";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "[l/s]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "[l/s]";
            // 
            // txtTA03EmptyRate
            // 
            this.txtTA03EmptyRate.DecimalPlaces = 2;
            this.txtTA03EmptyRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtTA03EmptyRate.Location = new System.Drawing.Point(170, 56);
            this.txtTA03EmptyRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTA03EmptyRate.Name = "txtTA03EmptyRate";
            this.txtTA03EmptyRate.Size = new System.Drawing.Size(100, 20);
            this.txtTA03EmptyRate.TabIndex = 6;
            this.txtTA03EmptyRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // txtTA03FillRate
            // 
            this.txtTA03FillRate.DecimalPlaces = 2;
            this.txtTA03FillRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtTA03FillRate.Location = new System.Drawing.Point(170, 30);
            this.txtTA03FillRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTA03FillRate.Name = "txtTA03FillRate";
            this.txtTA03FillRate.Size = new System.Drawing.Size(100, 20);
            this.txtTA03FillRate.TabIndex = 4;
            this.txtTA03FillRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Empty rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fill rate";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTA04EmptyRate);
            this.groupBox4.Controls.Add(this.txtTA04FillRate);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TA04";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "[l/s]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "[l/s]";
            // 
            // txtTA04EmptyRate
            // 
            this.txtTA04EmptyRate.DecimalPlaces = 2;
            this.txtTA04EmptyRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtTA04EmptyRate.Location = new System.Drawing.Point(170, 56);
            this.txtTA04EmptyRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTA04EmptyRate.Name = "txtTA04EmptyRate";
            this.txtTA04EmptyRate.Size = new System.Drawing.Size(100, 20);
            this.txtTA04EmptyRate.TabIndex = 6;
            this.txtTA04EmptyRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // txtTA04FillRate
            // 
            this.txtTA04FillRate.DecimalPlaces = 2;
            this.txtTA04FillRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtTA04FillRate.Location = new System.Drawing.Point(170, 30);
            this.txtTA04FillRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTA04FillRate.Name = "txtTA04FillRate";
            this.txtTA04FillRate.Size = new System.Drawing.Size(100, 20);
            this.txtTA04FillRate.TabIndex = 4;
            this.txtTA04FillRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Empty rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Fill rate";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtKE01EmptyRate);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(12, 410);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 100);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "KE01";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "[l/s]";
            // 
            // txtKE01EmptyRate
            // 
            this.txtKE01EmptyRate.DecimalPlaces = 2;
            this.txtKE01EmptyRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.txtKE01EmptyRate.Location = new System.Drawing.Point(170, 30);
            this.txtKE01EmptyRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtKE01EmptyRate.Name = "txtKE01EmptyRate";
            this.txtKE01EmptyRate.Size = new System.Drawing.Size(100, 20);
            this.txtKE01EmptyRate.TabIndex = 6;
            this.txtKE01EmptyRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Empty rate";
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(413, 548);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instellingen aanpassen";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA02FillRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA02EmptyRate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA03EmptyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA03FillRate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA04EmptyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTA04FillRate)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKE01EmptyRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSimulation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTA02EmptyRate;
        private System.Windows.Forms.NumericUpDown txtTA02FillRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtTA03EmptyRate;
        private System.Windows.Forms.NumericUpDown txtTA03FillRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtTA04EmptyRate;
        private System.Windows.Forms.NumericUpDown txtTA04FillRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtKE01EmptyRate;
        private System.Windows.Forms.Label label16;
    }
}