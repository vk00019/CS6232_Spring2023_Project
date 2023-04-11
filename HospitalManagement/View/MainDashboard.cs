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

    }
}