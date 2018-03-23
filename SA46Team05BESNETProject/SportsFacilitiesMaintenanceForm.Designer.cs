namespace SA46Team05BESNETProject
{
    partial class SportsFacilitiesMaintenanceForm
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
            this.FacilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.FacilityIDLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.FacilityIDComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateAvailiabilityButton = new System.Windows.Forms.Button();
            this.CheckAvailabilityButton = new System.Windows.Forms.Button();
            this.TomorrowDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilitiesDataGridView
            // 
            this.FacilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeSlot,
            this.Availability});
            this.FacilitiesDataGridView.Location = new System.Drawing.Point(125, 118);
            this.FacilitiesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilitiesDataGridView.Name = "FacilitiesDataGridView";
            this.FacilitiesDataGridView.RowTemplate.Height = 28;
            this.FacilitiesDataGridView.Size = new System.Drawing.Size(291, 110);
            this.FacilitiesDataGridView.TabIndex = 0;
            // 
            // TimeSlot
            // 
            this.TimeSlot.HeaderText = "Time Slot";
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.Width = 150;
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLabel.Location = new System.Drawing.Point(122, 20);
            this.ActivityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(41, 13);
            this.ActivityLabel.TabIndex = 1;
            this.ActivityLabel.Text = "Activity";
            // 
            // FacilityIDLabel
            // 
            this.FacilityIDLabel.AutoSize = true;
            this.FacilityIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityIDLabel.Location = new System.Drawing.Point(122, 49);
            this.FacilityIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacilityIDLabel.Name = "FacilityIDLabel";
            this.FacilityIDLabel.Size = new System.Drawing.Size(53, 13);
            this.FacilityIDLabel.TabIndex = 2;
            this.FacilityIDLabel.Text = "Facility ID";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(122, 77);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date";
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Items.AddRange(new object[] {
            "Tennis",
            "Badminton",
            "Table Tennis",
            "Basketball"});
            this.ActivityComboBox.Location = new System.Drawing.Point(211, 20);
            this.ActivityComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(82, 21);
            this.ActivityComboBox.TabIndex = 6;
            // 
            // FacilityIDComboBox
            // 
            this.FacilityIDComboBox.FormattingEnabled = true;
            this.FacilityIDComboBox.Items.AddRange(new object[] {
            "T-1",
            "T-2",
            "T-3",
            "T-4",
            "B-1",
            "B-2",
            "B-3",
            "B-4",
            "TT-1",
            "TT-2",
            "TT-3",
            "TT-4",
            "BB-1",
            "BB-2",
            "BB-3",
            "BB-4"});
            this.FacilityIDComboBox.Location = new System.Drawing.Point(211, 49);
            this.FacilityIDComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilityIDComboBox.Name = "FacilityIDComboBox";
            this.FacilityIDComboBox.Size = new System.Drawing.Size(82, 21);
            this.FacilityIDComboBox.TabIndex = 7;
            // 
            // UpdateAvailiabilityButton
            // 
            this.UpdateAvailiabilityButton.Location = new System.Drawing.Point(337, 242);
            this.UpdateAvailiabilityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateAvailiabilityButton.Name = "UpdateAvailiabilityButton";
            this.UpdateAvailiabilityButton.Size = new System.Drawing.Size(74, 26);
            this.UpdateAvailiabilityButton.TabIndex = 9;
            this.UpdateAvailiabilityButton.Text = "Update";
            this.UpdateAvailiabilityButton.UseVisualStyleBackColor = true;
            // 
            // CheckAvailabilityButton
            // 
            this.CheckAvailabilityButton.Location = new System.Drawing.Point(125, 242);
            this.CheckAvailabilityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckAvailabilityButton.Name = "CheckAvailabilityButton";
            this.CheckAvailabilityButton.Size = new System.Drawing.Size(140, 26);
            this.CheckAvailabilityButton.TabIndex = 10;
            this.CheckAvailabilityButton.Text = "Check Availability";
            this.CheckAvailabilityButton.UseVisualStyleBackColor = true;
            // 
            // TomorrowDateLabel
            // 
            this.TomorrowDateLabel.AutoSize = true;
            this.TomorrowDateLabel.Location = new System.Drawing.Point(208, 77);
            this.TomorrowDateLabel.Name = "TomorrowDateLabel";
            this.TomorrowDateLabel.Size = new System.Drawing.Size(87, 13);
            this.TomorrowDateLabel.TabIndex = 11;
            this.TomorrowDateLabel.Text = "Tomorrow\'s Date";
            // 
            // SportsFacilitiesMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 376);
            this.Controls.Add(this.TomorrowDateLabel);
            this.Controls.Add(this.CheckAvailabilityButton);
            this.Controls.Add(this.UpdateAvailiabilityButton);
            this.Controls.Add(this.FacilityIDComboBox);
            this.Controls.Add(this.ActivityComboBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FacilityIDLabel);
            this.Controls.Add(this.ActivityLabel);
            this.Controls.Add(this.FacilitiesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SportsFacilitiesMaintenanceForm";
            this.Text = "SportsFacilitiesMaintenanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FacilitiesDataGridView;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Label FacilityIDLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.ComboBox FacilityIDComboBox;
        private System.Windows.Forms.Button UpdateAvailiabilityButton;
        private System.Windows.Forms.Button CheckAvailabilityButton;
        private System.Windows.Forms.Label TomorrowDateLabel;
    }
}