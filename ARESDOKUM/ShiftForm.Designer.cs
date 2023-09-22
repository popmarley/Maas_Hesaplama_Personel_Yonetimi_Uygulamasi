namespace ARESDOKUM
{
    partial class ShiftForm
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
            this.btn_AddShift = new System.Windows.Forms.Button();
            this.txt_ShiftHour = new System.Windows.Forms.TextBox();
            this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
            this.dt_Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_AddShift
            // 
            this.btn_AddShift.Location = new System.Drawing.Point(12, 203);
            this.btn_AddShift.Name = "btn_AddShift";
            this.btn_AddShift.Size = new System.Drawing.Size(132, 42);
            this.btn_AddShift.TabIndex = 0;
            this.btn_AddShift.Text = "Veriyi Gir";
            this.btn_AddShift.UseVisualStyleBackColor = true;
            this.btn_AddShift.Click += new System.EventHandler(this.btn_AddShift_Click);
            // 
            // txt_ShiftHour
            // 
            this.txt_ShiftHour.Location = new System.Drawing.Point(12, 177);
            this.txt_ShiftHour.Name = "txt_ShiftHour";
            this.txt_ShiftHour.Size = new System.Drawing.Size(131, 20);
            this.txt_ShiftHour.TabIndex = 1;
            // 
            // cb_EmployeeList
            // 
            this.cb_EmployeeList.FormattingEnabled = true;
            this.cb_EmployeeList.Location = new System.Drawing.Point(12, 93);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(132, 21);
            this.cb_EmployeeList.TabIndex = 2;
            // 
            // dt_Date
            // 
            this.dt_Date.Location = new System.Drawing.Point(12, 139);
            this.dt_Date.Name = "dt_Date";
            this.dt_Date.Size = new System.Drawing.Size(200, 20);
            this.dt_Date.TabIndex = 3;
            this.dt_Date.ValueChanged += new System.EventHandler(this.dt_Date_ValueChanged);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 510);
            this.Controls.Add(this.dt_Date);
            this.Controls.Add(this.cb_EmployeeList);
            this.Controls.Add(this.txt_ShiftHour);
            this.Controls.Add(this.btn_AddShift);
            this.Name = "ShiftForm";
            this.Text = "ShiftForm";
            this.Load += new System.EventHandler(this.ShiftForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddShift;
        private System.Windows.Forms.TextBox txt_ShiftHour;
        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.DateTimePicker dt_Date;
    }
}