//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoTradingCore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlotterExecution
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string ClOrdId { get; set; }
        public string ExecID { get; set; }
        public System.DateTime LocalTimeStamp { get; set; }
        public System.DateTime ServerTimeStamp { get; set; }
        public Nullable<decimal> Price { get; set; }
        public int ProviderID { get; set; }
        public Nullable<decimal> QtyFilled { get; set; }
        public Nullable<int> Side { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
