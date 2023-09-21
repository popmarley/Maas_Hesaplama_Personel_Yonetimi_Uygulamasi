using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARESDOKUM
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			
			// Giriş formunu yeniden aç
			Giris girisForm = new Giris();
			girisForm.Show();
			this.Hide();

		}
	}
}
