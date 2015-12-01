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
    
    public partial class Recruiter
    {
        public Recruiter()
        {
            this.JobPostings = new HashSet<JobPosting>();
        }
    
        public int RecId { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string HasAccess { get; set; }
        public int CompanyCompId { get; set; }
        public string UserName { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<JobPosting> JobPostings { get; set; }
        public virtual Location Location { get; set; }
    }
}