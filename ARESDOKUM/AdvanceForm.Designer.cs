namespace ARESDOKUM
{
    partial class AdvanceForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceForm));
			this.btn_Main = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
			this.txt_Amount = new System.Windows.Forms.TextBox();
			this.dt_RequestDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_AddAdvance = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.AdvanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.btn_Main.Location = new System.Drawing.Point(12, 523);
			this.btn_Main.Margin = new System.Windows.Forms.Padding(0);
			this.btn_Main.Name = "btn_Main";
			this.btn_Main.Size = new System.Drawing.Size(115, 90);
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
			this.btn_Exit.Location = new System.Drawing.Point(131, 523);
			this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(115, 90);
			this.btn_Exit.TabIndex = 19;
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(104, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 43);
			this.label1.TabIndex = 21;
			this.label1.Text = "Avans Talepleri";
			// 
			// cb_EmployeeList
			// 
			this.cb_EmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cb_EmployeeList.FormattingEnabled = true;
			this.cb_EmployeeList.Location = new System.Drawing.Point(199, 54);
			this.cb_EmployeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cb_EmployeeList.Name = "cb_EmployeeList";
			this.cb_EmployeeList.Size = new System.Drawing.Size(265, 28);
			this.cb_EmployeeList.TabIndex = 22;
			// 
			// txt_Amount
			// 
			this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_Amount.Location = new System.Drawing.Point(199, 98);
			this.txt_Amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_Amount.Name = "txt_Amount";
			this.txt_Amount.Size = new System.Drawing.Size(265, 26);
			this.txt_Amount.TabIndex = 23;
			// 
			// dt_RequestDate
			// 
			this.dt_RequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dt_RequestDate.Location = new System.Drawing.Point(199, 148);
			this.dt_RequestDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dt_RequestDate.Name = "dt_RequestDate";
			this.dt_RequestDate.Size = new System.Drawing.Size(265, 26);
			this.dt_RequestDate.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(139, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 20);
			this.label2.TabIndex = 25;
			this.label2.Text = "İşçi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(15, 102);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "Talep Edilen Avans";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(21, 151);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "Talep Edilen Tarih";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_AddAdvance);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cb_EmployeeList);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_Amount);
			this.groupBox1.Controls.Add(this.dt_RequestDate);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(16, 143);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(507, 322);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Avans Talebini Gir";
			// 
			// btn_AddAdvance
			// 
			this.btn_AddAdvance.Location = new System.Drawing.Point(25, 213);
			this.btn_AddAdvance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_AddAdvance.Name = "btn_AddAdvance";
			this.btn_AddAdvance.Size = new System.Drawing.Size(440, 73);
			this.btn_AddAdvance.TabIndex = 28;
			this.btn_AddAdvance.Text = "Avans Talebini Ekle";
			this.btn_AddAdvance.UseVisualStyleBackColor = true;
			this.btn_AddAdvance.Click += new System.EventHandler(this.btn_AddAdvance_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdvanceId,
            this.EmployeeName,
            this.Amount,
            this.RequestDate});
			this.dataGridView1.Location = new System.Drawing.Point(575, 47);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(576, 562);
			this.dataGridView1.TabIndex = 29;
			// 
			// AdvanceId
			// 
			this.AdvanceId.HeaderText = "Id";
			this.AdvanceId.MinimumWidth = 6;
			this.AdvanceId.Name = "AdvanceId";
			this.AdvanceId.Width = 50;
			// 
			// EmployeeName
			// 
			this.EmployeeName.HeaderText = "Ad Soyad";
			this.EmployeeName.MinimumWidth = 6;
			this.EmployeeName.Name = "EmployeeName";
			this.EmployeeName.Width = 120;
			// 
			// Amount
			// 
			this.Amount.HeaderText = "Miktar";
			this.Amount.MinimumWidth = 6;
			this.Amount.Name = "Amount";
			this.Amount.Width = 125;
			// 
			// RequestDate
			// 
			this.RequestDate.HeaderText = "Avans Tarihi";
			this.RequestDate.MinimumWidth = 6;
			this.RequestDate.Name = "RequestDate";
			this.RequestDate.Width = 125;
			// 
			// AdvanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(1311, 624);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Main);
			this.Controls.Add(this.btn_Exit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AdvanceForm";
			this.Text = "Ares Döküm | PYS";
			this.Load += new System.EventHandler(this.AdvanceForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.DateTimePicker dt_RequestDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddAdvance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvanceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
    }
}