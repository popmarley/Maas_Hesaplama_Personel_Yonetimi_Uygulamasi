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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1097, 11);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(99, 43);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Çıkış Yap";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Location = new System.Drawing.Point(838, 30);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(89, 44);
            this.btn_Employee.TabIndex = 1;
            this.btn_Employee.Text = "Çalışanlar";
            this.btn_Employee.UseVisualStyleBackColor = true;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 537);
            this.Controls.Add(this.btn_Employee);
            this.Controls.Add(this.btn_Exit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Employee;
    }
}