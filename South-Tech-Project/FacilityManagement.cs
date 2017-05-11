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
    public partial class FacilityManagement : Form
    {
        private Facility _facility;

        public FacilityManagement(Facility facility)
        {
            _facility = facility;
            InitializeComponent();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients patForm = new Patients(_facility);
            patForm.FormClosed += new FormClosedEventHandler((object _sender, FormClosedEventArgs _e) => this.Show());
            this.Hide();
            patForm.ShowDialog();
        }
    }
}
