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
    
    public partial class CV_ITEM_LINK
    {
        public long ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string URL { get; set; }
        public long CV_ITEM_ID { get; set; }

        [JsonIgnore]
        public virtual CV_ITEM CV_ITEM { get; set; }
    }
}