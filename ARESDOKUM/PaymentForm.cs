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
using ARESDOKUM.Entity;

namespace ARESDOKUM
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void LoadDataGrid()
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
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Add(
                        payment.PaymentId,
                        payment.Employee.Name, // İşçinin adını kullanın
                        $"{payment.Amount:C}", // Amount'u para birimi formatında yazdırın
                        payment.PaymentDate.ToString("dd.MM.yyyy"), // Tarihi belirlediğiniz biçimde yazdırın
                        payment.Description
                    )];

                    // Ödeme yapılan tutarı yeşil renkte yazdırın
                    row.Cells[2].Style.ForeColor = Color.Green;
                }
            }
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {

            LoadDataGrid();
            EmployeeList();

        }

        private void EmployeeList()
        {
            using (var context = new MyDbContext())
            {
                Employee allEmployees = new Employee
                {
                    EmployeeId = -1, // Özel bir değer atayabilirsiniz
                    Name = "Tüm Çalışanlar" // Görünen metin
                };

                // Combobox'ı doldururken bu özel nesneyi de ekleyin.
                var employees = context.Employees.ToList();
                employees.Insert(0, allEmployees); // "Tüm Çalışanlar" seçeneğini en başa ekleyin.

                // ComboBox'ı doldurun
                cb_EmployeeList.DisplayMember = "Name"; // ComboBox'ta görünen metin
                cb_EmployeeList.ValueMember = "EmployeeId"; // Seçilen değer
                cb_EmployeeList.DataSource = employees;
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            btn_FilterClear.Visible = true;
            // Başlangıç ve bitiş tarihlerini DateTimePicker'lardan alın
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Seçilen çalışanı alın
            int selectedEmployeeId = (int)cb_EmployeeList.SelectedValue;

            // Tüm Çalışanlar seçeneği seçildiğinde EmployeeId'yi -1 olarak ayarlayın
            if (selectedEmployeeId == -1)
            {
                // Tüm çalışanlar için filtreleme yapmak istiyorsak EmployeeId'yi -1 olarak ayarlayın
                selectedEmployeeId = -1;
            }

            // Payment tablosundaki ödemeleri seçilen tarih aralığına ve çalışana göre filtreleyin
            using (var context = new MyDbContext())
            {
                var query = context.Payments
                    .Include(p => p.Employee)
                    .Where(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate);

                // Seçilen çalışanı filtrelemeye dahil etmek için kontrol edin
                if (selectedEmployeeId != -1)
                {
                    query = query.Where(p => p.EmployeeId == selectedEmployeeId);
                }

                var filteredPayments = query.ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Filtrelenmiş ödemeleri DataGridView'e ekleyin
                foreach (var payment in filteredPayments)
                {
                    dataGridView1.Rows.Add(
                        payment.PaymentId,
                        payment.Employee.Name,
                        payment.PaymentDate.ToShortDateString(),
                        $"{payment.Amount:C}", // Amount alanına TL sembolü ekleyin
                        payment.Description
                    );
                }
            }


        }

        private void btn_FilterClear_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

