//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team05BESNETProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionID { get; set; }
        public string NRIC { get; set; }
        public string FacilityID { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public string Slot { get; set; }
        public string Timeslot { get; set; }
        public Nullable<double> Price { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Member Member { get; set; }
    }
}
