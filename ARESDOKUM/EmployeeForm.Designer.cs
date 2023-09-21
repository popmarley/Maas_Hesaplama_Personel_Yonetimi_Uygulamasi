namespace ARESDOKUM
{
    partial class EmployeeForm
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
            this.txt_AddEmployee_Name = new System.Windows.Forms.TextBox();
            this.txt_AddEmployee_HourlyRate = new System.Windows.Forms.TextBox();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_EmployeeList = new System.Windows.Forms.Button();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseHourlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AddEmployee_Name
            // 
            this.txt_AddEmployee_Name.Location = new System.Drawing.Point(743, 51);
            this.txt_AddEmployee_Name.Name = "txt_AddEmployee_Name";
            this.txt_AddEmployee_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_AddEmployee_Name.TabIndex = 0;
            // 
            // txt_AddEmployee_HourlyRate
            // 
            this.txt_AddEmployee_HourlyRate.Location = new System.Drawing.Point(743, 87);
            this.txt_AddEmployee_HourlyRate.Name = "txt_AddEmployee_HourlyRate";
            this.txt_AddEmployee_HourlyRate.Size = new System.Drawing.Size(100, 20);
            this.txt_AddEmployee_HourlyRate.TabIndex = 1;
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(743, 126);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(100, 23);
            this.btn_AddEmployee.TabIndex = 2;
            this.btn_AddEmployee.Text = "Çalışanı Ekle";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FullName,
            this.BaseHourlyRate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 449);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_EmployeeList
            // 
            this.btn_EmployeeList.Location = new System.Drawing.Point(413, 31);
            this.btn_EmployeeList.Name = "btn_EmployeeList";
            this.btn_EmployeeList.Size = new System.Drawing.Size(100, 53);
            this.btn_EmployeeList.TabIndex = 4;
            this.btn_EmployeeList.Text = "Çalışanları Listele";
            this.btn_EmployeeList.UseVisualStyleBackColor = true;
            this.btn_EmployeeList.Click += new System.EventHandler(this.btn_EmployeeList_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Ad Soyad";
            this.FullName.Name = "FullName";
            this.FullName.Width = 200;
            // 
            // BaseHourlyRate
            // 
            this.BaseHourlyRate.HeaderText = "Saatlik Kazanç";
            this.BaseHourlyRate.Name = "BaseHourlyRate";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 492);
            this.Controls.Add(this.btn_EmployeeList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.txt_AddEmployee_HourlyRate);
            this.Controls.Add(this.txt_AddEmployee_Name);
            this.Name = "EmployeeForm";
            this.Text = "Çalışanlar";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddEmployee_Name;
        private System.Windows.Forms.TextBox txt_AddEmployee_HourlyRate;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_EmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseHourlyRate;
    }
}