using HospitalManagement.Controller;
using HospitalManagement.model;
using HospitalManagement.Model;
using HospitalManagement.View;

namespace HospitalManagement.UserControls
{
    public partial class SearchPatientVisitByUserControl : UserControl
    {
        private Visit _visit;
        private readonly ManagementController _controller;
        public SearchPatientVisitByUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _visit = new Visit();
        }

        private void DobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = false;
            lastnameTextBox.Visible = false;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void DobLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void FnLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = false;
            dobDateTimePicker.Visible = false;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = true;
            firstnametextBox.Visible = true;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.ResetText();
            firstnametextBox.Clear();
            lastnameTextBox.Clear();
            errorLabel.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            viewButton.Visible = true;
            viewButton.Enabled = false;

            List<Visit> patients;
            if (dobRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value
                };
                patients = _controller.GetVisitWithDob(patientsObject);
                CheckForPatients(patients);
            }
            else if (dobLnRadioButton.Checked)
            {
                if (!string.IsNullOrEmpty(lastnameTextBox.Text))
                {
                    var patientsObject = new PersonalDetails
                    {
                        DateOfBirth = dobDateTimePicker.Value,
                        LastName = lastnameTextBox.Text
                    };
                    patients = _controller.GetVisitWithDobAndLastname(patientsObject);
                    CheckForPatients(patients);
                }
                else
                {
                    errorLabel.Text = "Please fill Lastname field";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    viewButton.Visible = false;

                }
            }
            else
            {
                if (!(string.IsNullOrEmpty(firstnametextBox.Text) || string.IsNullOrEmpty(lastnameTextBox.Text)))
                {
                    var patientsObject = new PersonalDetails
                    {
                        FirstName = firstnametextBox.Text,
                        LastName = lastnameTextBox.Text
                    };
                    patients = _controller.GetVisitWithFirstnameAndLastname(patientsObject);
                    CheckForPatients(patients);
                }
                else
                {
                    errorLabel.Text = "Please fill both Firstname and Lastname";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    viewButton.Visible = false;

                }
            }
        }

        private void CheckForPatients(List<Visit> patients)
        {
            if (patients.Count > 0)
            {
                searchDataGridView.Visible = true;
                searchDataGridView.DataSource = patients;
                viewButton.Enabled = true;
                searchDataGridView.ClearSelection();
                searchDataGridView.Columns["nurseID"].Visible = false;
                searchDataGridView.Columns["height"].Visible = false;
                searchDataGridView.Columns["weight"].Visible = false;
                searchDataGridView.Columns["systolicBp"].Visible = false;
                searchDataGridView.Columns["diastolicBp"].Visible = false;
                searchDataGridView.Columns["bodytemperature"].Visible = false;
                searchDataGridView.Columns["pulse"].Visible = false;
                searchDataGridView.Columns["symptoms"].Visible = false;
                searchDataGridView.Columns["DoctorName"].Visible = false;
                searchDataGridView.Columns["PatientName"].Visible = false;
                searchDataGridView.Columns["NurseName"].Visible = false;
            }
            else
            {
                searchDataGridView.Visible = false;
                errorLabel.Text = "There are no visits available with details provided." + Environment.NewLine +
                                  "Register or check the details given again.";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
                viewButton.Visible = false;

            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            using var visitForm = new VisitForm();
            
            var visit = new Visit
            {
                VisitId = _visit.VisitId,
                NurseId = _visit.NurseId,
                AppointmentId = _visit.AppointmentId,
                InitialDiagnosis = _visit.InitialDiagnosis,
                Height = _visit.Height,
                Weight = _visit.Weight,
                SystolicBp = _visit.SystolicBp,
                DiastolicBp = _visit.DiastolicBp,
                BodyTemperature = _visit.BodyTemperature,
                Pulse = _visit.Pulse,
                Symptoms = _visit.Symptoms
            };
            visitForm.SetVisit(visit);
            visitForm.ShowDialog();
            if (visitForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void SearchDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                viewButton.Enabled = false;
            }
            else
            {
                viewButton.Enabled = true;
                if (searchDataGridView.SelectedRows[0] != null)
                {
                    _visit.VisitId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    _visit.AppointmentDate = DateTime.Parse(searchDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    _visit.AppointmentId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                    _visit.NurseId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                    _visit.Height = (decimal)Double.Parse(searchDataGridView.SelectedRows[0].Cells[4].Value.ToString());
                    _visit.Weight = (decimal)Double.Parse(searchDataGridView.SelectedRows[0].Cells[5].Value.ToString());
                    _visit.SystolicBp = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[6].Value.ToString());
                    _visit.DiastolicBp = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[7].Value.ToString());
                    _visit.BodyTemperature = (decimal)Double.Parse(searchDataGridView.SelectedRows[0].Cells[8].Value.ToString());
                    _visit.Pulse = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[9].Value.ToString());
                    _visit.Symptoms = searchDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                    _visit.InitialDiagnosis = searchDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                    _visit.FinalDiagnosis = searchDataGridView.SelectedRows[0].Cells[12].Value.ToString();
                }
            }
        }
    }
}
