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
    public partial class Patients : Form
    {
        private Facility _facility;

        public Patients(Facility facility)
        {
            _facility = facility;
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

        private void Patients_Load(object sender, EventArgs e)
        {
            using (var MedDB = new MedicalEntities())
            {
                dgvPatients.DataSource = MedDB.Facilities.Attach(_facility).Patients.ToList();
            }
        }
    }
}
