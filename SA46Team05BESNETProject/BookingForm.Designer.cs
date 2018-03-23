namespace SA46Team05BESNETProject
{
    partial class BookingForm
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
            this.MemberDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchFINButton = new System.Windows.Forms.Button();
            this.MemberFINTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.MemberFINLabel = new System.Windows.Forms.Label();
            this.MemberNameLabel = new System.Windows.Forms.Label();
            this.FacilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchFacilityIDButton = new System.Windows.Forms.Button();
            this.FacilityIDTextBox = new System.Windows.Forms.TextBox();
            this.FacilityNameTextBox = new System.Windows.Forms.TextBox();
            this.FacilityIDLabel = new System.Windows.Forms.Label();
            this.FacilityNameLabel = new System.Windows.Forms.Label();
            this.BookingDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeSlotComboBox = new System.Windows.Forms.ComboBox();
            this.TimeSlotLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.EditBookingButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.TomorrowDateLabel = new System.Windows.Forms.Label();
            this.MemberDetailsGroupBox.SuspendLayout();
            this.FacilitiesGroupBox.SuspendLayout();
            this.BookingDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberDetailsGroupBox
            // 
            this.MemberDetailsGroupBox.Controls.Add(this.SearchFINButton);
            this.MemberDetailsGroupBox.Controls.Add(this.MemberFINTextBox);
            this.MemberDetailsGroupBox.Controls.Add(this.MemberNameTextBox);
            this.MemberDetailsGroupBox.Controls.Add(this.MemberFINLabel);
            this.MemberDetailsGroupBox.Controls.Add(this.MemberNameLabel);
            this.MemberDetailsGroupBox.Location = new System.Drawing.Point(33, 18);
            this.MemberDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemberDetailsGroupBox.Name = "MemberDetailsGroupBox";
            this.MemberDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemberDetailsGroupBox.Size = new System.Drawing.Size(477, 88);
            this.MemberDetailsGroupBox.TabIndex = 0;
            this.MemberDetailsGroupBox.TabStop = false;
            this.MemberDetailsGroupBox.Text = "Member Details";
            // 
            // SearchFINButton
            // 
            this.SearchFINButton.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFINButton.Location = new System.Drawing.Point(311, 52);
            this.SearchFINButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchFINButton.Name = "SearchFINButton";
            this.SearchFINButton.Size = new System.Drawing.Size(37, 21);
            this.SearchFINButton.TabIndex = 4;
            this.SearchFINButton.Text = "...";
            this.SearchFINButton.UseVisualStyleBackColor = true;
            // 
            // MemberFINTextBox
            // 
            this.MemberFINTextBox.Location = new System.Drawing.Point(199, 52);
            this.MemberFINTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemberFINTextBox.Name = "MemberFINTextBox";
            this.MemberFINTextBox.Size = new System.Drawing.Size(103, 20);
            this.MemberFINTextBox.TabIndex = 3;
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Location = new System.Drawing.Point(199, 23);
            this.MemberNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.MemberNameTextBox.TabIndex = 2;
            // 
            // MemberFINLabel
            // 
            this.MemberFINLabel.AutoSize = true;
            this.MemberFINLabel.Location = new System.Drawing.Point(29, 56);
            this.MemberFINLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberFINLabel.Name = "MemberFINLabel";
            this.MemberFINLabel.Size = new System.Drawing.Size(96, 13);
            this.MemberFINLabel.TabIndex = 1;
            this.MemberFINLabel.Text = "Member NRIC/FIN";
            this.MemberFINLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MemberNameLabel
            // 
            this.MemberNameLabel.AutoSize = true;
            this.MemberNameLabel.Location = new System.Drawing.Point(29, 27);
            this.MemberNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberNameLabel.Name = "MemberNameLabel";
            this.MemberNameLabel.Size = new System.Drawing.Size(76, 13);
            this.MemberNameLabel.TabIndex = 0;
            this.MemberNameLabel.Text = "Member Name";
            // 
            // FacilitiesGroupBox
            // 
            this.FacilitiesGroupBox.Controls.Add(this.SearchFacilityIDButton);
            this.FacilitiesGroupBox.Controls.Add(this.FacilityIDTextBox);
            this.FacilitiesGroupBox.Controls.Add(this.FacilityNameTextBox);
            this.FacilitiesGroupBox.Controls.Add(this.FacilityIDLabel);
            this.FacilitiesGroupBox.Controls.Add(this.FacilityNameLabel);
            this.FacilitiesGroupBox.Location = new System.Drawing.Point(33, 110);
            this.FacilitiesGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilitiesGroupBox.Name = "FacilitiesGroupBox";
            this.FacilitiesGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilitiesGroupBox.Size = new System.Drawing.Size(477, 92);
            this.FacilitiesGroupBox.TabIndex = 1;
            this.FacilitiesGroupBox.TabStop = false;
            this.FacilitiesGroupBox.Text = "Facilities";
            // 
            // SearchFacilityIDButton
            // 
            this.SearchFacilityIDButton.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFacilityIDButton.Location = new System.Drawing.Point(311, 54);
            this.SearchFacilityIDButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchFacilityIDButton.Name = "SearchFacilityIDButton";
            this.SearchFacilityIDButton.Size = new System.Drawing.Size(37, 21);
            this.SearchFacilityIDButton.TabIndex = 5;
            this.SearchFacilityIDButton.Text = "...";
            this.SearchFacilityIDButton.UseVisualStyleBackColor = true;
            // 
            // FacilityIDTextBox
            // 
            this.FacilityIDTextBox.Location = new System.Drawing.Point(199, 57);
            this.FacilityIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilityIDTextBox.Name = "FacilityIDTextBox";
            this.FacilityIDTextBox.Size = new System.Drawing.Size(103, 20);
            this.FacilityIDTextBox.TabIndex = 5;
            // 
            // FacilityNameTextBox
            // 
            this.FacilityNameTextBox.Location = new System.Drawing.Point(199, 26);
            this.FacilityNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilityNameTextBox.Name = "FacilityNameTextBox";
            this.FacilityNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.FacilityNameTextBox.TabIndex = 4;
            // 
            // FacilityIDLabel
            // 
            this.FacilityIDLabel.AutoSize = true;
            this.FacilityIDLabel.Location = new System.Drawing.Point(29, 58);
            this.FacilityIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityIDLabel.Name = "FacilityIDLabel";
            this.FacilityIDLabel.Size = new System.Drawing.Size(53, 13);
            this.FacilityIDLabel.TabIndex = 3;
            this.FacilityIDLabel.Text = "Facility ID";
            // 
            // FacilityNameLabel
            // 
            this.FacilityNameLabel.AutoSize = true;
            this.FacilityNameLabel.Location = new System.Drawing.Point(29, 28);
            this.FacilityNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityNameLabel.Name = "FacilityNameLabel";
            this.FacilityNameLabel.Size = new System.Drawing.Size(70, 13);
            this.FacilityNameLabel.TabIndex = 2;
            this.FacilityNameLabel.Text = "Facility Name";
            // 
            // BookingDetailsGroupBox
            // 
            this.BookingDetailsGroupBox.Controls.Add(this.TomorrowDateLabel);
            this.BookingDetailsGroupBox.Controls.Add(this.TimeSlotComboBox);
            this.BookingDetailsGroupBox.Controls.Add(this.TimeSlotLabel);
            this.BookingDetailsGroupBox.Controls.Add(this.DateLabel);
            this.BookingDetailsGroupBox.Location = new System.Drawing.Point(33, 212);
            this.BookingDetailsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingDetailsGroupBox.Name = "BookingDetailsGroupBox";
            this.BookingDetailsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookingDetailsGroupBox.Size = new System.Drawing.Size(477, 86);
            this.BookingDetailsGroupBox.TabIndex = 2;
            this.BookingDetailsGroupBox.TabStop = false;
            this.BookingDetailsGroupBox.Text = "Booking Details";
            // 
            // TimeSlotComboBox
            // 
            this.TimeSlotComboBox.FormattingEnabled = true;
            this.TimeSlotComboBox.Items.AddRange(new object[] {
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "12:00-13:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00"});
            this.TimeSlotComboBox.Location = new System.Drawing.Point(199, 54);
            this.TimeSlotComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeSlotComboBox.Name = "TimeSlotComboBox";
            this.TimeSlotComboBox.Size = new System.Drawing.Size(130, 21);
            this.TimeSlotComboBox.TabIndex = 7;
            // 
            // TimeSlotLabel
            // 
            this.TimeSlotLabel.AutoSize = true;
            this.TimeSlotLabel.Location = new System.Drawing.Point(29, 54);
            this.TimeSlotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeSlotLabel.Name = "TimeSlotLabel";
            this.TimeSlotLabel.Size = new System.Drawing.Size(51, 13);
            this.TimeSlotLabel.TabIndex = 5;
            this.TimeSlotLabel.Text = "Time Slot";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(29, 26);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date";
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Location = new System.Drawing.Point(33, 311);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(81, 36);
            this.ClearFormButton.TabIndex = 3;
            this.ClearFormButton.Text = "Clear Form";
            this.ClearFormButton.UseVisualStyleBackColor = true;
            // 
            // EditBookingButton
            // 
            this.EditBookingButton.Location = new System.Drawing.Point(232, 311);
            this.EditBookingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditBookingButton.Name = "EditBookingButton";
            this.EditBookingButton.Size = new System.Drawing.Size(81, 36);
            this.EditBookingButton.TabIndex = 4;
            this.EditBookingButton.Text = "Edit Booking";
            this.EditBookingButton.UseVisualStyleBackColor = true;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(429, 311);
            this.BookButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(81, 36);
            this.BookButton.TabIndex = 5;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // TomorrowDateLabel
            // 
            this.TomorrowDateLabel.AutoSize = true;
            this.TomorrowDateLabel.Location = new System.Drawing.Point(196, 26);
            this.TomorrowDateLabel.Name = "TomorrowDateLabel";
            this.TomorrowDateLabel.Size = new System.Drawing.Size(87, 13);
            this.TomorrowDateLabel.TabIndex = 8;
            this.TomorrowDateLabel.Text = "Tomorrow\'s Date";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 367);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.EditBookingButton);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.BookingDetailsGroupBox);
            this.Controls.Add(this.FacilitiesGroupBox);
            this.Controls.Add(this.MemberDetailsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.MemberDetailsGroupBox.ResumeLayout(false);
            this.MemberDetailsGroupBox.PerformLayout();
            this.FacilitiesGroupBox.ResumeLayout(false);
            this.FacilitiesGroupBox.PerformLayout();
            this.BookingDetailsGroupBox.ResumeLayout(false);
            this.BookingDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MemberDetailsGroupBox;
        private System.Windows.Forms.GroupBox FacilitiesGroupBox;
        private System.Windows.Forms.GroupBox BookingDetailsGroupBox;
        private System.Windows.Forms.Label MemberFINLabel;
        private System.Windows.Forms.Label MemberNameLabel;
        private System.Windows.Forms.Label FacilityIDLabel;
        private System.Windows.Forms.Label FacilityNameLabel;
        private System.Windows.Forms.Label TimeSlotLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox MemberFINTextBox;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.TextBox FacilityIDTextBox;
        private System.Windows.Forms.TextBox FacilityNameTextBox;
        private System.Windows.Forms.ComboBox TimeSlotComboBox;
        private System.Windows.Forms.Button SearchFINButton;
        private System.Windows.Forms.Button SearchFacilityIDButton;
        private System.Windows.Forms.Button ClearFormButton;
        private System.Windows.Forms.Button EditBookingButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Label TomorrowDateLabel;
    }
}