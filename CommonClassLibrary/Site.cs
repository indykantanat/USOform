//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Site()
        {
            this.SRs = new HashSet<SR>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public Nullable<int> Status { get; set; }
        public int HeadId { get; set; }
        public string CabinetId { get; set; }
        public Nullable<long> SiteCode { get; set; }
        public string VillageId { get; set; }
        public string Village { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Contract { get; set; }
        public string Type { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string TypeofSignal { get; set; }
    
        public virtual Head Head { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SR> SRs { get; set; }
    }
}
