//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DepartmentList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartmentList()
        {
            this.DisbursementLists = new HashSet<DisbursementList>();
            this.StationeryRetrievalFormDetails = new HashSet<StationeryRetrievalFormDetail>();
            this.Employees = new HashSet<Employee>();
        }
    
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> TelephoneNo { get; set; }
        public Nullable<int> FaxNo { get; set; }
        public string HeadId { get; set; }
        public string CollectionPoint { get; set; }
        public string RepresentativeId { get; set; }
    
        public virtual CollectionPoint CollectionPoint1 { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisbursementList> DisbursementLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationeryRetrievalFormDetail> StationeryRetrievalFormDetails { get; set; }
        public virtual Employee Employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
