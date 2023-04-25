using HospitalManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Model;

namespace HospitalManagement.UserControls
{
    public partial class StartPatientVisitUserControl : UserControl
    {
        private Visit _visit;
        public StartPatientVisitUserControl()
        {
            InitializeComponent();
            _visit = new Visit();
        }

        public void SetVisit(Visit visit)
        {
            _visit = visit;
        }

        private void routineCheckupButton_Click(object sender, EventArgs e)
        {
            using var routine = new RoutineCheckup();
            routine.ShowDialog();
        }
    }
}
