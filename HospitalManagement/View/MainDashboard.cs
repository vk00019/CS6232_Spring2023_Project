using HospitalManagement.UserControls;

namespace HospitalManagement.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        public MenuUserControl GetMenuUserControl()
        {
            return menuUserControl;
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void registerPatientButton_Click(object sender, EventArgs e)
        {
            registerPatientUserControl.Visible = true;
            searchPatientByUserControl.Visible = false;
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            registerPatientUserControl.Visible = false;
            searchPatientByUserControl.Visible = true;
        }
    }
}