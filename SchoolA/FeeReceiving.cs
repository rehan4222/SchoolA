//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolA
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeeReceiving
    {
        public int FeeReceivingID { get; set; }
        public int FeeChallanID { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentFname { get; set; }
        public string StudentClass { get; set; }
        public string FeeType { get; set; }
        public string FeeTerm { get; set; }
        public System.DateTime FeeIssueDate { get; set; }
        public System.DateTime FeeDueDate { get; set; }
        public int FeeAmount { get; set; }
        public System.DateTime FeeReceivingDate { get; set; }
        public int FeePaid { get; set; }
        public int FeeFine { get; set; }
        public int FeeBalance { get; set; }
    }
}