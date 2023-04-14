using HospitalManagement.Controller;

namespace HospitalManagement.UserControls
{
    public partial class BookAppointmentUserControl : UserControl
    {
        private readonly ManagementController _controller;
        public BookAppointmentUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {

        }

        private void BookAppointmentUserControl_Load(object sender, EventArgs e)
        {
            doctorComboBox.DataSource = _controller.GetDoctors();
            doctorComboBox.ValueMember = "Name";
        }
    }
}
