//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Family_Members_Information_15_11_2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public member()
        {
            this.member1 = new HashSet<member>();
            this.member11 = new HashSet<member>();
            this.member12 = new HashSet<member>();
        }
    
        public int id { get; set; }
        public string fullname { get; set; }
        public bool gender { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public Nullable<bool> status { get; set; }
        public string hometown { get; set; }
        public string living { get; set; }
        public string occupation { get; set; }
        public Nullable<int> Father_id { get; set; }
        public Nullable<int> Mother_id { get; set; }
        public Nullable<int> spouse_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<member> member1 { get; set; }
        public virtual member member2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<member> member11 { get; set; }
        public virtual member member3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<member> member12 { get; set; }
        public virtual member member4 { get; set; }
    }
}
