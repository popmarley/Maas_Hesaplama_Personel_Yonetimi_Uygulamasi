using ARESDOKUM.Context;
using ARESDOKUM.Entity;
using Microsoft.EntityFrameworkCore;
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
    public partial class LeaveForm : Form
    {
        public LeaveForm()
        {
            InitializeComponent();
        }

        private void LoadLeaveDataToDataGridView()
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                var leaves = context.Leaves
                    .Include(l => l.Employee) // Employee ilişkisini yükleyin
                    .Select(l => new
                    {
                        l.LeaveId,
                        EmployeeName = l.Employee.Name, // İlişkili Employee'in adı
                        l.StartDate,
                        l.EndDate,
                        l.Reason
                    })
                    .ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Leave verilerini DataGridView'e ekleyin
                foreach (var leave in leaves)
                {
                    int rowIndex = dataGridView1.Rows.Add(
                        leave.LeaveId,
                        leave.EmployeeName,
                        leave.StartDate.ToShortDateString(),
                        leave.EndDate.ToShortDateString(),
                        leave.Reason
                    );

                    // EndDate hücresini alın
                    DataGridViewCell endDateCell = dataGridView1.Rows[rowIndex].Cells["EndDate"];
                    if (endDateCell != null && endDateCell.Value != null)
                    {
                        DateTime endDate;
                        if (DateTime.TryParse(endDateCell.Value.ToString(), out endDate))
                        {
                            if (endDate < DateTime.Now)
                            {
                                // EndDate şuanki tarihten önce ise Kırmızı renkte yaz
                                endDateCell.Style.ForeColor = Color.Red;
                            }
                            else
                            {
                                // EndDate şuanki tarihten sonra ise Yeşil renkte yaz
                                endDateCell.Style.ForeColor = Color.Green;
                            }
                        }
                    }
                }
            }
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


        private void LeaveForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            LoadLeaveDataToDataGridView();
        }

        private void btn_AddLeave_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız.
            {
                // ComboBox'tan seçilen çalışanın EmployeeId'sini alın
                int selectedEmployeeId = (int)cb_EmployeeList.SelectedValue;

                // Başlangıç ve bitiş tarihlerini dateTimePicker'lardan alın
                DateTime startDate = dt_StartDate.Value;
                DateTime endDate = dt_EndDate.Value;

                // Gerekirse nedeni alın (örneğin, txt_Reason TextBox'ından)
                string reason = rTxt_Reason.Text;

                // Yeni bir Leave nesnesi oluşturun ve değerleri atayın
                Leave newLeave = new Leave
                {
                    EmployeeId = selectedEmployeeId,
                    StartDate = startDate,
                    EndDate = endDate,
                    Reason = reason
                };

                // Leaves tablosuna yeni izin ekleyin
                context.Leaves.Add(newLeave);

                // Değişiklikleri veritabanına kaydedin
                context.SaveChanges();

                MessageBox.Show("İzin başarıyla eklendi.");
                LoadLeaveDataToDataGridView();
            }
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            btn_FilterClear.Visible = true;
            // Başlangıç ve bitiş tarihlerini DateTimePicker'lardan alın
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Seçilen çalışanın ID'sini alın
            int selectedEmployeeId = (int)cb_EmployeeListFilter.SelectedValue;

            // Tüm çalışanlar seçiliyse
            if (selectedEmployeeId == -1)
            {
                // Leave tablosundaki tüm izinleri seçilen tarih aralığına göre filtrelemeyin
                using (var context = new MyDbContext())
                {
                    var allLeaves = context.Leaves
                        .Include(l => l.Employee)
                        .Where(l => l.EndDate >= startDate && l.StartDate <= endDate)
                        .ToList();

                    // DataGridView'i temizleyin
                    dataGridView1.Rows.Clear();

                    // Tüm izinleri DataGridView'e ekleyin
                    foreach (var leave in allLeaves)
                    {
                        dataGridView1.Rows.Add(
                            leave.LeaveId,
                            leave.Employee.Name, // İşçinin adını kullanın
                            leave.StartDate.ToShortDateString(),
                            leave.EndDate.ToShortDateString(),
                            leave.Reason
                        );
                    }
                }
            }
            else
            {
                // Seçilen çalışanın izinlerini seçilen tarih aralığına ve çalışana göre filtreleyin
                using (var context = new MyDbContext())
                {
                    var filteredLeaves = context.Leaves
                        .Include(l => l.Employee)
                        .Where(l => l.EndDate >= startDate && l.StartDate <= endDate && l.EmployeeId == selectedEmployeeId)
                        .ToList();

                    // DataGridView'i temizleyin
                    dataGridView1.Rows.Clear();

                    // Filtrelenmiş izinleri DataGridView'e ekleyin
                    foreach (var leave in filteredLeaves)
                    {
                        dataGridView1.Rows.Add(
                            leave.LeaveId,
                            leave.Employee.Name, // İşçinin adını kullanın
                            leave.StartDate.ToShortDateString(),
                            leave.EndDate.ToShortDateString(),
                            leave.Reason
                        );
                    }
                }
            }

            // Filtrelemeyi yaptıktan sonra bitiş tarihlerini renklendir
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // EndDate hücresini alın
                DataGridViewCell endDateCell = row.Cells["EndDate"];
                if (endDateCell != null && endDateCell.Value != null)
                {
                    DateTime endDatee;
                    if (DateTime.TryParse(endDateCell.Value.ToString(), out endDatee))
                    {
                        if (endDatee < DateTime.Now)
                        {
                            // EndDate şuanki tarihten önce ise Kırmızı renkte yaz
                            endDateCell.Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            // EndDate şuanki tarihten sonra ise Yeşil renkte yaz
                            endDateCell.Style.ForeColor = Color.Green;
                        }
                    }
                }
            }


        }

        private void btn_FilterClear_Click(object sender, EventArgs e)
        {
            LoadLeaveDataToDataGridView();
        }
    }
}
