//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAGA
{
    using System;
    using System.Collections.Generic;
    
    public partial class OldReservation
    {
        public int ReservationID { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public int ContactID { get; set; }
        public Nullable<int> EventID { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
