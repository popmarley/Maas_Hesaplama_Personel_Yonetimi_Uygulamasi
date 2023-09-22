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
                        a.Amount,
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
            using (var context = new MyDbContext())
            {
                var employees = context.Employees.ToList();

                // ComboBox'ı doldurun
                cb_EmployeeList.DisplayMember = "Name"; // ComboBox'ta görünen metin
                cb_EmployeeList.ValueMember = "EmployeeId"; // Seçilen değer
                cb_EmployeeList.DataSource = employees;
            }
            LoadAdvanceList();
        }
    }
}
