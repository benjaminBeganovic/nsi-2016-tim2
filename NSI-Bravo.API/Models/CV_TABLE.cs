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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class CV_TABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CV_TABLE()
        {
            this.CV_ITEM = new HashSet<CV_ITEM>();
        }
    
        public long ID_CV { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string MOBILEPHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> BIRTH_DATE { get; set; }
        public string USER_ID { get; set; }

        [JsonIgnore]
        public virtual AspNetUsers AspNetUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<CV_ITEM> CV_ITEM { get; set; }
    }
}
