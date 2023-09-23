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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftForm));
			this.btn_AddShift = new System.Windows.Forms.Button();
			this.txt_ShiftHour = new System.Windows.Forms.TextBox();
			this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
			this.dt_Date = new System.Windows.Forms.DateTimePicker();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Main = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ShiftId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoursWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PaymentMade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_AddShift
			// 
			this.btn_AddShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_AddShift.Location = new System.Drawing.Point(16, 188);
			this.btn_AddShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_AddShift.Name = "btn_AddShift";
			this.btn_AddShift.Size = new System.Drawing.Size(383, 64);
			this.btn_AddShift.TabIndex = 0;
			this.btn_AddShift.Text = "Veriyi Gir";
			this.btn_AddShift.UseVisualStyleBackColor = true;
			this.btn_AddShift.Click += new System.EventHandler(this.btn_AddShift_Click);
			// 
			// txt_ShiftHour
			// 
			this.txt_ShiftHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_ShiftHour.Location = new System.Drawing.Point(132, 137);
			this.txt_ShiftHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_ShiftHour.Name = "txt_ShiftHour";
			this.txt_ShiftHour.Size = new System.Drawing.Size(265, 26);
			this.txt_ShiftHour.TabIndex = 1;
			// 
			// cb_EmployeeList
			// 
			this.cb_EmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cb_EmployeeList.FormattingEnabled = true;
			this.cb_EmployeeList.Location = new System.Drawing.Point(132, 47);
			this.cb_EmployeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb_EmployeeList.Name = "cb_EmployeeList";
			this.cb_EmployeeList.Size = new System.Drawing.Size(265, 28);
			this.cb_EmployeeList.TabIndex = 2;
			// 
			// dt_Date
			// 
			this.dt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dt_Date.Location = new System.Drawing.Point(132, 91);
			this.dt_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dt_Date.Name = "dt_Date";
			this.dt_Date.Size = new System.Drawing.Size(265, 26);
			this.dt_Date.TabIndex = 3;
			this.dt_Date.ValueChanged += new System.EventHandler(this.dt_Date_ValueChanged);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
			this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Exit.FlatAppearance.BorderSize = 0;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Exit.Location = new System.Drawing.Point(143, 641);
			this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(115, 90);
			this.btn_Exit.TabIndex = 14;
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
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
			this.btn_Main.Location = new System.Drawing.Point(12, 641);
			this.btn_Main.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Main.Name = "btn_Main";
			this.btn_Main.Size = new System.Drawing.Size(115, 90);
			this.btn_Main.TabIndex = 13;
			this.btn_Main.UseVisualStyleBackColor = false;
			this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(51, 33);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(334, 43);
			this.label1.TabIndex = 15;
			this.label1.Text = "Giriş Çıkış Saatleri";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(87, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "İşçi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(71, 96);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Tarih";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(12, 140);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "Çalıştğı Saat";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.txt_ShiftHour);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btn_AddShift);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cb_EmployeeList);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dt_Date);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(41, 190);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(421, 271);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Çalışma Saati Girişi";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShiftId,
            this.EmployeeName,
            this.Date,
            this.HoursWorked,
            this.PaymentMade});
			this.dataGridView1.Location = new System.Drawing.Point(596, 33);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(685, 698);
			this.dataGridView1.TabIndex = 18;
			// 
			// ShiftId
			// 
			this.ShiftId.HeaderText = "Id";
			this.ShiftId.MinimumWidth = 6;
			this.ShiftId.Name = "ShiftId";
			this.ShiftId.Width = 50;
			// 
			// EmployeeName
			// 
			this.EmployeeName.HeaderText = "Ad Soyad";
			this.EmployeeName.MinimumWidth = 6;
			this.EmployeeName.Name = "EmployeeName";
			this.EmployeeName.Width = 120;
			// 
			// Date
			// 
			this.Date.HeaderText = "Tarih";
			this.Date.MinimumWidth = 6;
			this.Date.Name = "Date";
			this.Date.Width = 125;
			// 
			// HoursWorked
			// 
			this.HoursWorked.HeaderText = "Çalıştığı Saat";
			this.HoursWorked.MinimumWidth = 6;
			this.HoursWorked.Name = "HoursWorked";
			this.HoursWorked.Width = 125;
			// 
			// PaymentMade
			// 
			this.PaymentMade.HeaderText = "Ödenme Durumu";
			this.PaymentMade.MinimumWidth = 6;
			this.PaymentMade.Name = "PaymentMade";
			this.PaymentMade.Width = 125;
			// 
			// ShiftForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1303, 746);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Main);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ShiftForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Çıkış Saatleri";
			this.Load += new System.EventHandler(this.ShiftForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddShift;
        private System.Windows.Forms.TextBox txt_ShiftHour;
        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.DateTimePicker dt_Date;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursWorked;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMade;
    }
}