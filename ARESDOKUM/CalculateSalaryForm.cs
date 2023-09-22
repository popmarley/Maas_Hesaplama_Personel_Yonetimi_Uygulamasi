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
    public partial class CalculateSalaryForm : Form
    {
        public CalculateSalaryForm()
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
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void CalculateSalaryForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void btn_CalculateSalary_Click(object sender, EventArgs e)
        {
            // Seçilen çalışanı ve tarih aralığını alın
            Employee selectedEmployee = (Employee)cb_EmployeeList.SelectedItem;
            DateTime startDate = dt_StartDate.Value.Date;
            DateTime endDate = dt_EndDate.Value.Date; // Saatin 00:00 olduğundan emin olmak için Date özelliğini kullanın

            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                // Seçilen çalışanın tüm vardiyalarını belirtilen tarih aralığında alın
                var shifts = context.Shifts
                    .Where(s => s.EmployeeId == selectedEmployee.EmployeeId && s.Date >= startDate && s.Date <= endDate)
                    .ToList();

                // Toplam çalışma saatlerini ve ücreti sıfırlayın
                decimal totalHoursWorked = 0;
                decimal totalSalary = 0;

                // Saatlik ücreti başlangıçta saatlik ücret olarak alın
                decimal hourlyRate = selectedEmployee.BaseHourlyRate;

                foreach (var shift in shifts)
                {
                    if (shift.Date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        hourlyRate = selectedEmployee.BaseHourlyRate * 1.5m; // Cumartesi günleri saatlik ücreti 1.5 ile çarpın
                    }
                    else if (shift.Date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        hourlyRate = selectedEmployee.BaseHourlyRate * 2m; // Pazar günleri saatlik ücreti 2 ile çarpın
                    }
                    else
                    {
                        hourlyRate = selectedEmployee.BaseHourlyRate; // Diğer günlerde saatlik ücreti normal değeri alın
                    }

                    totalHoursWorked += shift.HoursWorked; // Toplam çalışma saatlerini toplayın
                    totalSalary += hourlyRate * shift.HoursWorked; // Toplam ücreti hesaplayın
                }

                // Maaşı sonucu label'e yazdırın
                lbl_Salary.Text = $"{totalSalary:C}";
            }
        }



    }
}
