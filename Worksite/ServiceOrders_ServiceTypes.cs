//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Worksite
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceOrders_ServiceTypes
    {
        public long ServiceOrders_ServiceTypesId { get; set; }
        public long ServiceOrderId { get; set; }
        public long ServiceTypeId { get; set; }
        public Nullable<decimal> Hours { get; set; }

        public ServiceOrders_ServiceTypes()
        {

        }
        public ServiceOrders_ServiceTypes(long ServiceOrderId, long ServiceTypeId, Nullable<decimal> Hours)
        {
            this.ServiceOrderId = ServiceOrderId;
            this.ServiceTypeId = ServiceTypeId;
            this.Hours = Hours;
        }
    
        public virtual ServiceOrder ServiceOrder { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
