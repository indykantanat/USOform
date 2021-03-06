//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public long Id { get; set; }
        public string AnsDes { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> AnserTypeId { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<long> UserId { get; set; }
        public string AnsMonth { get; set; }
        public Nullable<long> SRId { get; set; }
    
        public virtual AnswerType AnswerType { get; set; }
        public virtual Question Question { get; set; }
        public virtual SR SR { get; set; }
        public virtual User User { get; set; }
    }
}
