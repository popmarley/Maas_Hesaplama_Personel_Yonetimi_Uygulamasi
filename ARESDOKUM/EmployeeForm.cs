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
            }
        }
    }
}
