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
using Microsoft.EntityFrameworkCore;


namespace ARESDOKUM
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)=> Application.Exit();

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                var payments = context.Payments
                    .Include(p => p.Employee) // İşçi bilgisini yükleyin
                    .ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Payment verilerini DataGridView'e ekleyin
                foreach (var payment in payments)
                {
                    dataGridView1.Rows.Add(
                        payment.PaymentId,
                        payment.Employee.Name, // İşçinin adını kullanın
                        payment.Amount,
                        payment.PaymentDate,
                        payment.Description
                    );
                }
            }

        }
    }
}
