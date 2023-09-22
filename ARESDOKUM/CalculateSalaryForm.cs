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
    }
}
