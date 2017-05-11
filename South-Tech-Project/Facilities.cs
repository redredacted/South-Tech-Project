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
        Facility selection;

        public Facilities()
        {
            InitializeComponent();
        }

        public void AddFacility(string name, string address, string zip, string phone, string city, string state)
        {
            using (var MedDB = new MedicalEntities())
            {
                Facility f = new Facility();
                f.FacilityID = Guid.NewGuid();
                f.Name = name;
                f.Address = address;
                f.Zip = zip;
                f.Phone = phone;
                f.City = city;
                f.State = state;
                MedDB.Facilities.Add(f);
                MedDB.SaveChanges();
            }
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            using (var MedDB = new MedicalEntities())
            {
                try
                {
                    if (MedDB.Facilities.Count() == 0)
                    {
                        AddFacility("Hospitality Hospital", "35101 place way", "12345", "3145442183", "Kansas City", "Kansas");
                        AddFacility("Gamble Hospital", "666 casino avenue", "77777", "2175343133", "Timbuktu", "Missouri");
                        AddFacility("Cavendish Memorial Hospital", "61253 Musa acuminata road", "73457", "5175643233", "Triploid", "California");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    throw;
                }

                MedDB.Facilities.Load();

                dgvFacilities.DataSource = MedDB.Facilities.Local;

                // filters out the Navigation properties id fields
                dgvFacilities.Columns["FacilityID"].Visible = false;
                dgvFacilities.Columns["FacilityEvents"].Visible = false;
                dgvFacilities.Columns["Patients"].Visible = false;
                dgvFacilities.Columns["Drugs"].Visible = false;
                dgvFacilities.Columns["Employees"].Visible = false;

                // enable after population
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", $"Are you sure you want to delete {selection.Name} from the facilities table?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"{selection.Name} was sucessfully deleted from the facilities table!");

                using (var MedDB = new MedicalEntities())
                {
                    MedDB.Entry(selection).State = EntityState.Deleted;
                    MedDB.SaveChanges();

                    MedDB.Facilities.Load();
                    dgvFacilities.DataSource = MedDB.Facilities.Local;
                }
            }
        }

        private void dgvFacilities_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            selection = (Facility)dgvFacilities.Rows[e.RowIndex].DataBoundItem;
            MessageBox.Show($"name: {selection.Name}");
        }
    }
}
