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
    public partial class ShiftForm : Form
    {
		private int? currentlyEditingShiftId = null;
		public ShiftForm()
        {
            InitializeComponent();
        }

        private void LoadShiftDataToDataGridView()
        {
            using (var context = new MyDbContext()) // MyDbContext sınıfınıza uygun context adınızı kullanmalısınız
            {
                var shifts = context.Shifts
                    .Include(s => s.Employee) // Employee ilişkisini yükleyin
                    .Select(s => new
                    {
                        s.ShiftId,
                        EmployeeName = s.Employee.Name, // İlişkili Employee'in adı
                        s.Date,
                        s.HoursWorked,
                        s.PaymentMade // PaymentMade özelliğini ekleyin
                    })
                    .ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Shift verilerini DataGridView'e ekleyin
                foreach (var shift in shifts)
                {
                    string paymentStatus = shift.PaymentMade ? "Ödendi" : "Ödenmedi"; // PaymentMade durumunu belirleyin

                    dataGridView1.Rows.Add(
                        shift.ShiftId,
                        shift.EmployeeName,
                        shift.Date.ToShortDateString(),
                        shift.HoursWorked,
                        paymentStatus // PaymentMade durumunu DataGridView'e ekleyin
                    );
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


        private void ShiftForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            LoadShiftDataToDataGridView();
            AddButtonColumnsToDataGridView();

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
                    MessageBox.Show("Lütfen geçerli bir saat dilimi giriniz!");
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
                LoadShiftDataToDataGridView();

				txt_ShiftHour.Text = "";  // Bu satırı ekleyerek txt_ShiftHour textbox'ını temizliyoruz.
			}
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Ödeme durumunun bulunduğu sütunu kontrol ediyoruz
			if (dataGridView1.Columns[e.ColumnIndex].Name == "PaymentMade") // Burada "PaymentMade" sütun adınızın ne olduğuna bağlı olarak değiştirilmelidir
			{
				if (e.Value != null)
				{
					string cellValue = e.Value.ToString();
					if (cellValue == "Ödendi")
					{
						dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
					}
					else if (cellValue == "Ödenmedi")
					{
						dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					}
				}
			}
		}

		private void AddButtonColumnsToDataGridView()
		{
			// Düzenle buton sütunu
			DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
			editButtonColumn.Name = "Duzenle";
			editButtonColumn.Text = "Düzenle";
			editButtonColumn.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(editButtonColumn);

			// Sil buton sütunu
			DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
			deleteButtonColumn.Name = "Sil";
			deleteButtonColumn.Text = "Sil";
			deleteButtonColumn.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(deleteButtonColumn);
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Sütun indeksi geçerli bir indekse işaret ediyorsa
			if (e.RowIndex >= 0)
			{
				// Eğer tıklanan sütun "Sil" butonu ise
				if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil")
				{
					DialogResult result = MessageBox.Show("Bu veriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

					if (result == DialogResult.Yes)
					{
						// Silme işlemi yap
						int shiftId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ShiftId"].Value);  // ShiftId sütununuzu kullanarak ilgili satırın ID'sini alın
						DeleteShift(shiftId);  // Bu fonksiyonu oluşturmalısınız ve ShiftId'yi parametre olarak alarak ilgili satırı veritabanından silmelisiniz
						LoadShiftDataToDataGridView();  // Güncel verileri tekrar yükle
					}
				}
				// Eğer tıklanan sütun "Düzenle" butonu ise
				else if (dataGridView1.Columns[e.ColumnIndex].Name == "Duzenle")
				{
                    // Seçilen satırı alın
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Satırdan gerekli verileri çıkarın
                    int shiftId = Convert.ToInt32(selectedRow.Cells["ShiftId"].Value);
                    string employeeName = selectedRow.Cells["EmployeeName"].Value.ToString();
                    DateTime shiftDate = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                    decimal hoursWorked = Convert.ToDecimal(selectedRow.Cells["HoursWorked"].Value);

                    // EditShiftForm'u oluşturun ve verileri aktarın
                    EditShiftForm editShiftForm = new EditShiftForm(shiftId, employeeName, shiftDate, hoursWorked);

                    // EditShiftForm'u gösterin
                    editShiftForm.ShowDialog();

                    // Daha sonra güncellenmiş verileri yeniden yükleyebilirsiniz
                    LoadShiftDataToDataGridView(); // Bu metodu projenizde nasıl tanımladığınıza bağlı olarak değiştirebilirsiniz
                }
			}
		}

		private void DeleteShift(int shiftId)
		{
			using (var context = new MyDbContext())
			{
				var shiftToDelete = context.Shifts.Find(shiftId);
				if (shiftToDelete != null)
				{
					context.Shifts.Remove(shiftToDelete);
					context.SaveChanges();
				}
			}
		}

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            btn_FilterClear.Visible = true;
            // Başlangıç ve bitiş tarihlerini DateTimePicker'lardan alın
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Seçilen çalışanın ID'sini alın
            int selectedEmployeeId = (int)cb_EmployeeListFilter.SelectedValue;

            // Shift tablosundaki vardiyaları seçilen tarih aralığına ve çalışana göre filtreleyin
            using (var context = new MyDbContext())
            {
                var filteredShifts = context.Shifts
                    .Include(s => s.Employee)
                    .Where(s => s.Date >= startDate && s.Date <= endDate &&
                                (selectedEmployeeId == -1 || s.EmployeeId == selectedEmployeeId)) // -1 seçiliyse tüm çalışanlar için filtrele
                    .ToList();

                // DataGridView'i temizleyin
                dataGridView1.Rows.Clear();

                // Filtrelenmiş vardiyaları DataGridView'e ekleyin
                foreach (var shift in filteredShifts)
                {
                    dataGridView1.Rows.Add(
                        shift.ShiftId,
                        shift.Employee.Name,
                        shift.Date.ToShortDateString(),
                        shift.HoursWorked,
                        shift.PaymentMade ? "Ödendi" : "Ödenmedi"
                    );
                }
            }
        }

        private void btn_FilterClear_Click(object sender, EventArgs e)
        {
            LoadShiftDataToDataGridView();
        }

        private void ShiftForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
