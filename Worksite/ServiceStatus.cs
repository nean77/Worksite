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
    
    public partial class ServiceStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceStatus()
        {
            this.ServiceOrders_ServiceStatuses = new HashSet<ServiceOrders_ServiceStatuses>();
        }
    
        public long ServiceStatusId { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOrders_ServiceStatuses> ServiceOrders_ServiceStatuses { get; set; }
    }
}