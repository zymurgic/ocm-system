//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCM.Core.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MetadataValue
    {
        public int ID { get; set; }
        public int ChargePointID { get; set; }
        public int MetadataFieldID { get; set; }
        public string ItemValue { get; set; }
    
        public virtual ChargePoint ChargePoint { get; set; }
        public virtual MetadataField MetadataField { get; set; }
    }
}
