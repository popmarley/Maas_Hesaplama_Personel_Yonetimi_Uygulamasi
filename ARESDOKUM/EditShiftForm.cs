using ARESDOKUM.Context;
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
    public partial class EditShiftForm : Form
    {
        public EditShiftForm(int shiftId, string employeeName, DateTime shiftDate, decimal hoursWorked)
        {
            InitializeComponent();

            // Gelen verileri ilgili kontrol öğelerine aktarın
            lbl_EmployeeName.Text = "Çalışan Adı: " + employeeName;
            dateTimePicker1.Value = shiftDate;
            txt_Hours.Text = hoursWorked.ToString(); // decimal veriyi string olarak ayarlayın

            // Düzenleme işlemi için bir ShiftId saklayabilirsiniz (güncelleme işlemi yaparken kullanılabilir)
            label2.Text = shiftId.ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                // ShiftId bilgisini label2'den alın
                int shiftId = int.Parse(label2.Text);

                // Veritabanından ilgili kaydı bulun
                var shiftToUpdate = context.Shifts.FirstOrDefault(s => s.ShiftId == shiftId);

                if (shiftToUpdate != null)
                {
                    // Yeni verileri atayın
                    shiftToUpdate.Date = dateTimePicker1.Value;
                    decimal newHoursWorked;
                    if (decimal.TryParse(txt_Hours.Text, out newHoursWorked))
                    {
                        shiftToUpdate.HoursWorked = newHoursWorked;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir saat değeri girin.");
                        return;
                    }

                    // Veritabanını güncelleyin
                    context.SaveChanges();

                    MessageBox.Show("Shift bilgileri güncellendi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Belirtilen ShiftId ile kayıtlı bir vardiya bulunamadı.");
                }
            }

        }

        private void txt_Hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayılar, virgül (,) ve geri tuş (Backspace) kabul edilir
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Geçersiz karakterleri engelle
            }

            // Sadece bir virgül (,) izin ver
            if (e.KeyChar == ',' && txt_Hours.Text.Contains(","))
            {
                e.Handled = true; // Birden fazla virgül (,) girişini engelle
            }
        }
    }
}
