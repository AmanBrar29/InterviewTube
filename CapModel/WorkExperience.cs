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
    
    public partial class WorkExperience
    {
        public int ExperienceId { get; set; }
        public string ExpCompany { get; set; }
        public string ExpTitle { get; set; }
        public string ExpLocation { get; set; }
        public string ExpStartDate { get; set; }
        public string ExpEndDate { get; set; }
        public string CurrentPosition { get; set; }
        public string ExpSummary { get; set; }
        public int JobSeekerJSId { get; set; }
    
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
