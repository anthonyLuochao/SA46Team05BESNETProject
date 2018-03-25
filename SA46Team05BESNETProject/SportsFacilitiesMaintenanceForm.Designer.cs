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
            this.DateLabel = new System.Windows.Forms.Label();
            this.UpdateAvailiabilityButton = new System.Windows.Forms.Button();
            this.DisplayFacilityButton = new System.Windows.Forms.Button();
            this.TomorrowDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilitiesDataGridView
            // 
            this.FacilitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacilitiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FacilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilitiesDataGridView.Location = new System.Drawing.Point(29, 80);
            this.FacilitiesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FacilitiesDataGridView.Name = "FacilitiesDataGridView";
            this.FacilitiesDataGridView.RowTemplate.Height = 28;
            this.FacilitiesDataGridView.Size = new System.Drawing.Size(487, 208);
            this.FacilitiesDataGridView.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(122, 23);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date";
            // 
            // UpdateAvailiabilityButton
            // 
            this.UpdateAvailiabilityButton.Location = new System.Drawing.Point(342, 330);
            this.UpdateAvailiabilityButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateAvailiabilityButton.Name = "UpdateAvailiabilityButton";
            this.UpdateAvailiabilityButton.Size = new System.Drawing.Size(74, 26);
            this.UpdateAvailiabilityButton.TabIndex = 9;
            this.UpdateAvailiabilityButton.Text = "&Update";
            this.UpdateAvailiabilityButton.UseVisualStyleBackColor = true;
            this.UpdateAvailiabilityButton.Click += new System.EventHandler(this.UpdateAvailiabilityButton_Click);
            // 
            // DisplayFacilityButton
            // 
            this.DisplayFacilityButton.Location = new System.Drawing.Point(125, 330);
            this.DisplayFacilityButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayFacilityButton.Name = "DisplayFacilityButton";
            this.DisplayFacilityButton.Size = new System.Drawing.Size(140, 26);
            this.DisplayFacilityButton.TabIndex = 10;
            this.DisplayFacilityButton.Text = "&Display Facilities Table";
            this.DisplayFacilityButton.UseVisualStyleBackColor = true;
            this.DisplayFacilityButton.Click += new System.EventHandler(this.DisplayFacilityButton_Click);
            // 
            // TomorrowDateLabel
            // 
            this.TomorrowDateLabel.AutoSize = true;
            this.TomorrowDateLabel.Location = new System.Drawing.Point(178, 23);
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
            this.Controls.Add(this.DisplayFacilityButton);
            this.Controls.Add(this.UpdateAvailiabilityButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.FacilitiesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SportsFacilitiesMaintenanceForm";
            this.Text = "SportsFacilitiesMaintenanceForm";
            this.Load += new System.EventHandler(this.SportsFacilitiesMaintenanceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SportsFacilitiesMaintenanceForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FacilitiesDataGridView;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button UpdateAvailiabilityButton;
        private System.Windows.Forms.Button DisplayFacilityButton;
        private System.Windows.Forms.Label TomorrowDateLabel;
    }
}