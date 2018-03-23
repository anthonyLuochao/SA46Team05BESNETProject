namespace SA46Team05BESNETProject
{
    partial class QueryForm
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
            this.SearchByGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.TimeSlotLabel = new System.Windows.Forms.Label();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.FacilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSlotComboBox = new System.Windows.Forms.ComboBox();
            this.BookButton = new System.Windows.Forms.Button();
            this.SearchByGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByGroupBox
            // 
            this.SearchByGroupBox.Controls.Add(this.TimeSlotComboBox);
            this.SearchByGroupBox.Controls.Add(this.SearchButton);
            this.SearchByGroupBox.Controls.Add(this.ActivityComboBox);
            this.SearchByGroupBox.Controls.Add(this.TimeSlotLabel);
            this.SearchByGroupBox.Controls.Add(this.ActivityLabel);
            this.SearchByGroupBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByGroupBox.Location = new System.Drawing.Point(59, 24);
            this.SearchByGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchByGroupBox.Name = "SearchByGroupBox";
            this.SearchByGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchByGroupBox.Size = new System.Drawing.Size(407, 127);
            this.SearchByGroupBox.TabIndex = 0;
            this.SearchByGroupBox.TabStop = false;
            this.SearchByGroupBox.Text = "Search By";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(135, 85);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(81, 28);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Location = new System.Drawing.Point(135, 22);
            this.ActivityComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(82, 27);
            this.ActivityComboBox.TabIndex = 2;
            // 
            // TimeSlotLabel
            // 
            this.TimeSlotLabel.AutoSize = true;
            this.TimeSlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSlotLabel.Location = new System.Drawing.Point(63, 58);
            this.TimeSlotLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeSlotLabel.Name = "TimeSlotLabel";
            this.TimeSlotLabel.Size = new System.Drawing.Size(51, 13);
            this.TimeSlotLabel.TabIndex = 1;
            this.TimeSlotLabel.Text = "Time Slot";
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityLabel.Location = new System.Drawing.Point(64, 28);
            this.ActivityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(41, 13);
            this.ActivityLabel.TabIndex = 0;
            this.ActivityLabel.Text = "Activity";
            // 
            // FacilitiesDataGridView
            // 
            this.FacilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activity,
            this.FacilityID,
            this.TimeSlot});
            this.FacilitiesDataGridView.Location = new System.Drawing.Point(59, 164);
            this.FacilitiesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacilitiesDataGridView.Name = "FacilitiesDataGridView";
            this.FacilitiesDataGridView.RowTemplate.Height = 28;
            this.FacilitiesDataGridView.Size = new System.Drawing.Size(407, 164);
            this.FacilitiesDataGridView.TabIndex = 1;
            // 
            // Activity
            // 
            this.Activity.HeaderText = "Activity";
            this.Activity.Name = "Activity";
            // 
            // FacilityID
            // 
            this.FacilityID.HeaderText = "Facility ID";
            this.FacilityID.Name = "FacilityID";
            this.FacilityID.Width = 150;
            // 
            // TimeSlot
            // 
            this.TimeSlot.HeaderText = "TimeSlot";
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.Width = 150;
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
            this.TimeSlotComboBox.Location = new System.Drawing.Point(135, 55);
            this.TimeSlotComboBox.Name = "TimeSlotComboBox";
            this.TimeSlotComboBox.Size = new System.Drawing.Size(82, 27);
            this.TimeSlotComboBox.TabIndex = 5;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(471, 305);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(75, 23);
            this.BookButton.TabIndex = 2;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 355);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.FacilitiesDataGridView);
            this.Controls.Add(this.SearchByGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.SearchByGroupBox.ResumeLayout(false);
            this.SearchByGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchByGroupBox;
        private System.Windows.Forms.DataGridView FacilitiesDataGridView;
        private System.Windows.Forms.Label TimeSlotLabel;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
        private System.Windows.Forms.ComboBox TimeSlotComboBox;
        private System.Windows.Forms.Button BookButton;
    }
}