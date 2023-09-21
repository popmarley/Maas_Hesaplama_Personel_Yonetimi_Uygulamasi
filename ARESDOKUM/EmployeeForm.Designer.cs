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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 492);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.txt_AddEmployee_HourlyRate);
            this.Controls.Add(this.txt_AddEmployee_Name);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddEmployee_Name;
        private System.Windows.Forms.TextBox txt_AddEmployee_HourlyRate;
        private System.Windows.Forms.Button btn_AddEmployee;
    }
}