using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalVRM.Interfaces
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm userCustomerRegistration = new CustomerRegistrationForm();
            userCustomerRegistration.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm userReservationfrm = new ReservationForm();
            userReservationfrm.Show();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnVehicleCheckInOut_Click(object sender, EventArgs e)
        {
            VehiclePickupReturnForm userVehicleCheckInOutfrm = new VehiclePickupReturnForm();
            userVehicleCheckInOutfrm.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentProcessingForm frm = new PaymentProcessingForm ();
            frm.Show();
        }

        private void btnDamageInspection_Click(object sender, EventArgs e)
        {
            DamageInspectionForm frm = new DamageInspectionForm();
            frm.Show();
        }
    }
}
