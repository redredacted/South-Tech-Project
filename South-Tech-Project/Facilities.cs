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
    public partial class Facilities : Form
    {
        public Facilities()
        {
            InitializeComponent();
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            using (var MedDB = new MedicalEntities())
            {
                try
                {
                    if (MedDB.Facilities.Count() == 0)
                    {
                        Facility f = new Facility();
                        f.FacilityID = Guid.NewGuid();
                        f.Name = "New Brunswick";
                        f.Address = "3601 park lawn drive";
                        f.Zip = "63125";
                        f.Phone = "3145442183";
                        f.City = "St. Louis";
                        f.State = "Missouri";
                        MedDB.Facilities.Add(f);
                        MedDB.SaveChanges();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    throw;
                }

                MedDB.Facilities.Load();

                dgvFacilities.DataSource = MedDB.Facilities.Local;
            }
        }
    }
}
