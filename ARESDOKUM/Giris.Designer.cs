namespace ARESDOKUM
{
	partial class Giris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.txt_UserPassword = new System.Windows.Forms.TextBox();
			this.btn_Giris = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_UserName
			// 
			this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_UserName.Location = new System.Drawing.Point(269, 225);
			this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(224, 26);
			this.txt_UserName.TabIndex = 1;
			// 
			// txt_UserPassword
			// 
			this.txt_UserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txt_UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_UserPassword.Location = new System.Drawing.Point(271, 278);
			this.txt_UserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_UserPassword.Name = "txt_UserPassword";
			this.txt_UserPassword.Size = new System.Drawing.Size(224, 26);
			this.txt_UserPassword.TabIndex = 2;
			// 
			// btn_Giris
			// 
			this.btn_Giris.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Giris.BackColor = System.Drawing.Color.YellowGreen;
			this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Giris.Location = new System.Drawing.Point(139, 321);
			this.btn_Giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Giris.Name = "btn_Giris";
			this.btn_Giris.Size = new System.Drawing.Size(356, 59);
			this.btn_Giris.TabIndex = 3;
			this.btn_Giris.Text = "Giriş";
			this.btn_Giris.UseVisualStyleBackColor = false;
			this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(136, 229);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(207, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Şifre:";
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
			this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
			this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_Exit.FlatAppearance.BorderSize = 0;
			this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Exit.Location = new System.Drawing.Point(3, 423);
			this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(115, 90);
			this.btn_Exit.TabIndex = 13;
			this.btn_Exit.UseVisualStyleBackColor = false;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ARESDOKUM.Properties.Resources.giris;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(653, 528);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txt_UserPassword);
			this.Controls.Add(this.txt_UserName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ares Döküm | PYS";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.TextBox txt_UserPassword;
		private System.Windows.Forms.Button btn_Giris;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
    }
}