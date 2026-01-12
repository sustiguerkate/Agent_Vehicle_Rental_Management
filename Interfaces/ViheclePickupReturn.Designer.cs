namespace FinalVRM.Interfaces
{
    partial class VehiclePickupReturnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPendingCheck = new System.Windows.Forms.DataGridView();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropoffDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.grpCheckDetails = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDamageStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMileageIn = new System.Windows.Forms.TextBox();
            this.txtMileageOut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDropoffDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPickupDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingCheck)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.grpCheckDetails.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Vehicle Check In/Out";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1159, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(897, 46);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 32);
            this.txtSearch.TabIndex = 25;
            // 
            // dgvPendingCheck
            // 
            this.dgvPendingCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.Customer,
            this.PickupDate,
            this.DropoffDate,
            this.Status});
            this.dgvPendingCheck.Location = new System.Drawing.Point(586, 88);
            this.dgvPendingCheck.Name = "dgvPendingCheck";
            this.dgvPendingCheck.RowHeadersWidth = 51;
            this.dgvPendingCheck.RowTemplate.Height = 24;
            this.dgvPendingCheck.Size = new System.Drawing.Size(679, 650);
            this.dgvPendingCheck.TabIndex = 24;
            // 
            // ReservationID
            // 
            this.ReservationID.HeaderText = "Reservation ID";
            this.ReservationID.MinimumWidth = 6;
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.Width = 125;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.Width = 125;
            // 
            // PickupDate
            // 
            this.PickupDate.HeaderText = "Pickup Date";
            this.PickupDate.MinimumWidth = 6;
            this.PickupDate.Name = "PickupDate";
            this.PickupDate.Width = 125;
            // 
            // DropoffDate
            // 
            this.DropoffDate.HeaderText = "Drop Off Date";
            this.DropoffDate.MinimumWidth = 6;
            this.DropoffDate.Name = "DropoffDate";
            this.DropoffDate.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlRight.Controls.Add(this.grpCheckDetails);
            this.pnlRight.Location = new System.Drawing.Point(11, 88);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(560, 650);
            this.pnlRight.TabIndex = 27;
            // 
            // grpCheckDetails
            // 
            this.grpCheckDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpCheckDetails.Controls.Add(this.lblStatus);
            this.grpCheckDetails.Controls.Add(this.btnClear);
            this.grpCheckDetails.Controls.Add(this.textBox1);
            this.grpCheckDetails.Controls.Add(this.label10);
            this.grpCheckDetails.Controls.Add(this.cmbDamageStatus);
            this.grpCheckDetails.Controls.Add(this.label9);
            this.grpCheckDetails.Controls.Add(this.txtMileageIn);
            this.grpCheckDetails.Controls.Add(this.txtMileageOut);
            this.grpCheckDetails.Controls.Add(this.label8);
            this.grpCheckDetails.Controls.Add(this.btnCheckIn);
            this.grpCheckDetails.Controls.Add(this.label7);
            this.grpCheckDetails.Controls.Add(this.dtpDropoffDate);
            this.grpCheckDetails.Controls.Add(this.btnCheckOut);
            this.grpCheckDetails.Controls.Add(this.label6);
            this.grpCheckDetails.Controls.Add(this.dtpPickupDate);
            this.grpCheckDetails.Controls.Add(this.txtCustomerName);
            this.grpCheckDetails.Controls.Add(this.txtVehicle);
            this.grpCheckDetails.Controls.Add(this.label5);
            this.grpCheckDetails.Controls.Add(this.label4);
            this.grpCheckDetails.Controls.Add(this.label3);
            this.grpCheckDetails.Controls.Add(this.txtReservationID);
            this.grpCheckDetails.Controls.Add(this.label2);
            this.grpCheckDetails.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCheckDetails.ForeColor = System.Drawing.Color.White;
            this.grpCheckDetails.Location = new System.Drawing.Point(3, 44);
            this.grpCheckDetails.Name = "grpCheckDetails";
            this.grpCheckDetails.Size = new System.Drawing.Size(554, 597);
            this.grpCheckDetails.TabIndex = 21;
            this.grpCheckDetails.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(165, 285);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 22);
            this.lblStatus.TabIndex = 20;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(331, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(28, 397);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 134);
            this.textBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Damage Notes:";
            // 
            // cmbDamageStatus
            // 
            this.cmbDamageStatus.FormattingEnabled = true;
            this.cmbDamageStatus.Items.AddRange(new object[] {
            "No Damage",
            "Minor Damage",
            "Major Damage"});
            this.cmbDamageStatus.Location = new System.Drawing.Point(47, 328);
            this.cmbDamageStatus.Name = "cmbDamageStatus";
            this.cmbDamageStatus.Size = new System.Drawing.Size(376, 30);
            this.cmbDamageStatus.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Damage Status:";
            // 
            // txtMileageIn
            // 
            this.txtMileageIn.Location = new System.Drawing.Point(395, 244);
            this.txtMileageIn.Name = "txtMileageIn";
            this.txtMileageIn.Size = new System.Drawing.Size(143, 27);
            this.txtMileageIn.TabIndex = 14;
            // 
            // txtMileageOut
            // 
            this.txtMileageOut.Location = new System.Drawing.Point(162, 244);
            this.txtMileageOut.Name = "txtMileageOut";
            this.txtMileageOut.Size = new System.Drawing.Size(143, 27);
            this.txtMileageOut.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mileage In:";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Location = new System.Drawing.Point(190, 554);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(115, 29);
            this.btnCheckIn.TabIndex = 17;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mileage Out:";
            // 
            // dtpDropoffDate
            // 
            this.dtpDropoffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDropoffDate.Location = new System.Drawing.Point(162, 200);
            this.dtpDropoffDate.Name = "dtpDropoffDate";
            this.dtpDropoffDate.Size = new System.Drawing.Size(116, 27);
            this.dtpDropoffDate.TabIndex = 10;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Location = new System.Drawing.Point(40, 554);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(115, 29);
            this.btnCheckOut.TabIndex = 16;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Drop-off Date:";
            // 
            // dtpPickupDate
            // 
            this.dtpPickupDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPickupDate.Location = new System.Drawing.Point(162, 158);
            this.dtpPickupDate.Name = "dtpPickupDate";
            this.dtpPickupDate.Size = new System.Drawing.Size(116, 27);
            this.dtpPickupDate.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(162, 66);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(261, 27);
            this.txtCustomerName.TabIndex = 7;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(162, 107);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(261, 27);
            this.txtVehicle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pickup Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vehicle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name :";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(162, 22);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(261, 27);
            this.txtReservationID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reservation ID:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1277, 40);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // VehiclePickupReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 785);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPendingCheck);
            this.Controls.Add(this.pnlRight);
            this.Name = "VehiclePickupReturnForm";
            this.Text = "VihecleCheckInOut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingCheck)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.grpCheckDetails.ResumeLayout(false);
            this.grpCheckDetails.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvPendingCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropoffDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpCheckDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDamageStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMileageIn;
        private System.Windows.Forms.TextBox txtMileageOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDropoffDate;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPickupDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}