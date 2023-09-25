namespace ARESDOKUM
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btn_Main = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.cb_EmployeeList = new System.Windows.Forms.ComboBox();
            this.btn_FilterClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_Main.Location = new System.Drawing.Point(9, 489);
            this.btn_Main.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(86, 73);
            this.btn_Main.TabIndex = 22;
            this.btn_Main.UseVisualStyleBackColor = false;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(98, 489);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(86, 73);
            this.btn_Exit.TabIndex = 21;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.EmployeeName,
            this.Amount,
            this.PaymentDate,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(273, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(694, 460);
            this.dataGridView1.TabIndex = 23;
            // 
            // PaymentId
            // 
            this.PaymentId.HeaderText = "Sıra";
            this.PaymentId.MinimumWidth = 6;
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.Width = 50;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Ad Soyad";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Ödeme Yapılan Tutar";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.Width = 125;
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Ödeme Tarihi";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Açıklama";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ödenenler";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerStart.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(23, 39);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(94, 22);
            this.dateTimePickerStart.TabIndex = 36;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(123, 39);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerEnd.TabIndex = 37;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Filter.BackgroundImage")));
            this.btn_Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Filter.Location = new System.Drawing.Point(352, 37);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(29, 31);
            this.btn_Filter.TabIndex = 38;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // cb_EmployeeList
            // 
            this.cb_EmployeeList.FormattingEnabled = true;
            this.cb_EmployeeList.Location = new System.Drawing.Point(225, 39);
            this.cb_EmployeeList.Name = "cb_EmployeeList";
            this.cb_EmployeeList.Size = new System.Drawing.Size(121, 24);
            this.cb_EmployeeList.TabIndex = 39;
            // 
            // btn_FilterClear
            // 
            this.btn_FilterClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_FilterClear.BackgroundImage")));
            this.btn_FilterClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_FilterClear.Location = new System.Drawing.Point(387, 37);
            this.btn_FilterClear.Name = "btn_FilterClear";
            this.btn_FilterClear.Size = new System.Drawing.Size(29, 31);
            this.btn_FilterClear.TabIndex = 40;
            this.btn_FilterClear.UseVisualStyleBackColor = true;
            this.btn_FilterClear.Visible = false;
            this.btn_FilterClear.Click += new System.EventHandler(this.btn_FilterClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cb_EmployeeList);
            this.groupBox1.Controls.Add(this.btn_FilterClear);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.btn_Filter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(273, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 84);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(989, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ares Döküm | PYS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox cb_EmployeeList;
        private System.Windows.Forms.Button btn_FilterClear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}