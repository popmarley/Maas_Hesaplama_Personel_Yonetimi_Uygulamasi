namespace ARESDOKUM
{
    partial class LeaveForm
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
            this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
            this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
            this.btn_AddLeave = new System.Windows.Forms.Button();
            this.rTxt_Reason = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cb_EmployeeList
            // 
            this.cb_EmployeeList.FormattingEnabled = true;
            this.cb_EmployeeList.Location = new System.Drawing.Point(97, 76);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(200, 21);
            this.cb_EmployeeList.TabIndex = 0;
            // 
            // dt_StartDate
            // 
            this.dt_StartDate.Location = new System.Drawing.Point(97, 116);
            this.dt_StartDate.Name = "dt_StartDate";
            this.dt_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dt_StartDate.TabIndex = 1;
            this.dt_StartDate.Value = new System.DateTime(2023, 9, 22, 17, 53, 27, 0);
            // 
            // dt_EndDate
            // 
            this.dt_EndDate.Location = new System.Drawing.Point(97, 155);
            this.dt_EndDate.Name = "dt_EndDate";
            this.dt_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dt_EndDate.TabIndex = 2;
            // 
            // btn_AddLeave
            // 
            this.btn_AddLeave.Location = new System.Drawing.Point(97, 237);
            this.btn_AddLeave.Name = "btn_AddLeave";
            this.btn_AddLeave.Size = new System.Drawing.Size(200, 38);
            this.btn_AddLeave.TabIndex = 3;
            this.btn_AddLeave.Text = "İzin Gir";
            this.btn_AddLeave.UseVisualStyleBackColor = true;
            this.btn_AddLeave.Click += new System.EventHandler(this.btn_AddLeave_Click);
            // 
            // rTxt_Reason
            // 
            this.rTxt_Reason.Location = new System.Drawing.Point(97, 182);
            this.rTxt_Reason.Name = "rTxt_Reason";
            this.rTxt_Reason.Size = new System.Drawing.Size(200, 49);
            this.rTxt_Reason.TabIndex = 4;
            this.rTxt_Reason.Text = "";
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 553);
            this.Controls.Add(this.rTxt_Reason);
            this.Controls.Add(this.btn_AddLeave);
            this.Controls.Add(this.dt_EndDate);
            this.Controls.Add(this.dt_StartDate);
            this.Controls.Add(this.cb_EmployeeList);
            this.Name = "LeaveForm";
            this.Text = "LeaveForm";
            this.Load += new System.EventHandler(this.LeaveForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Button btn_AddLeave;
        private System.Windows.Forms.RichTextBox rTxt_Reason;
    }
}