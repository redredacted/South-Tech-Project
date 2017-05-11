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
    public partial class FacilityEdit : Form
    {
        private Facility _facility;
        private bool _newFacility;

        public FacilityEdit(Facility facility)
        {
            _facility = facility;
            _newFacility = false;
            InitializeComponent();
        }

        public FacilityEdit()
        {
            _newFacility = true;
            InitializeComponent();
        }

        private void FacilityEdit_Load(object sender, EventArgs e)
        {
            if (!_newFacility)
            {
                this.txtAddress.Text = _facility.Address;
                this.txtCity.Text = _facility.City;
                this.txtName.Text = _facility.Name;
                this.txtPhone.Text = _facility.Phone;
                this.txtZip.Text = _facility.Zip;
                this.lbStates.SelectedItem = _facility.State;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (_newFacility)
            {
                Facilities.AddFacility(this.txtName.Text, this.txtAddress.Text, this.txtZip.Text, this.txtPhone.Text, this.txtCity.Text, this.lbStates.Text);
            }
            else
            {
                using (var MedDB = new MedicalEntities())
                {
                    var entry = MedDB.Facilities.Find(_facility.FacilityID);

                    _facility.Address = this.txtAddress.Text;
                    _facility.City = this.txtCity.Text;
                    _facility.Name = this.txtName.Text;
                    _facility.Phone = this.txtPhone.Text;
                    _facility.Zip = this.txtZip.Text;
                    _facility.State = this.lbStates.Text;

                    MedDB.Entry(entry).CurrentValues.SetValues(_facility);
                    MedDB.SaveChanges();
                }
            }

            this.Close();
        }
    }
}
