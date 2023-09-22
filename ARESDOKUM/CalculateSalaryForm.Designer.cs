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
            this.SuspendLayout();
            // 
            // btn_Main
            // 
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
            this.cb_EmployeeList.Location = new System.Drawing.Point(151, 81);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(200, 24);
            this.cb_EmployeeList.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "İşçi";
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_StartDate.Location = new System.Drawing.Point(151, 124);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(200, 22);
            this.dt_StartDate.TabIndex = 23;
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dt_EndDate.Location = new System.Drawing.Point(151, 161);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(200, 22);
            this.dt_EndDate.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // btn_CalculateSalary
            // 
            this.btn_CalculateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CalculateSalary.Location = new System.Drawing.Point(32, 196);
            this.btn_CalculateSalary.Name = "btn_CalculateSalary";
            this.btn_CalculateSalary.Size = new System.Drawing.Size(319, 51);
            this.btn_CalculateSalary.TabIndex = 25;
            this.btn_CalculateSalary.Text = "Maaş Hesapla";
            this.btn_CalculateSalary.UseVisualStyleBackColor = true;
            this.btn_CalculateSalary.Click += new System.EventHandler(this.btn_CalculateSalary_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(497, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ödenecek Tutar";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Green;
            this.lbl_Salary.Location = new System.Drawing.Point(639, 84);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(39, 20);
            this.lbl_Salary.TabIndex = 27;
            this.lbl_Salary.Text = "000";
            // 
            // CalculateSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 598);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CalculateSalary);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_EmployeeList);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.btn_Exit);
            this.Name = "CalculateSalaryForm";
            this.Text = "Maaş Hesapla";
            this.Load += new System.EventHandler(this.CalculateSalaryForm_Load);
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
    }
}