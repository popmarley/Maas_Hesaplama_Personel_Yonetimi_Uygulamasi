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
			this.txt_UserName = new System.Windows.Forms.TextBox();
			this.txt_UserPassword = new System.Windows.Forms.TextBox();
			this.btn_Giris = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_UserName
			// 
			this.txt_UserName.Location = new System.Drawing.Point(216, 212);
			this.txt_UserName.Multiline = true;
			this.txt_UserName.Name = "txt_UserName";
			this.txt_UserName.Size = new System.Drawing.Size(224, 22);
			this.txt_UserName.TabIndex = 1;
			// 
			// txt_UserPassword
			// 
			this.txt_UserPassword.Location = new System.Drawing.Point(216, 335);
			this.txt_UserPassword.Multiline = true;
			this.txt_UserPassword.Name = "txt_UserPassword";
			this.txt_UserPassword.Size = new System.Drawing.Size(224, 22);
			this.txt_UserPassword.TabIndex = 2;
			// 
			// btn_Giris
			// 
			this.btn_Giris.Location = new System.Drawing.Point(288, 428);
			this.btn_Giris.Name = "btn_Giris";
			this.btn_Giris.Size = new System.Drawing.Size(75, 23);
			this.btn_Giris.TabIndex = 3;
			this.btn_Giris.Text = "Giriş";
			this.btn_Giris.UseVisualStyleBackColor = true;
			this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
			// 
			// Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 473);
			this.Controls.Add(this.btn_Giris);
			this.Controls.Add(this.txt_UserPassword);
			this.Controls.Add(this.txt_UserName);
			this.Name = "Giris";
			this.Text = "Giris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_UserName;
		private System.Windows.Forms.TextBox txt_UserPassword;
		private System.Windows.Forms.Button btn_Giris;
	}
}