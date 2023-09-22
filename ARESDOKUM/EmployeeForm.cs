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
                    BaseHourlyRate = decimal.Parse(txt_AddEmployee_HourlyRate.Text)
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
                    dataGridView1.Rows.Add(
                        employee.EmployeeId,
                        employee.Name,
                        employee.BaseHourlyRate
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
    }
}
