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
    }
}
