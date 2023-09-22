namespace ARESDOKUM
{
	partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_Employee = new System.Windows.Forms.Button();
            this.btn_Shift = new System.Windows.Forms.Button();
            this.btn_Leaves = new System.Windows.Forms.Button();
            this.btn_ExittoMain = new System.Windows.Forms.Button();
            this.btn_Advance = new System.Windows.Forms.Button();
            this.btn_CalculateSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Employee
            // 
            this.btn_Employee.Location = new System.Drawing.Point(993, 12);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(203, 44);
            this.btn_Employee.TabIndex = 1;
            this.btn_Employee.Text = "Çalışanlar";
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Shift
            // 
            this.btn_Shift.Location = new System.Drawing.Point(993, 62);
            this.btn_Shift.Name = "btn_Shift";
            this.btn_Shift.Size = new System.Drawing.Size(203, 46);
            this.btn_Shift.TabIndex = 2;
            this.btn_Shift.Text = "Girş Çıkış Saati Gir";
            this.btn_Shift.UseVisualStyleBackColor = true;
            this.btn_Shift.Click += new System.EventHandler(this.btn_Shift_Click);
            // 
            // btn_Leaves
            // 
            this.btn_Leaves.Location = new System.Drawing.Point(993, 115);
            this.btn_Leaves.Name = "btn_Leaves";
            this.btn_Leaves.Size = new System.Drawing.Size(203, 47);
            this.btn_Leaves.TabIndex = 3;
            this.btn_Leaves.Text = "İzin Talepleri";
            this.btn_Leaves.UseVisualStyleBackColor = true;
            this.btn_Leaves.Click += new System.EventHandler(this.btn_Leaves_Click);
            // 
            // btn_ExittoMain
            // 
            this.btn_ExittoMain.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExittoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExittoMain.BackgroundImage")));
            this.btn_ExittoMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExittoMain.FlatAppearance.BorderSize = 0;
            this.btn_ExittoMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExittoMain.Location = new System.Drawing.Point(1110, 452);
            this.btn_ExittoMain.Name = "btn_ExittoMain";
            this.btn_ExittoMain.Size = new System.Drawing.Size(86, 73);
            this.btn_ExittoMain.TabIndex = 13;
            this.btn_ExittoMain.UseVisualStyleBackColor = false;
            this.btn_ExittoMain.Click += new System.EventHandler(this.btn_ExittoMain_Click);
            // 
            // btn_Advance
            // 
            this.btn_Advance.Location = new System.Drawing.Point(993, 169);
            this.btn_Advance.Name = "btn_Advance";
            this.btn_Advance.Size = new System.Drawing.Size(203, 52);
            this.btn_Advance.TabIndex = 14;
            this.btn_Advance.Text = "Avans Talepleri";
            this.btn_Advance.UseVisualStyleBackColor = true;
            this.btn_Advance.Click += new System.EventHandler(this.btn_Advance_Click);
            // 
            // btn_CalculateSalary
            // 
            this.btn_CalculateSalary.Location = new System.Drawing.Point(993, 228);
            this.btn_CalculateSalary.Name = "btn_CalculateSalary";
            this.btn_CalculateSalary.Size = new System.Drawing.Size(203, 53);
            this.btn_CalculateSalary.TabIndex = 15;
            this.btn_CalculateSalary.Text = "Maaş Hesapla";
            this.btn_CalculateSalary.UseVisualStyleBackColor = true;
            this.btn_CalculateSalary.Click += new System.EventHandler(this.btn_CalculateSalary_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 537);
            this.Controls.Add(this.btn_CalculateSalary);
            this.Controls.Add(this.btn_Advance);
            this.Controls.Add(this.btn_ExittoMain);
            this.Controls.Add(this.btn_Leaves);
            this.Controls.Add(this.btn_Shift);
            this.Controls.Add(this.btn_Employee);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Button btn_Shift;
        private System.Windows.Forms.Button btn_Leaves;
        private System.Windows.Forms.Button btn_ExittoMain;
        private System.Windows.Forms.Button btn_Advance;
        private System.Windows.Forms.Button btn_CalculateSalary;
    }
}