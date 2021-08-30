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
    
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.ServiceOrders = new HashSet<ServiceOrder>();
        }
    
        public long DeviceId { get; set; }
        public string Name { get; set; }
        public Nullable<int> InventNo { get; set; }
        public long CustomerId { get; set; }
        public long DeviceTypeId { get; set; }
        public string SerialNumber { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceOrder> ServiceOrders { get; set; }

        public override string ToString()
        {
            return Name + "(" + DeviceId + ")";
        }
    }
}
