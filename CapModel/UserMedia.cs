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
    
    public partial class UserMedia
    {
        public int UMediaId { get; set; }
        public string VidPath { get; set; }
        public string MediaDesc { get; set; }
    
        public virtual JobSeeker JobSeeker { get; set; }
        public virtual JobPosting JobPosting { get; set; }
        public virtual Company Company { get; set; }
    }
}