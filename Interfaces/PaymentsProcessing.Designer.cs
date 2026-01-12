namespace FinalVRM.Interfaces
{
    partial class PaymentProcessingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPendingPayment = new System.Windows.Forms.Label();
            this.grpPendingPayments = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPayment = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.grpPendingPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.lblPendingPayment);
            this.panel1.Controls.Add(this.grpPendingPayments);
            this.panel1.Location = new System.Drawing.Point(8, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 611);
            this.panel1.TabIndex = 34;
            // 
            // lblPendingPayment
            // 
            this.lblPendingPayment.AutoSize = true;
            this.lblPendingPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPendingPayment.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingPayment.ForeColor = System.Drawing.Color.White;
            this.lblPendingPayment.Location = new System.Drawing.Point(3, 6);
            this.lblPendingPayment.Name = "lblPendingPayment";
            this.lblPendingPayment.Size = new System.Drawing.Size(171, 21);
            this.lblPendingPayment.TabIndex = 1;
            this.lblPendingPayment.Text = "Pending Payments";
            // 
            // grpPendingPayments
            // 
            this.grpPendingPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpPendingPayments.Controls.Add(this.button2);
            this.grpPendingPayments.Controls.Add(this.button1);
            this.grpPendingPayments.Controls.Add(this.dtpPaymentDate);
            this.grpPendingPayments.Controls.Add(this.txtReferenceNumber);
            this.grpPendingPayments.Controls.Add(this.cmbPaymentMethod);
            this.grpPendingPayments.Controls.Add(this.txtAmountDue);
            this.grpPendingPayments.Controls.Add(this.label8);
            this.grpPendingPayments.Controls.Add(this.label7);
            this.grpPendingPayments.Controls.Add(this.label4);
            this.grpPendingPayments.Controls.Add(this.label3);
            this.grpPendingPayments.Controls.Add(this.txtVehicle);
            this.grpPendingPayments.Controls.Add(this.txtCustomerName);
            this.grpPendingPayments.Controls.Add(this.txtReservationID);
            this.grpPendingPayments.Controls.Add(this.label6);
            this.grpPendingPayments.Controls.Add(this.label5);
            this.grpPendingPayments.Controls.Add(this.label2);
            this.grpPendingPayments.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPendingPayments.ForeColor = System.Drawing.Color.White;
            this.grpPendingPayments.Location = new System.Drawing.Point(0, 39);
            this.grpPendingPayments.Name = "grpPendingPayments";
            this.grpPendingPayments.Size = new System.Drawing.Size(520, 572);
            this.grpPendingPayments.TabIndex = 0;
            this.grpPendingPayments.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(255, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(106)))), ((int)(((byte)(139)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(104, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(204, 424);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(128, 27);
            this.dtpPaymentDate.TabIndex = 15;
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Location = new System.Drawing.Point(204, 377);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(283, 27);
            this.txtReferenceNumber.TabIndex = 14;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "",
            "",
            "Credit Card",
            "",
            "",
            "Debit Card",
            "",
            "",
            "E-Wallet"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(204, 334);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(128, 30);
            this.cmbPaymentMethod.TabIndex = 13;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(204, 291);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(283, 27);
            this.txtAmountDue.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Payment Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Card/Reference Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payment Method:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount Due:";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(204, 96);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(283, 27);
            this.txtVehicle.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(204, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(283, 27);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(204, 22);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(283, 27);
            this.txtReservationID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reservation ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1199, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 28);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Payments";
            // 
            // txtSearchPayment
            // 
            this.txtSearchPayment.Location = new System.Drawing.Point(927, 54);
            this.txtSearchPayment.Multiline = true;
            this.txtSearchPayment.Name = "txtSearchPayment";
            this.txtSearchPayment.Size = new System.Drawing.Size(266, 26);
            this.txtSearchPayment.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentID,
            this.Customer,
            this.Vehicle,
            this.PaymentDate,
            this.AmountPayment,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(554, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 511);
            this.dataGridView1.TabIndex = 29;
            // 
            // PaymentID
            // 
            this.PaymentID.HeaderText = "Payment ID";
            this.PaymentID.MinimumWidth = 6;
            this.PaymentID.Name = "PaymentID";
            this.PaymentID.Width = 125;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.Width = 125;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Vehicle ";
            this.Vehicle.MinimumWidth = 6;
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Width = 125;
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Width = 125;
            // 
            // AmountPayment
            // 
            this.AmountPayment.HeaderText = "Amount";
            this.AmountPayment.MinimumWidth = 6;
            this.AmountPayment.Name = "AmountPayment";
            this.AmountPayment.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(577, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 511);
            this.panel2.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 508);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 48);
            this.panel3.TabIndex = 36;
            // 
            // PaymentProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 723);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchPayment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "PaymentProcessingForm";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpPendingPayments.ResumeLayout(false);
            this.grpPendingPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPendingPayment;
        private System.Windows.Forms.GroupBox grpPendingPayments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}