namespace FinalVRM.Interfaces
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DropOfDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPendingReservation = new System.Windows.Forms.GroupBox();
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAssignReservation = new System.Windows.Forms.Button();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDropOffDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpPickupDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.grpPendingReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.Location = new System.Drawing.Point(1154, 50);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(101, 30);
            this.btnSearchReservation.TabIndex = 44;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = true;
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Location = new System.Drawing.Point(879, 50);
            this.txtSearchReservation.Multiline = true;
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(269, 30);
            this.txtSearchReservation.TabIndex = 43;
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.CustomerName,
            this.Vehicle,
            this.PickUpDate,
            this.DropOfDate,
            this.Status});
            this.dgvReservation.Location = new System.Drawing.Point(473, 86);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(805, 604);
            this.dgvReservation.TabIndex = 41;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            // 
            // ReservationID
            // 
            this.ReservationID.HeaderText = "ReservationID";
            this.ReservationID.MinimumWidth = 6;
            this.ReservationID.Name = "ReservationID";
            this.ReservationID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Vehicle Name";
            this.Vehicle.MinimumWidth = 6;
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Width = 125;
            // 
            // PickUpDate
            // 
            this.PickUpDate.HeaderText = "Pick Up Date";
            this.PickUpDate.MinimumWidth = 6;
            this.PickUpDate.Name = "PickUpDate";
            this.PickUpDate.Width = 125;
            // 
            // DropOfDate
            // 
            this.DropOfDate.HeaderText = "Drop Of Date";
            this.DropOfDate.MinimumWidth = 6;
            this.DropOfDate.Name = "DropOfDate";
            this.DropOfDate.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Reservation ";
            // 
            // grpPendingReservation
            // 
            this.grpPendingReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpPendingReservation.Controls.Add(this.picVehicle);
            this.grpPendingReservation.Controls.Add(this.btnCancel);
            this.grpPendingReservation.Controls.Add(this.btnAssignReservation);
            this.grpPendingReservation.Controls.Add(this.btnSaveReservation);
            this.grpPendingReservation.Controls.Add(this.lblTotalCost);
            this.grpPendingReservation.Controls.Add(this.label11);
            this.grpPendingReservation.Controls.Add(this.dateTimePicker2);
            this.grpPendingReservation.Controls.Add(this.dtpDropOffDate);
            this.grpPendingReservation.Controls.Add(this.label10);
            this.grpPendingReservation.Controls.Add(this.dateTimePicker1);
            this.grpPendingReservation.Controls.Add(this.dtpPickupDate);
            this.grpPendingReservation.Controls.Add(this.label9);
            this.grpPendingReservation.Controls.Add(this.txtLicensePlate);
            this.grpPendingReservation.Controls.Add(this.label8);
            this.grpPendingReservation.Controls.Add(this.cmbColor);
            this.grpPendingReservation.Controls.Add(this.label7);
            this.grpPendingReservation.Controls.Add(this.cmbYear);
            this.grpPendingReservation.Controls.Add(this.label6);
            this.grpPendingReservation.Controls.Add(this.lblVehicle);
            this.grpPendingReservation.Controls.Add(this.cmbVehicle);
            this.grpPendingReservation.Controls.Add(this.lblEmail);
            this.grpPendingReservation.Controls.Add(this.lblPhone);
            this.grpPendingReservation.Controls.Add(this.lblCustomerName);
            this.grpPendingReservation.Controls.Add(this.lblReservationID);
            this.grpPendingReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPendingReservation.ForeColor = System.Drawing.Color.White;
            this.grpPendingReservation.Location = new System.Drawing.Point(3, 86);
            this.grpPendingReservation.Name = "grpPendingReservation";
            this.grpPendingReservation.Size = new System.Drawing.Size(460, 714);
            this.grpPendingReservation.TabIndex = 42;
            this.grpPendingReservation.TabStop = false;
            this.grpPendingReservation.Text = "Reservation Details";
            // 
            // picVehicle
            // 
            this.picVehicle.Image = ((System.Drawing.Image)(resources.GetObject("picVehicle.Image")));
            this.picVehicle.InitialImage = ((System.Drawing.Image)(resources.GetObject("picVehicle.InitialImage")));
            this.picVehicle.Location = new System.Drawing.Point(152, 152);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(287, 137);
            this.picVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVehicle.TabIndex = 37;
            this.picVehicle.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(325, 638);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 37);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAssignReservation
            // 
            this.btnAssignReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.btnAssignReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignReservation.Location = new System.Drawing.Point(172, 638);
            this.btnAssignReservation.Name = "btnAssignReservation";
            this.btnAssignReservation.Size = new System.Drawing.Size(120, 37);
            this.btnAssignReservation.TabIndex = 35;
            this.btnAssignReservation.Text = "Reservation ";
            this.btnAssignReservation.UseVisualStyleBackColor = false;
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.btnSaveReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReservation.ForeColor = System.Drawing.Color.White;
            this.btnSaveReservation.Location = new System.Drawing.Point(18, 638);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(120, 37);
            this.btnSaveReservation.TabIndex = 34;
            this.btnSaveReservation.Text = "Save";
            this.btnSaveReservation.UseVisualStyleBackColor = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(337, 615);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 20);
            this.lblTotalCost.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Total Cost:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(311, 571);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(128, 27);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // dtpDropOffDate
            // 
            this.dtpDropOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDropOffDate.Location = new System.Drawing.Point(158, 571);
            this.dtpDropOffDate.Name = "dtpDropOffDate";
            this.dtpDropOffDate.Size = new System.Drawing.Size(124, 27);
            this.dtpDropOffDate.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Drop Off Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 528);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 27);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // dtpPickupDate
            // 
            this.dtpPickupDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickupDate.Location = new System.Drawing.Point(158, 528);
            this.dtpPickupDate.Name = "dtpPickupDate";
            this.dtpPickupDate.Size = new System.Drawing.Size(124, 27);
            this.dtpPickupDate.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pickup Time:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(158, 449);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(281, 27);
            this.txtLicensePlate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "License Plate:";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(158, 407);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(281, 28);
            this.cmbColor.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Color:";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(158, 357);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(281, 28);
            this.cmbYear.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(82, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Year:";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.ForeColor = System.Drawing.Color.White;
            this.lblVehicle.Location = new System.Drawing.Point(58, 308);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(77, 20);
            this.lblVehicle.TabIndex = 19;
            this.lblVehicle.Text = "Vehicle:";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(158, 308);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(281, 28);
            this.cmbVehicle.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(18, 129);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(90, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(18, 71);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(144, 20);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.ForeColor = System.Drawing.Color.White;
            this.lblReservationID.Location = new System.Drawing.Point(18, 40);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(144, 20);
            this.lblReservationID.TabIndex = 0;
            this.lblReservationID.Text = "Reseravation ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 44);
            this.panel1.TabIndex = 45;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 720);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 801);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchReservation);
            this.Controls.Add(this.txtSearchReservation);
            this.Controls.Add(this.dgvReservation);
            this.Controls.Add(this.grpPendingReservation);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ReservationForm";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.grpPendingReservation.ResumeLayout(false);
            this.grpPendingReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickUpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DropOfDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPendingReservation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAssignReservation;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtpDropOffDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpPickupDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picVehicle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}