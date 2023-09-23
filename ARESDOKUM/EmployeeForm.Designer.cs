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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
			this.txt_AddEmployee_Name = new System.Windows.Forms.TextBox();
			this.txt_AddEmployee_HourlyRate = new System.Windows.Forms.TextBox();
			this.btn_AddEmployee = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BaseHourlyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Main = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_AddEmployee_Name
			// 
			this.txt_AddEmployee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_AddEmployee_Name.Location = new System.Drawing.Point(155, 49);
			this.txt_AddEmployee_Name.Margin = new System.Windows.Forms.Padding(4);
			this.txt_AddEmployee_Name.Name = "txt_AddEmployee_Name";
			this.txt_AddEmployee_Name.Size = new System.Drawing.Size(184, 26);
			this.txt_AddEmployee_Name.TabIndex = 0;
			// 
			// txt_AddEmployee_HourlyRate
			// 
			this.txt_AddEmployee_HourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_AddEmployee_HourlyRate.Location = new System.Drawing.Point(155, 94);
			this.txt_AddEmployee_HourlyRate.Margin = new System.Windows.Forms.Padding(4);
			this.txt_AddEmployee_HourlyRate.Name = "txt_AddEmployee_HourlyRate";
			this.txt_AddEmployee_HourlyRate.Size = new System.Drawing.Size(184, 26);
			this.txt_AddEmployee_HourlyRate.TabIndex = 1;
			// 
			// btn_AddEmployee
			// 
			this.btn_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_AddEmployee.Location = new System.Drawing.Point(40, 144);
			this.btn_AddEmployee.Margin = new System.Windows.Forms.Padding(4);
			this.btn_AddEmployee.Name = "btn_AddEmployee";
			this.btn_AddEmployee.Size = new System.Drawing.Size(300, 49);
			this.btn_AddEmployee.TabIndex = 2;
			this.btn_AddEmployee.Text = "Çalışanı Ekle";
			this.btn_AddEmployee.UseVisualStyleBackColor = true;
			this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.Name,
            this.BaseHourlyRate});
			this.dataGridView1.Location = new System.Drawing.Point(540, 15);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(537, 553);
			this.dataGridView1.TabIndex = 3;
			// 
			// EmployeeId
			// 
			this.EmployeeId.HeaderText = "Id";
			this.EmployeeId.MinimumWidth = 6;
			this.EmployeeId.Name = "EmployeeId";
			this.EmployeeId.Width = 50;
			// 
			// Name
			// 
			this.Name.HeaderText = "Ad Soyad";
			this.Name.MinimumWidth = 6;
			this.Name.Name = "Name";
			this.Name.Width = 200;
			// 
			// BaseHourlyRate
			// 
			this.BaseHourlyRate.HeaderText = "Saatlik Kazanç";
			this.BaseHourlyRate.MinimumWidth = 6;
			this.BaseHourlyRate.Name = "BaseHourlyRate";
			this.BaseHourlyRate.Width = 125;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
			this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Exit.FlatAppearance.BorderSize = 0;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Exit.Location = new System.Drawing.Point(131, 501);
			this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(115, 90);
			this.btn_Exit.TabIndex = 13;
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(123, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 43);
			this.label1.TabIndex = 14;
			this.label1.Text = "Çalışanlar";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(47, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Çalışan Adı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(36, 97);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Saatlik Ücret";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.txt_AddEmployee_Name);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_AddEmployee_HourlyRate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btn_AddEmployee);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(29, 97);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(375, 215);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Yeni Çalışan Ekle";
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
			this.btn_Main.Location = new System.Drawing.Point(12, 501);
			this.btn_Main.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Main.Name = "btn_Main";
			this.btn_Main.Size = new System.Drawing.Size(115, 90);
			this.btn_Main.TabIndex = 18;
			this.btn_Main.UseVisualStyleBackColor = false;
			this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1225, 606);
			this.Controls.Add(this.btn_Main);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ares Döküm | PYS";
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AddEmployee_Name;
        private System.Windows.Forms.TextBox txt_AddEmployee_HourlyRate;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseHourlyRate;
    }
}