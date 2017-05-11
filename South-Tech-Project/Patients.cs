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

namespace South_Tech_Project
{
    public partial class Patients : Form
    {
        // private FacilityManagement _owner;
        private ICollection<Patient> _patients;

        public Patients(Facility facility)
        {
            //_owner = owner;
            _patients = facility.Patients;
            InitializeComponent();
        }

        // add parameters
        public static void AddPatient()
        {
            using (var MedDB = new MedicalEntities())
            {
                Patient p = new Patient();
                
                MedDB.Patients.Add(p);
                MedDB.SaveChanges();
                //UpdateFacilities();
            }
        }

        public void UpdateFacilities()
        {
            using (var MedDB = new MedicalEntities())
            {
                dgvFacilities.DataSource = _patients.ToList();
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            UpdateFacilities();
        }
    }
}
