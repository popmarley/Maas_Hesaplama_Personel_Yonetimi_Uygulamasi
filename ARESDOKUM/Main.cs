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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            // Giriş formunu yeniden aç
            Giris girisForm = new Giris();
            girisForm.Show();
            this.Hide();

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

        private void btn_ExittoMain_Click(object sender, EventArgs e)
        {
        Application.Exit();
        }
    }
}
