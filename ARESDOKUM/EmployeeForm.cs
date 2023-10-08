using ARESDOKUM.Context;
using ARESDOKUM.Entity;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız.
            {
                // Yeni bir Employee nesnesi oluşturun ve değerleri TextBox'lardan alın
                Employee newEmployee = new Employee
                {
                    Name = txt_AddEmployee_Name.Text,
                    BaseHourlyRate = decimal.Parse(txt_AddEmployee_HourlyRate.Text),
                    DateOfStart = dateTimePicker1.Value
                };

                // Employee tablosuna yeni çalışanı ekleyin
                context.Employees.Add(newEmployee);

                // Değişiklikleri kaydedin
                context.SaveChanges();

                MessageBox.Show("Yeni çalışan başarıyla eklendi.");
                LoadEmployeeList();
            }
        }

        private void LoadEmployeeList()
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                var employees = context.Employees.ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Employee verilerini DataGridView'e ekleyin
                foreach (var employee in employees)
                {
                    // BaseHourlyRate'i TL sembolü ile biçimlendirin
                    string hourlyRateWithSymbol = $"{employee.BaseHourlyRate:C}";

                    dataGridView1.Rows.Add(
                        employee.EmployeeId,
                        employee.Name,
                        hourlyRateWithSymbol
                    );
                }
            }
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void txt_AddEmployee_Name_TextChanged(object sender, EventArgs e)
        {
            string input = txt_AddEmployee_Name.Text;

            // TextBox'a girilen metni karakter karakter kontrol edin
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    // Eğer girilen karakter harf veya boşluk karakteri değilse, bu karakteri kaldırın
                    txt_AddEmployee_Name.Text = txt_AddEmployee_Name.Text.Replace(c.ToString(), string.Empty);
                }
            }
        }

        private void txt_AddEmployee_HourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayıları ve virgülü ve kontrol tuşlarını (örneğin Backspace) kabul edelim
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Bu karakteri işleme alma
            }

            // Sadece bir virgül girişine izin verelim
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true; // Birden fazla virgül girişine izin verme
            }
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
