﻿namespace ARESDOKUM
{
    partial class CalculateSalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateSalaryForm));
            this.btn_Main = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CalculateSalary = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Advance = new System.Windows.Forms.Label();
            this.lbl_Response = new System.Windows.Forms.Label();
            this.btn_MakePayment = new System.Windows.Forms.Button();
            this.rTxt_Description = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_CheckPaymentMade = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Main
            // 
            this.btn_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Main.BackColor = System.Drawing.Color.Transparent;
            this.btn_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Main.BackgroundImage")));
            this.btn_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Main.FlatAppearance.BorderSize = 0;
            this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main.ForeColor = System.Drawing.Color.Coral;
            this.btn_Main.Location = new System.Drawing.Point(9, 516);
            this.btn_Main.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(86, 73);
            this.btn_Main.TabIndex = 20;
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(98, 516);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(86, 73);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cb_EmployeeList
            // 
            this.cb_EmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_EmployeeList.FormattingEnabled = true;
            this.cb_EmployeeList.Location = new System.Drawing.Point(170, 46);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(200, 24);
            this.cb_EmployeeList.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(125, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "İşçi";
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_StartDate.Location = new System.Drawing.Point(170, 89);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(200, 22);
            this.dt_StartDate.TabIndex = 23;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_EndDate.Location = new System.Drawing.Point(170, 126);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(200, 22);
            this.dt_EndDate.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(83, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // btn_CalculateSalary
            // 
            this.btn_CalculateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CalculateSalary.Location = new System.Drawing.Point(51, 159);
            this.btn_CalculateSalary.Name = "btn_CalculateSalary";
            this.btn_CalculateSalary.Size = new System.Drawing.Size(319, 51);
            this.btn_CalculateSalary.TabIndex = 25;
            this.btn_CalculateSalary.Text = "Maaş Hesapla";
            this.btn_CalculateSalary.UseVisualStyleBackColor = true;
            this.btn_CalculateSalary.Click += new System.EventHandler(this.btn_CalculateSalary_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Maaş:";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Black;
            this.lbl_Salary.Location = new System.Drawing.Point(117, 294);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(74, 20);
            this.lbl_Salary.TabIndex = 27;
            this.lbl_Salary.Text = "             ";
            // 
            // lbl_Advance
            // 
            this.lbl_Advance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Advance.AutoSize = true;
            this.lbl_Advance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Advance.Location = new System.Drawing.Point(67, 338);
            this.lbl_Advance.Name = "lbl_Advance";
            this.lbl_Advance.Size = new System.Drawing.Size(127, 16);
            this.lbl_Advance.TabIndex = 29;
            this.lbl_Advance.Text = "                              ";
            this.lbl_Advance.Click += new System.EventHandler(this.lbl_Advance_Click);
            // 
            // lbl_Response
            // 
            this.lbl_Response.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Response.AutoSize = true;
            this.lbl_Response.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Response.ForeColor = System.Drawing.Color.Green;
            this.lbl_Response.Location = new System.Drawing.Point(608, 77);
            this.lbl_Response.Name = "lbl_Response";
            this.lbl_Response.Size = new System.Drawing.Size(144, 20);
            this.lbl_Response.TabIndex = 30;
            this.lbl_Response.Text = "                           ";
            // 
            // btn_MakePayment
            // 
            this.btn_MakePayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MakePayment.Location = new System.Drawing.Point(474, 219);
            this.btn_MakePayment.Name = "btn_MakePayment";
            this.btn_MakePayment.Size = new System.Drawing.Size(274, 51);
            this.btn_MakePayment.TabIndex = 31;
            this.btn_MakePayment.Text = "Ödeme Yap";
            this.btn_MakePayment.UseVisualStyleBackColor = true;
            this.btn_MakePayment.Visible = false;
            this.btn_MakePayment.Click += new System.EventHandler(this.btn_MakePayment_Click);
            // 
            // rTxt_Description
            // 
            this.rTxt_Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rTxt_Description.Location = new System.Drawing.Point(474, 131);
            this.rTxt_Description.MaxLength = 255;
            this.rTxt_Description.Name = "rTxt_Description";
            this.rTxt_Description.Size = new System.Drawing.Size(274, 81);
            this.rTxt_Description.TabIndex = 32;
            this.rTxt_Description.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_EmployeeList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_StartDate);
            this.groupBox1.Controls.Add(this.dt_EndDate);
            this.groupBox1.Controls.Add(this.btn_CalculateSalary);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(70, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 224);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maaş Hesapla";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 34);
            this.label5.TabIndex = 34;
            this.label5.Text = "Maaş Hesaplama - Ödeme";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(474, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(470, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // lbl_CheckPaymentMade
            // 
            this.lbl_CheckPaymentMade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CheckPaymentMade.AutoSize = true;
            this.lbl_CheckPaymentMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CheckPaymentMade.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckPaymentMade.Location = new System.Drawing.Point(57, 417);
            this.lbl_CheckPaymentMade.Name = "lbl_CheckPaymentMade";
            this.lbl_CheckPaymentMade.Size = new System.Drawing.Size(51, 16);
            this.lbl_CheckPaymentMade.TabIndex = 36;
            this.lbl_CheckPaymentMade.Text = "ㅤㅤㅤㅤ";
            this.lbl_CheckPaymentMade.Click += new System.EventHandler(this.lbl_CheckPaymentMade_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.EmployeeName,
            this.PaymentDate,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(773, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 405);
            this.dataGridView1.TabIndex = 37;
            // 
            // PaymentId
            // 
            this.PaymentId.HeaderText = "Sıra";
            this.PaymentId.Name = "PaymentId";
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Ad Soyad";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Ödeme Tarihi";
            this.PaymentDate.Name = "PaymentDate";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Ödenen Tutar";
            this.Amount.Name = "Amount";
            // 
            // CalculateSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1255, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_CheckPaymentMade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rTxt_Description);
            this.Controls.Add(this.btn_MakePayment);
            this.Controls.Add(this.lbl_Response);
            this.Controls.Add(this.lbl_Advance);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ares Döküm | PYS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalculateSalaryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CalculateSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Advance;
        private System.Windows.Forms.Label lbl_Response;
        private System.Windows.Forms.Button btn_MakePayment;
        private System.Windows.Forms.RichTextBox rTxt_Description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_CheckPaymentMade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}