//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJSAuthentication.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CV_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CV_ITEM()
        {
            this.CV_ITEM1 = new HashSet<CV_ITEM>();
        }
    
        public long ID_ITEM { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public byte CONFIRMED { get; set; }
        public byte MODIFIED { get; set; }
        public string USER_ID_APPROVED { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
        public Nullable<System.DateTime> DATE_MODIFIED { get; set; }
        public Nullable<System.DateTime> DATE_CONFIRMED { get; set; }
        public Nullable<long> OLD_ITEM_ID { get; set; }
        public long CV_TABLE_ID_CV { get; set; }
        public Nullable<long> CRITERIA_ID_CRITERIA { get; set; }
    
        public virtual CRITERIA CRITERIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CV_ITEM> CV_ITEM1 { get; set; }
        public virtual CV_ITEM CV_ITEM2 { get; set; }
        public virtual CV_TABLE CV_TABLE { get; set; }
    }
}