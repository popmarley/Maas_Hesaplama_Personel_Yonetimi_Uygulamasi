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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveForm));
			this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
			this.dt_StartDate = new System.Windows.Forms.DateTimePicker();
			this.dt_EndDate = new System.Windows.Forms.DateTimePicker();
			this.btn_AddLeave = new System.Windows.Forms.Button();
			this.rTxt_Reason = new System.Windows.Forms.RichTextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.LeaveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_Main = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cb_EmployeeList
			// 
			this.cb_EmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cb_EmployeeList.FormattingEnabled = true;
			this.cb_EmployeeList.Location = new System.Drawing.Point(177, 60);
			this.cb_EmployeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb_EmployeeList.Name = "cb_EmployeeList";
			this.cb_EmployeeList.Size = new System.Drawing.Size(265, 28);
			this.cb_EmployeeList.TabIndex = 0;
			// 
			// dt_StartDate
			// 
			this.dt_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dt_StartDate.Location = new System.Drawing.Point(177, 110);
			this.dt_StartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dt_StartDate.Name = "dt_StartDate";
			this.dt_StartDate.Size = new System.Drawing.Size(265, 26);
			this.dt_StartDate.TabIndex = 1;
			this.dt_StartDate.Value = new System.DateTime(2023, 9, 22, 17, 53, 27, 0);
			// 
			// dt_EndDate
			// 
			this.dt_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dt_EndDate.Location = new System.Drawing.Point(177, 158);
			this.dt_EndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dt_EndDate.Name = "dt_EndDate";
			this.dt_EndDate.Size = new System.Drawing.Size(265, 26);
			this.dt_EndDate.TabIndex = 2;
			// 
			// btn_AddLeave
			// 
			this.btn_AddLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_AddLeave.Location = new System.Drawing.Point(175, 310);
			this.btn_AddLeave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_AddLeave.Name = "btn_AddLeave";
			this.btn_AddLeave.Size = new System.Drawing.Size(267, 58);
			this.btn_AddLeave.TabIndex = 3;
			this.btn_AddLeave.Text = "İzin Gir";
			this.btn_AddLeave.UseVisualStyleBackColor = true;
			this.btn_AddLeave.Click += new System.EventHandler(this.btn_AddLeave_Click);
			// 
			// rTxt_Reason
			// 
			this.rTxt_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rTxt_Reason.Location = new System.Drawing.Point(175, 203);
			this.rTxt_Reason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rTxt_Reason.Name = "rTxt_Reason";
			this.rTxt_Reason.Size = new System.Drawing.Size(265, 85);
			this.rTxt_Reason.TabIndex = 4;
			this.rTxt_Reason.Text = "";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeaveId,
            this.EmployeeName,
            this.StartDate,
            this.EndDate,
            this.Reason});
			this.dataGridView1.Location = new System.Drawing.Point(489, 15);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1015, 651);
			this.dataGridView1.TabIndex = 5;
			// 
			// LeaveId
			// 
			this.LeaveId.HeaderText = "Id";
			this.LeaveId.MinimumWidth = 6;
			this.LeaveId.Name = "LeaveId";
			this.LeaveId.Width = 50;
			// 
			// EmployeeName
			// 
			this.EmployeeName.HeaderText = "Ad Soyad";
			this.EmployeeName.MinimumWidth = 6;
			this.EmployeeName.Name = "EmployeeName";
			this.EmployeeName.Width = 120;
			// 
			// StartDate
			// 
			this.StartDate.HeaderText = "Başlangıç Tarihi";
			this.StartDate.MinimumWidth = 6;
			this.StartDate.Name = "StartDate";
			this.StartDate.Width = 150;
			// 
			// EndDate
			// 
			this.EndDate.HeaderText = "Bitiş Tarihi";
			this.EndDate.MinimumWidth = 6;
			this.EndDate.Name = "EndDate";
			this.EndDate.Width = 150;
			// 
			// Reason
			// 
			this.Reason.HeaderText = "İzin Nedeni";
			this.Reason.MinimumWidth = 6;
			this.Reason.Name = "Reason";
			this.Reason.Width = 200;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(73, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 43);
			this.label1.TabIndex = 6;
			this.label1.Text = "İzin Talepleri";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(69, 64);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Çalışan Adı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(4, 113);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "İzin Başlangıç Tarihi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(48, 161);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "İzin Bitiş Tarihi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(68, 207);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "İzin Nedeni";
			// 
			// btn_Main
			// 
			this.btn_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Main.BackgroundImage")));
			this.btn_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Main.FlatAppearance.BorderSize = 0;
			this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Main.ForeColor = System.Drawing.Color.Coral;
			this.btn_Main.Location = new System.Drawing.Point(16, 576);
			this.btn_Main.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Main.Name = "btn_Main";
			this.btn_Main.Size = new System.Drawing.Size(115, 90);
			this.btn_Main.TabIndex = 11;
			this.btn_Main.UseVisualStyleBackColor = true;
			this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
			this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Exit.FlatAppearance.BorderSize = 0;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Exit.Location = new System.Drawing.Point(147, 576);
			this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(115, 90);
			this.btn_Exit.TabIndex = 12;
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cb_EmployeeList);
			this.groupBox1.Controls.Add(this.dt_StartDate);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dt_EndDate);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btn_AddLeave);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.rTxt_Reason);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(16, 113);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(451, 455);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "İzin Talebi Gir";
			// 
			// LeaveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1532, 681);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Main);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "LeaveForm";
			this.Text = "Ares Döküm | PYS";
			this.Load += new System.EventHandler(this.LeaveForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.DateTimePicker dt_StartDate;
        private System.Windows.Forms.DateTimePicker dt_EndDate;
        private System.Windows.Forms.Button btn_AddLeave;
        private System.Windows.Forms.RichTextBox rTxt_Reason;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}