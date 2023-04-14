using HospitalManagement.Controller;
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

namespace HospitalManagement.UserControls
{
    public partial class SearchAppointmentByUserControl : UserControl
    {
        private ManagementController _controller;
        public SearchAppointmentByUserControl()
        {
            _controller = new ManagementController();
            InitializeComponent();
        }

        private void DobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = false;
            lastnameTextBox.Visible = false;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
        }

        private void DobLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
        }

        private void FnLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = false;
            dobDateTimePicker.Visible = false;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = true;
            firstnametextBox.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            viewEditButton.Visible = true;
            viewEditButton.Enabled = false;
            List<Appointment> appointments;
            if (dobRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value
                };
                appointments = _controller.GetAppointmenttWithDob(patientsObject);
                searchDataGridView.DataSource = appointments;
                searchDataGridView.Visible = true;
                searchDataGridView.ClearSelection();
            } else if (dobLnRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value,
                    LastName = lastnameTextBox.Text
                };
                appointments = _controller.GetAppointmentWithDobAndLastname(patientsObject);
                searchDataGridView.DataSource = appointments;
                searchDataGridView.Visible = true;
                searchDataGridView.ClearSelection();

            }
            else
            {

            }
        }

        private void searchDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                viewEditButton.Enabled = false;
            }
            else
            {
                viewEditButton.Visible = true;
                viewEditButton.Enabled = true;
            }
        }
    }
}
