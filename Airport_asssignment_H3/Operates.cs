//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airport_asssignment_H3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operates
    {
        public string AirlineIATA { get; set; }
        public int RoutesID { get; set; }
        public Nullable<System.DateTime> LeasingEndDate { get; set; }
    
        public virtual Airlines Airlines { get; set; }
        public virtual AirportRoutes AirportRoutes { get; set; }
    }
}
