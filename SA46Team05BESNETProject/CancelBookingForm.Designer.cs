namespace SA46Team05BESNETProject
{
    partial class CancelBookingForm
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
            this.MemberFINLabel = new System.Windows.Forms.Label();
            this.BookedDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CancelBookingButton = new System.Windows.Forms.Button();
            this.MemberFINTextBox = new System.Windows.Forms.TextBox();
            this.SearchMemberFINButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberFINLabel
            // 
            this.MemberFINLabel.AutoSize = true;
            this.MemberFINLabel.Location = new System.Drawing.Point(62, 27);
            this.MemberFINLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberFINLabel.Name = "MemberFINLabel";
            this.MemberFINLabel.Size = new System.Drawing.Size(99, 13);
            this.MemberFINLabel.TabIndex = 1;
            this.MemberFINLabel.Text = "Member  NRIC/FIN";
            // 
            // BookedDataGridView
            // 
            this.BookedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.Activity,
            this.FacilityID,
            this.Date,
            this.TimeSlot});
            this.BookedDataGridView.Location = new System.Drawing.Point(55, 62);
            this.BookedDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookedDataGridView.Name = "BookedDataGridView";
            this.BookedDataGridView.RowTemplate.Height = 28;
            this.BookedDataGridView.Size = new System.Drawing.Size(354, 138);
            this.BookedDataGridView.TabIndex = 2;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "Transaction ID";
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.Width = 150;
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
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // TimeSlot
            // 
            this.TimeSlot.HeaderText = "Time Slot";
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.Width = 150;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(55, 224);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // CancelBookingButton
            // 
            this.CancelBookingButton.Location = new System.Drawing.Point(309, 224);
            this.CancelBookingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelBookingButton.Name = "CancelBookingButton";
            this.CancelBookingButton.Size = new System.Drawing.Size(101, 32);
            this.CancelBookingButton.TabIndex = 4;
            this.CancelBookingButton.Text = "Cancel Booking";
            this.CancelBookingButton.UseVisualStyleBackColor = true;
            // 
            // MemberFINTextBox
            // 
            this.MemberFINTextBox.Location = new System.Drawing.Point(165, 24);
            this.MemberFINTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MemberFINTextBox.Name = "MemberFINTextBox";
            this.MemberFINTextBox.Size = new System.Drawing.Size(146, 20);
            this.MemberFINTextBox.TabIndex = 5;
            // 
            // SearchMemberFINButton
            // 
            this.SearchMemberFINButton.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMemberFINButton.Location = new System.Drawing.Point(327, 24);
            this.SearchMemberFINButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchMemberFINButton.Name = "SearchMemberFINButton";
            this.SearchMemberFINButton.Size = new System.Drawing.Size(37, 21);
            this.SearchMemberFINButton.TabIndex = 6;
            this.SearchMemberFINButton.Text = "...";
            this.SearchMemberFINButton.UseVisualStyleBackColor = true;
            // 
            // CancelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.SearchMemberFINButton);
            this.Controls.Add(this.MemberFINTextBox);
            this.Controls.Add(this.CancelBookingButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BookedDataGridView);
            this.Controls.Add(this.MemberFINLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CancelBookingForm";
            this.Text = "CancelBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.BookedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MemberFINLabel;
        private System.Windows.Forms.DataGridView BookedDataGridView;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CancelBookingButton;
        private System.Windows.Forms.TextBox MemberFINTextBox;
        private System.Windows.Forms.Button SearchMemberFINButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
    }
}