using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace South_Tech_Project
{
    public partial class EmployeesForm : Form
    {
        public static void AddEmployee(Guid facility, string fname, string mname, string lname, string phone, int position, decimal salary, string title, bool working)
        {
            using (var MedDB = new MedicalEntities())
            {
                Employee e = new Employee()
                {
                    EmployeeID = Guid.NewGuid(),
                    FirstName = fname,
                    MiddleName = mname,
                    LastName = lname,
                    Phone = phone,
                    Position = position,
                    Salary = salary,
                    Title = title,
                    Working = working
                };

                MedDB.Employees.Add(e);
                MedDB.SaveChanges();
            }
        }

        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
