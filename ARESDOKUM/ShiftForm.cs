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
    public partial class ShiftForm : Form
    {
        public ShiftForm()
        {
            InitializeComponent();
        }

        private void ShiftForm_Load(object sender, EventArgs e)
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

        private void dt_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddShift_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız.
            {
                // ComboBox'tan seçilen çalışanın EmployeeId'sini alın
                int selectedEmployeeId = (int)cb_EmployeeList.SelectedValue;

                // Saatlik çalışma süresini decimal olarak alın
                decimal hoursWorked;
                if (!decimal.TryParse(txt_ShiftHour.Text, out hoursWorked))
                {
                    MessageBox.Show("Geçersiz saatlik çalışma süresi!");
                    return; // Hatalı girişi işlemeyi durdur
                }

                // Tarih ve saat bilgisini dateTimePicker'dan alın
                DateTime shiftDate = dt_Date.Value;

                // Yeni bir Shift nesnesi oluşturun ve değerleri atayın
                Shift newShift = new Shift
                {
                    EmployeeId = selectedEmployeeId,
                    Date = shiftDate,
                    HoursWorked = hoursWorked
                };

                // Shifts tablosuna yeni vardiya ekleyin
                context.Shifts.Add(newShift);

                // Değişiklikleri veritabanına kaydedin
                context.SaveChanges();

                MessageBox.Show("Vardiya başarıyla eklendi.");
            }
        }
    }
}
