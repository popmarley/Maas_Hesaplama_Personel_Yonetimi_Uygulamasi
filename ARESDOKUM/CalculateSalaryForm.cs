﻿using ARESDOKUM.Context;
using ARESDOKUM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

            DateTime currentDate = DateTime.Today;

            // dt_EndDate'e bugünün tarihini ata
            dt_EndDate.Value = currentDate;

            // dt_StartDate'e 1 ay önceki tarihi ata
            DateTime oneMonthAgo = currentDate.AddMonths(-1);
            dt_StartDate.Value = oneMonthAgo;
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

                // Eğer avans talebi varsa, talep miktarını hesaplayın
                var advances = context.Advances
                    .Where(a => a.EmployeeId == selectedEmployee.EmployeeId &&
                                a.RequestDate >= startDate &&
                                a.RequestDate <= endDate)
                    .ToList();

                decimal totalAdvance = advances.Sum(a => a.Amount);

                // Maaşı sonucu label'e yazdırın
                lbl_Salary.Text = $"{totalSalary:C}";

                // Eğer talep varsa, talep miktarını lbl_Advance'e yazın
                if (advances.Any())
                {
                    string advanceMessage = $"{selectedEmployee.Name} ";
                    foreach (var advance in advances)
                    {
                        advanceMessage += $"{advance.RequestDate.ToShortDateString()} tarihinde {advance.Amount:C} Avans Ödenmiştir.\n";
                    }

                    lbl_Advance.Text = advanceMessage;
                }
                else
                {
                    lbl_Advance.Text = "Belirtilen Tarihler Arasında İşçiye Avans Ödemesi Yapılmamıştır.";
                }

                // Maaştan avansı çıkarıp sonucu lbl_Response'e yazın
                decimal netSalary = totalSalary - totalAdvance;
                lbl_Response.Text = $"{netSalary:C}";
            }
        }

        private void btn_MakePayment_Click(object sender, EventArgs e)
        {
            // Seçilen çalışanı alın
            Employee selectedEmployee = (Employee)cb_EmployeeList.SelectedItem;

            // Ödenen tutarı lbl_Response'dan alın
            decimal amountPaid = decimal.Parse(lbl_Response.Text, NumberStyles.Currency);

            // Ödeme tarihini şu anki tarih olarak alın
            DateTime paymentDate = DateTime.Now;

            // Ödeme açıklamasını istediğiniz şekilde alın (örneğin bir metin kutusu kullanabilirsiniz)
            string description = rTxt_Description.Text; // Örnek bir açıklama

            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                // Payment tablosuna yeni bir ödeme kaydı ekleyin
                Payment payment = new Payment
                {
                    EmployeeId = selectedEmployee.EmployeeId,
                    Amount = amountPaid,
                    PaymentDate = paymentDate,
                    Description = description
                };

                context.Payments.Add(payment);
                context.SaveChanges();

                MessageBox.Show("Ödeme başarıyla kaydedildi.");
            }
        }
    }
}
