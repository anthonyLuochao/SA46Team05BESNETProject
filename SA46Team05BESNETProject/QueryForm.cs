//Author of this code:Luo Chao
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
    public partial class QueryForm : Form
    {
        //private void showInfo(Movy m)
        //{
        //    MovieTitleTextBox.Text = m.MovieTitle;
        //    GenreTextBox.Text = m.MovieType;
        //    RentalCostTextBox.Text = m.RentalPrice.ToString();
        //    VideoCodeText.Text = m.VideoCode.ToString();
        //}

        public QueryForm()
        {
            InitializeComponent();
           
            //Facility f1 = context.Facilities.First(x => x.FacilityID == "T-1");
            //Facility f2 = context.Facilities.First(x => x.FacilityID == "TT-1");
            //Facility f3 = context.Facilities.First(x => x.FacilityID == "B-1");
            //Facility f4 = context.Facilities.First(x => x.FacilityID == "BB-1");
            

            //ActivityComboBox.Items.AddRange(new object[] { f1.Activity, f2.Activity, f3.Activity, f4.Activity });
           // TimeSlotComboBox.Items.AddRange(new object[] { "Slot1,Slot2,Slot3,Slot4,Slot5,Slot6,Slot7,Slot8" });

        }
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
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string onlyTennis = " select *  from Availabilities where FacilityID = 'T-1'or FacilityID = 'T-2'or FacilityID = 'T-3'or FacilityID = 'T-4'";
                string onlyTableTennis = " select *  from Availabilities where FacilityID = 'TT-1'or FacilityID = 'TT-2'or FacilityID = 'TT-3'or FacilityID = 'TT-4'";
                string onlyBadminton = " select *  from Availabilities where FacilityID = 'B-1'or FacilityID = 'B-2'or FacilityID = 'B-3'or FacilityID = 'B-4'";
                string onlyBasketBall = " select *  from Availabilities where FacilityID = 'BB-1'or FacilityID = 'BB-2'or FacilityID = 'BB-3'or FacilityID = 'BB-4'";
                string tennisSlot1 = " select FacilityID,Slot1 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot2 = " select FacilityID,Slot2 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot3 = " select FacilityID,Slot3 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot4 = " select FacilityID,Slot4 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot5 = " select FacilityID,Slot5 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot6 = " select FacilityID,Slot6 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot7 = " select FacilityID,Slot7 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tennisSlot8 = " select FacilityID,Slot8 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' ";
                string tableTennisSlot1 = " select FacilityID,Slot1 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot2 = " select FacilityID,Slot2 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot3 = " select FacilityID,Slot3 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot4 = " select FacilityID,Slot4 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot5 = " select FacilityID,Slot5 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot6 = " select FacilityID,Slot6 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot7 = " select FacilityID,Slot7 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string tableTennisSlot8 = " select FacilityID,Slot8 from Availabilities where FacilityID='TT-1' or FacilityID = 'TT-2' or FacilityID = 'TT-3'  or FacilityID = 'TT-4'";
                string badmintonSlot1 = " select FacilityID,Slot1 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot2 = " select FacilityID,Slot2 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot3 = " select FacilityID,Slot3 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot4 = " select FacilityID,Slot4 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot5 = " select FacilityID,Slot5 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot6 = " select FacilityID,Slot6 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot7 = " select FacilityID,Slot7 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string badmintonSlot8 = " select FacilityID,Slot8 from Availabilities where FacilityID='B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string basketBallSlot1 = " select FacilityID,Slot1 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot2 = " select FacilityID,Slot2 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot3 = " select FacilityID,Slot3 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot4 = " select FacilityID,Slot4 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot5 = " select FacilityID,Slot5 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot6 = " select FacilityID,Slot6 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot7 = " select FacilityID,Slot7 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";
                string basketBallSlot8 = " select FacilityID,Slot8 from Availabilities where FacilityID='BB-1' or FacilityID = 'BB-2' or FacilityID = 'BB-3'  or FacilityID = 'BB-4'";


                string onlySlot1 = " select FacilityID,Slot1 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot2 = " select FacilityID,Slot2 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                                "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                                "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot3 = " select FacilityID,Slot3 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot4 = " select FacilityID,Slot4 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot5 = " select FacilityID,Slot5 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot6 = " select FacilityID,Slot6 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot7 = " select FacilityID,Slot7 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                string onlySlot8 = " select FacilityID,Slot8 from Availabilities where FacilityID ='T-1'or FacilityID ='T-2'or FacilityID ='T-3'or FacilityID ='T-4' or " +
                    "FacilityID = 'BB-1'  or FacilityID = 'BB-2'  or FacilityID = 'BB-3'  or FacilityID = 'BB-4' or FacilityID = 'TT-1'  or FacilityID = 'TT-2'" +
                    "  or FacilityID = 'TT-3'  or FacilityID = 'TT-4' or FacilityID = 'B-1' or FacilityID = 'B-2' or FacilityID = 'B-3'  or FacilityID = 'B-4'";
                con = new SqlConnection();
                con.ConnectionString = @"data source=(local); initial catalog=SA46Team05B ESNTET Project;integrated security=SSPI";
                cm = new SqlCommand();
                if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "")
                {
                    cm.CommandText = onlyTennis;
                }


                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "09:00-10:00")
                {
                    cm.CommandText = onlySlot1;
                }


                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "")
                {
                    cm.CommandText = onlyTableTennis;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "")
                {
                    cm.CommandText = onlyBadminton;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "")
                {
                    cm.CommandText = onlyBasketBall;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "09:00-10:00")
                {
                    cm.CommandText = tennisSlot1;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "10:00-11:00")
                {
                    cm.CommandText = tennisSlot2;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "11:00-12:00")
                {
                    cm.CommandText = tennisSlot3;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "12:00-13:00")
                {
                    cm.CommandText = tennisSlot4;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "13:00-14:00")
                {
                    cm.CommandText = tennisSlot5;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "14:00-15:00")
                {
                    cm.CommandText = tennisSlot6;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "15:00-16:00")
                {
                    cm.CommandText = tennisSlot7;
                }
                else if (ActivityComboBox.Text.Trim() == "Tennis" && TimeSlotComboBox.Text.Trim() == "16:00-17:00")
                {
                    cm.CommandText = tennisSlot8;
                }

                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "09:00-10:00")
                {
                    cm.CommandText = tableTennisSlot1;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "10:00-11:00")
                {
                    cm.CommandText = tableTennisSlot2;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "11:00-12:00")
                {
                    cm.CommandText = tableTennisSlot3;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "12:00-13:00")
                {
                    cm.CommandText = tableTennisSlot4;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "13:00-14:00")
                {
                    cm.CommandText = tableTennisSlot5;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "14:00-15:00")
                {
                    cm.CommandText = tableTennisSlot6;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "15:00-16:00")
                {
                    cm.CommandText = tableTennisSlot7;
                }
                else if (ActivityComboBox.Text.Trim() == "Table Tennis" && TimeSlotComboBox.Text.Trim() == "16:00-17:00")
                {
                    cm.CommandText = tableTennisSlot8;
                }

                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "09:00-10:00")
                {
                    cm.CommandText = badmintonSlot1;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "10:00-11:00")
                {
                    cm.CommandText = badmintonSlot2;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "11:00-12:00")
                {
                    cm.CommandText = badmintonSlot3;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "12:00-13:00")
                {
                    cm.CommandText = badmintonSlot4;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "13:00-14:00")
                {
                    cm.CommandText = badmintonSlot5;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "14:00-15:00")
                {
                    cm.CommandText = badmintonSlot6;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "15:00-16:00")
                {
                    cm.CommandText = badmintonSlot7;
                }
                else if (ActivityComboBox.Text.Trim() == "Badminton" && TimeSlotComboBox.Text.Trim() == "16:00-17:00")
                {
                    cm.CommandText = badmintonSlot8;
                }

                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "09:00-10:00")
                {
                    cm.CommandText = basketBallSlot1;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "10:00-11:00")
                {
                    cm.CommandText = basketBallSlot2;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "11:00-12:00")
                {
                    cm.CommandText = basketBallSlot3;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "12:00-13:00")
                {
                    cm.CommandText = basketBallSlot4;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "13:00-14:00")
                {
                    cm.CommandText = basketBallSlot5;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "14:00-15:00")
                {
                    cm.CommandText = basketBallSlot6;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "15:00-16:00")
                {
                    cm.CommandText = basketBallSlot7;
                }
                else if (ActivityComboBox.Text.Trim() == "BasketBall" && TimeSlotComboBox.Text.Trim() == "16:00-17:00")
                {
                    cm.CommandText = basketBallSlot8;
                }

                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "09:00-10:00")
                {
                    cm.CommandText = onlySlot1;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "10:00-11:00")
                {
                    cm.CommandText = onlySlot2;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "11:00-12:00")
                {
                    cm.CommandText = onlySlot3;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "12:00-13:00")
                {
                    cm.CommandText = onlySlot4;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "13:00-14:00")
                {
                    cm.CommandText = onlySlot5;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "14:00-15:00")
                {
                    cm.CommandText = onlySlot6;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "15:00-16:00")
                {
                    cm.CommandText = onlySlot7;
                }
                else if (ActivityComboBox.Text.Trim() == "" && TimeSlotComboBox.Text.Trim() == "16:00-17:00")
                {
                    cm.CommandText = onlySlot8;
                }

                cm.Connection = con;
                con.Open();
                adap = new SqlDataAdapter(cm);
                ds = new DataSet();
                adap.Fill(ds, "1");
                FacilitiesDataGridView .DataSource = ds.Tables[0];


               
            }
            catch
            {
                MessageBox.Show("Please sellect a criteria");
            }
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
        }

        private void SearchByGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FacilitiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            cmb = new SqlCommandBuilder(adap);
            adap.Update(ds, "1");
        }

        private void displayTableButton_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"data source=(local); initial catalog=SA46Team05B ESNTET Project;integrated security=SSPI";
            cm = new SqlCommand();
            cm.CommandText = "select * from Availabilities";
            cm.Connection = con;
            con.Open();
            adap = new SqlDataAdapter(cm);
            ds = new DataSet();
            adap.Fill(ds, "1");
            FacilitiesDataGridView .DataSource = ds.Tables[0];
            
        }

        private void QueryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control ==true && e.KeyCode ==Keys.S )
            {
                SearchButton.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                updateButton .PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                displayTableButton .PerformClick();
            }
        }
    }
}
