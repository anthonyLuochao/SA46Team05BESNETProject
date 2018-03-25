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
            this.components = new System.ComponentModel.Container();
            this.SearchByGroupBox = new System.Windows.Forms.GroupBox();
            this.displayTableButton = new System.Windows.Forms.Button();
            this.TimeSlotComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.TimeSlotLabel = new System.Windows.Forms.Label();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.FacilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            this.sA46Team05B_ESNTET_ProjectDataSet = new SA46Team05BESNETProject.SA46Team05B_ESNTET_ProjectDataSet();
            this.availabilitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availabilitiesTableAdapter = new SA46Team05BESNETProject.SA46Team05B_ESNTET_ProjectDataSetTableAdapters.AvailabilitiesTableAdapter();
            this.SearchByGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA46Team05B_ESNTET_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByGroupBox
            // 
            this.SearchByGroupBox.Controls.Add(this.displayTableButton);
            this.SearchByGroupBox.Controls.Add(this.TimeSlotComboBox);
            this.SearchByGroupBox.Controls.Add(this.SearchButton);
            this.SearchByGroupBox.Controls.Add(this.ActivityComboBox);
            this.SearchByGroupBox.Controls.Add(this.TimeSlotLabel);
            this.SearchByGroupBox.Controls.Add(this.ActivityLabel);
            this.SearchByGroupBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByGroupBox.Location = new System.Drawing.Point(59, 24);
            this.SearchByGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByGroupBox.Name = "SearchByGroupBox";
            this.SearchByGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SearchByGroupBox.Size = new System.Drawing.Size(407, 127);
            this.SearchByGroupBox.TabIndex = 0;
            this.SearchByGroupBox.TabStop = false;
            this.SearchByGroupBox.Text = "Search By";
            this.SearchByGroupBox.Enter += new System.EventHandler(this.SearchByGroupBox_Enter);
            // 
            // displayTableButton
            // 
            this.displayTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTableButton.Location = new System.Drawing.Point(222, 89);
            this.displayTableButton.Name = "displayTableButton";
            this.displayTableButton.Size = new System.Drawing.Size(96, 23);
            this.displayTableButton.TabIndex = 6;
            this.displayTableButton.Text = "&DisplayTable";
            this.displayTableButton.UseVisualStyleBackColor = true;
            this.displayTableButton.Click += new System.EventHandler(this.displayTableButton_Click);
            // 
            // TimeSlotComboBox
            // 
            this.TimeSlotComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeSlotComboBox.FormattingEnabled = true;
            this.TimeSlotComboBox.Items.AddRange(new object[] {
            "",
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
            this.TimeSlotComboBox.Size = new System.Drawing.Size(146, 27);
            this.TimeSlotComboBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(135, 85);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(81, 28);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "&Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Items.AddRange(new object[] {
            "",
            "Tennis",
            "Table Tennis",
            "Badminton",
            "BasketBall"});
            this.ActivityComboBox.Location = new System.Drawing.Point(135, 22);
            this.ActivityComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(146, 27);
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
            this.FacilitiesDataGridView.AllowDrop = true;
            this.FacilitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacilitiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FacilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacilitiesDataGridView.Location = new System.Drawing.Point(59, 164);
            this.FacilitiesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FacilitiesDataGridView.Name = "FacilitiesDataGridView";
            this.FacilitiesDataGridView.RowTemplate.Height = 28;
            this.FacilitiesDataGridView.Size = new System.Drawing.Size(407, 164);
            this.FacilitiesDataGridView.TabIndex = 1;
            this.FacilitiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacilitiesDataGridView_CellContentClick);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(224, 333);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // sA46Team05B_ESNTET_ProjectDataSet
            // 
            this.sA46Team05B_ESNTET_ProjectDataSet.DataSetName = "SA46Team05B_ESNTET_ProjectDataSet";
            this.sA46Team05B_ESNTET_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availabilitiesBindingSource
            // 
            this.availabilitiesBindingSource.DataMember = "Availabilities";
            this.availabilitiesBindingSource.DataSource = this.sA46Team05B_ESNTET_ProjectDataSet;
            // 
            // availabilitiesTableAdapter
            // 
            this.availabilitiesTableAdapter.ClearBeforeFill = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 408);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.FacilitiesDataGridView);
            this.Controls.Add(this.SearchByGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QueryForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryForm_KeyDown);
            this.SearchByGroupBox.ResumeLayout(false);
            this.SearchByGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacilitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sA46Team05B_ESNTET_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchByGroupBox;
        private System.Windows.Forms.DataGridView FacilitiesDataGridView;
        private System.Windows.Forms.Label TimeSlotLabel;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox TimeSlotComboBox;
        private SA46Team05B_ESNTET_ProjectDataSet sA46Team05B_ESNTET_ProjectDataSet;
        private System.Windows.Forms.BindingSource availabilitiesBindingSource;
        private SA46Team05B_ESNTET_ProjectDataSetTableAdapters.AvailabilitiesTableAdapter availabilitiesTableAdapter;
        private System.Windows.Forms.Button displayTableButton;
    }
}