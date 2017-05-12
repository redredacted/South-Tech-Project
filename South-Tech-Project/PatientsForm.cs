using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace South_Tech_Project
{
    public partial class PatientsForm : Form
    {
        private Facility _facility;
        private Patient selection;

        public PatientsForm(Facility facility)
        {
            _facility = facility;
            InitializeComponent();
        }

        public static void AddPatient(Guid facility, string fname, string mname, string lname, Guid nurse)
        {
            using (var MedDB = new MedicalEntities())
            {
                Patient p = new Patient()
                {
                    FacilityID = facility,
                    FirstName = fname,
                    MiddleName = mname,
                    LastName = lname,
                    NurseID = nurse,
                    Status = 0,
                    PatientID = Guid.NewGuid()
                };

                MedDB.Patients.Add(p);
                MedDB.SaveChanges();
            }
        }

        public static void AddPatient(Guid facility, string fname, string mname, string lname)
        {
            using (var MedDB = new MedicalEntities())
            {
                Patient p = new Patient()
                {
                    FacilityID = facility,
                    FirstName = fname,
                    MiddleName = mname,
                    LastName = lname,
                    Status = 0,
                    PatientID = Guid.NewGuid()
                };

                MedDB.Patients.Add(p);
                MedDB.SaveChanges();
            }
        }

        private void AddPatient(string fname, string mname, string lname, Guid nurse)
        {
            using (var MedDB = new MedicalEntities())
            {
                Patient p = new Patient()
                {
                    FacilityID = _facility.FacilityID,
                    FirstName = fname,
                    MiddleName = lname,
                    NurseID = nurse,
                    Status = 0,
                    PatientID = Guid.NewGuid()
                };

                MedDB.Patients.Add(p);
                MedDB.SaveChanges();
            }
        }

        private void AddPatient(string fname, string mname, string lname)
        {
            using (var MedDB = new MedicalEntities())
            {
                Patient p = new Patient()
                {
                    FacilityID = _facility.FacilityID,
                    FirstName = fname,
                    MiddleName = lname,
                    Status = 0,
                    PatientID = Guid.NewGuid()
                };

                MedDB.Patients.Add(p);
                MedDB.SaveChanges();
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            using (var MedDB = new MedicalEntities())
            {
                dgvPatients.DataSource = MedDB.Facilities.Attach(_facility).Patients.ToList();
            }

            dgvPatients.Columns["FacilityID"].Visible = false;
            dgvPatients.Columns["Status"].Visible = false;
            dgvPatients.Columns["PatientID"].Visible = false;
            dgvPatients.Columns["NurseID"].Visible = false;
            dgvPatients.Columns["Facility"].Visible = false;
            dgvPatients.Columns["Nurse"].Visible = false;
            dgvPatients.Columns["Notes"].Visible = false;
            dgvPatients.Columns["FacilityEvents"].Visible = false;
            dgvPatients.Columns["Contacts"].Visible = false;
            dgvPatients.Columns["Treatments"].Visible = false;
        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            PatientEditForm editDialogue = new PatientEditForm();
            editDialogue.ShowDialog();
            // Might need update function
        }

        private void dgvPatients_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            selection = (Patient)dgvPatients.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show($"Full Name: {selection.FirstName} {selection.MiddleName} {selection.LastName}");
        }
    }
}
