//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppBackend.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobApplication
    {
        public int ID { get; set; }
        public System.DateTime ApplicationDate { get; set; }
        public string Description { get; set; }
        public int CandidateID { get; set; }
        public int JobVacancyID { get; set; }
    
        public virtual Candidate Candidate { get; set; }
    }
}
