//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public int LocationId { get; set; }
        public string AptNum { get; set; }
        public string StreetAdd { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    
        public virtual JobSeeker JobSeeker { get; set; }
        public virtual JobPosting JobPosting { get; set; }
        public virtual Company Company { get; set; }
        public virtual Recruiter Recruiter { get; set; }
    }
}
