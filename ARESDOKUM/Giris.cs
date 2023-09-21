using ARESDOKUM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARESDOKUM.Entity;

namespace ARESDOKUM
{
	public partial class Giris : Form
	{
	 

		public Giris()
		{
			InitializeComponent();
		}

		public void btn_Giris_Click(object sender, EventArgs e)
		{
			using (var context = new MyDbContext())
			{
				var userInDb = context.Users
									  .FirstOrDefault(u => u.UserName == txt_UserName.Text && u.UserPassword == txt_UserPassword.Text);

				if (userInDb != null)
				{
					// Doğru kullanıcı adı ve şifreyle eşleşen bir kullanıcı bulundu.
					Main mainForm = new Main(); // Main formunuzun adını varsayıyorum. Doğru form adını kullanmalısınız.
					mainForm.Show();
					this.Hide(); // Şu anki formu (giriş formunu) gizleyin.
				}
				else
				{
					MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
				}
			}
		}
	}
}
