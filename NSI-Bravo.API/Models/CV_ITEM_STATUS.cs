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

    [JsonObject(IsReference = false)]
    public partial class CV_ITEM_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CV_ITEM_STATUS()
        {
            this.CV_ITEM = new HashSet<CV_ITEM>();
        }
    
        public int ID { get; set; }
        public string STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<CV_ITEM> CV_ITEM { get; set; }
    }
}
