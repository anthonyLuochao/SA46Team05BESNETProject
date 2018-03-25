//Author of this code: Luo Chao
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team05BESNETProject
{
    public partial class SportsFacilitiesMaintenanceForm : Form
    {
        SA46Team05BESNTETProjectEntities context = new SA46Team05BESNTETProjectEntities();
        Availability a;
        Facility f;
        Member m;
        Transaction t;
        SqlConnection con;
        SqlDataAdapter adap;
        System.Data.DataSet ds;
        SqlCommandBuilder cmb;
        SqlCommand cm;
        public SportsFacilitiesMaintenanceForm()
        {
            InitializeComponent();
        }

        private void SportsFacilitiesMaintenanceForm_Load(object sender, EventArgs e)
        {
            var today = DateTime.Now;
            var tomorrow = today.AddDays(+1);
            TomorrowDateLabel.Text = tomorrow.ToString();
            this.KeyPreview = true;
        }

        private void DisplayFacilityButton_Click(object sender, EventArgs e)
        {
            string updateFacility = "select * from Facilities";
            con = new SqlConnection();
            con.ConnectionString = @"data source=(local); initial catalog=SA46Team05B ESNTET Project;integrated security=SSPI";
            cm = new SqlCommand();
            cm.CommandText = updateFacility;
            cm.Connection = con;
            con.Open();
            adap = new SqlDataAdapter(cm);
            ds = new DataSet();
            adap.Fill(ds, "1");
            FacilitiesDataGridView .DataSource = ds.Tables[0];
        }

        private void UpdateAvailiabilityButton_Click(object sender, EventArgs e)
        {
            cmb = new SqlCommandBuilder(adap);
            adap.Update(ds, "1");
        }

        private void SportsFacilitiesMaintenanceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control ==true &&e.KeyCode ==Keys.D)
            {
                DisplayFacilityButton.PerformClick();
            }
            if(e.Control ==true&&e.KeyCode ==Keys.U)
            {
                UpdateAvailiabilityButton.PerformClick();
            }
        }
    }
}
