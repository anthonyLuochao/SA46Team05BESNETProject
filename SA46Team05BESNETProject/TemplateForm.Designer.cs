namespace SA46Team05BESNETProject
{
    partial class TemplateForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectUseCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainMemberDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainSportsFacilitiesAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSportsFacilitiesAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSportsFacilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSportsFacilitiesBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectUseCaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectUseCaseToolStripMenuItem
            // 
            this.selectUseCaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.maintainMemberDetailsToolStripMenuItem,
            this.maintainSportsFacilitiesAvailabilityToolStripMenuItem,
            this.checkSportsFacilitiesAvailabilityToolStripMenuItem,
            this.bookSportsFacilitiesToolStripMenuItem,
            this.cancelSportsFacilitiesBookingToolStripMenuItem});
            this.selectUseCaseToolStripMenuItem.Name = "selectUseCaseToolStripMenuItem";
            this.selectUseCaseToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.selectUseCaseToolStripMenuItem.Text = "Select Use Case";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // maintainMemberDetailsToolStripMenuItem
            // 
            this.maintainMemberDetailsToolStripMenuItem.Name = "maintainMemberDetailsToolStripMenuItem";
            this.maintainMemberDetailsToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.maintainMemberDetailsToolStripMenuItem.Text = "Maintain Member Details";
            // 
            // maintainSportsFacilitiesAvailabilityToolStripMenuItem
            // 
            this.maintainSportsFacilitiesAvailabilityToolStripMenuItem.Name = "maintainSportsFacilitiesAvailabilityToolStripMenuItem";
            this.maintainSportsFacilitiesAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.maintainSportsFacilitiesAvailabilityToolStripMenuItem.Text = "Maintain Sports Facilities Availability";
            // 
            // checkSportsFacilitiesAvailabilityToolStripMenuItem
            // 
            this.checkSportsFacilitiesAvailabilityToolStripMenuItem.Name = "checkSportsFacilitiesAvailabilityToolStripMenuItem";
            this.checkSportsFacilitiesAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.checkSportsFacilitiesAvailabilityToolStripMenuItem.Text = "Check Sports Facilities Availability";
            // 
            // bookSportsFacilitiesToolStripMenuItem
            // 
            this.bookSportsFacilitiesToolStripMenuItem.Name = "bookSportsFacilitiesToolStripMenuItem";
            this.bookSportsFacilitiesToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.bookSportsFacilitiesToolStripMenuItem.Text = "Book Sports Facilities";
            // 
            // cancelSportsFacilitiesBookingToolStripMenuItem
            // 
            this.cancelSportsFacilitiesBookingToolStripMenuItem.Name = "cancelSportsFacilitiesBookingToolStripMenuItem";
            this.cancelSportsFacilitiesBookingToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.cancelSportsFacilitiesBookingToolStripMenuItem.Text = "Cancel Sports Facilities Booking";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 246);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(67, 17);
            this.StatusLabel.Text = "StatusLabel";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Location = new System.Drawing.Point(453, 24);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(159, 13);
            this.logoLabel.TabIndex = 2;
            this.logoLabel.Text = "Sports Facilities Booking System";
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 268);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectUseCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainMemberDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainSportsFacilitiesAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkSportsFacilitiesAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSportsFacilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelSportsFacilitiesBookingToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Label logoLabel;
    }
}