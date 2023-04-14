using HospitalManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Controller;

namespace HospitalManagement.View
{
    public partial class EditPatientForm : Form
    {
        private PersonalDetails _patient;
        private ManagementController _controller;
        public EditPatientForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        public void SetPatientDetails(PersonalDetails patientDetails)
        {
            _patient = patientDetails;
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
