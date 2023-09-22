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
                    dataGridView1.Rows.Add(
                        leave.LeaveId,
                        leave.EmployeeName,
                        leave.StartDate.ToShortDateString(),
                        leave.EndDate.ToShortDateString(),
                        leave.Reason
                    );
                }
            }
        }


        private void LeaveForm_Load(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                var employees = context.Employees.ToList();

                // ComboBox'ı doldurun
                cb_EmployeeList.DisplayMember = "Name"; // ComboBox'ta görünen metin
                cb_EmployeeList.ValueMember = "EmployeeId"; // Seçilen değer
                cb_EmployeeList.DataSource = employees;
            }
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
    }
}
