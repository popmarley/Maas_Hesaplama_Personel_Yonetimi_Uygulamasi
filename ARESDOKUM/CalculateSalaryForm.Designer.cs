namespace ARESDOKUM
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
            this.cb_EmployeeList.Location = new System.Drawing.Point(98, 173);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(179, 24);
            this.cb_EmployeeList.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "İşçi";
            // 
            // CalculateSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 598);
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
    }
}