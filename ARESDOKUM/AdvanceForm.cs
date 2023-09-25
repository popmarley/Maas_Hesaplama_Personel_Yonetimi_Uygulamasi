using ARESDOKUM.Context;
using ARESDOKUM.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARESDOKUM
{
    public partial class AdvanceForm : Form
    {
        public AdvanceForm()
        {
            InitializeComponent();
        }

        private void LoadEmployeeList()
        {
            using (var context = new MyDbContext())
            {
                var employees = context.Employees.ToList();

                // ComboBox'ı doldurun
                cb_EmployeeList.DisplayMember = "Name"; // ComboBox'ta görünen metin
                cb_EmployeeList.ValueMember = "EmployeeId"; // Seçilen değer
                cb_EmployeeList.DataSource = employees;
            }

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
                cb_EmployeeListFilter.DisplayMember = "Name"; // ComboBox'ta görünen metin
                cb_EmployeeListFilter.ValueMember = "EmployeeId"; // Seçilen değer
                cb_EmployeeListFilter.DataSource = employees;
            }
        }

        private void LoadAdvanceList()
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                var advanceList = context.Advances
                    .Include(a => a.Employee) // Employee ilişkisini yükleyin
                    .Select(a => new
                    {
                        a.AdvanceId,
                        EmployeeName = a.Employee.Name, // İlişkili Employee'in adı
                        Amount = $"{a.Amount:C}", // TL simgesi eklemek için Amount'u biçimlendirin
                        a.RequestDate
                    })
                    .ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Advance verilerini DataGridView'e ekleyin
                foreach (var advance in advanceList)
                {
                    dataGridView1.Rows.Add(
                        advance.AdvanceId,
                        advance.EmployeeName,
                        advance.Amount,
                        advance.RequestDate
                    );
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void btn_AddAdvance_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                // Combobox'tan seçili çalışanın EmployeeId'sini alın
                int selectedEmployeeId = (int)cb_EmployeeList.SelectedValue;

                // TextBox'tan girilen avans miktarını alın
                decimal advanceAmount;
                if (!decimal.TryParse(txt_Amount.Text, out advanceAmount))
                {
                    MessageBox.Show("Geçerli bir avans miktarı girin.");
                    return;
                }

                // DateTimePicker'dan seçilen tarihi alın
                DateTime requestDate = dt_RequestDate.Value;

                // Advance nesnesi oluşturun
                Advance newAdvance = new Advance
                {
                    EmployeeId = selectedEmployeeId,
                    Amount = advanceAmount,
                    RequestDate = requestDate
                };

                // Advance tablosuna yeni avansı ekleyin
                context.Advances.Add(newAdvance);

                // Değişiklikleri kaydedin
                context.SaveChanges();

                MessageBox.Show("Yeni avans başarıyla eklendi.");
                LoadAdvanceList();
            }
        }

        private void AdvanceForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            LoadAdvanceList();
        }

        private void txt_Amount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir sayı, virgül veya geri tuşu (Backspace) değilse, işlemi iptal et
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Birden fazla virgül girişini önlemek için kontrol et
            if (e.KeyChar == ',' && txt_Amount.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void cb_EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            btn_FilterClear.Visible = true;
            // Başlangıç ve bitiş tarihlerini DateTimePicker'lardan alın
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Seçilen çalışanın ID'sini alın
            int selectedEmployeeId = (int)cb_EmployeeListFilter.SelectedValue;

            // Advance tablosundaki avansları seçilen tarih aralığına ve çalışana göre filtreleyin
            using (var context = new MyDbContext())
            {
                var filteredAdvances = context.Advances
                    .Include(a => a.Employee)
                    .Where(a => a.RequestDate >= startDate && a.RequestDate <= endDate &&
                                (selectedEmployeeId == -1 || a.EmployeeId == selectedEmployeeId)) // -1 seçiliyse tüm çalışanlar için filtrele
                    .ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Filtrelenmiş avansları DataGridView'e ekleyin
                foreach (var advance in filteredAdvances)
                {
                    dataGridView1.Rows.Add(
                        advance.AdvanceId,
                        advance.Employee.Name,
                        advance.RequestDate.ToShortDateString(),
                        $"{advance.Amount:C}" // Amount alanına TL sembolü ekleyin
                    );
                }
            }
        }

        private void btn_FilterClear_Click(object sender, EventArgs e)
        {
            LoadAdvanceList();
        }
    }
}
