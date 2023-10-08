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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            EmployeeForm EmployeeForm = new EmployeeForm();
            EmployeeForm.Show();
            this.Hide();
        }

        private void btn_Shift_Click(object sender, EventArgs e)
        {
            ShiftForm shiftForm = new ShiftForm();
            shiftForm.Show();
            this.Hide();
        }

        private void btn_Leaves_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();  
            leaveForm.Show();
            this.Hide();
        }

        private void btn_ExittoMain_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_Advance_Click(object sender, EventArgs e)
        {
            AdvanceForm advanceForm = new AdvanceForm();  
            advanceForm.Show();
            this.Hide();
        }

        private void btn_CalculateSalary_Click(object sender, EventArgs e)
        {
            CalculateSalaryForm calculateSalaryForm = new CalculateSalaryForm();
            calculateSalaryForm.Show();
            this.Hide();
        }

        private void btn_Payments_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
