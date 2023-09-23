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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.EmployeeName,
            this.Amount,
            this.PaymentDate,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(279, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 511);
            this.dataGridView1.TabIndex = 23;
            // 
            // PaymentId
            // 
            this.PaymentId.HeaderText = "Id";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.Width = 50;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Ad Soyad";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Ödeme Yapılan Tutar";
            this.Amount.Name = "Amount";
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Ödeme Tarihi";
            this.PaymentDate.Name = "PaymentDate";
            // 
            // Description
            // 
            this.Description.HeaderText = "Açıklama";
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ödenenler";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(989, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Main);
            this.Controls.Add(this.btn_Exit);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}