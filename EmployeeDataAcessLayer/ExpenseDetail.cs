//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeDataAcessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpenseDetail
    {
        public int ExpenseReportID { get; set; }
        public string ExpenseType { get; set; }
        public Nullable<System.DateTime> ExpenseDate { get; set; }
        public Nullable<int> AmountSpent { get; set; }
        public string PaymentType { get; set; }
        public Nullable<int> MR_Number { get; set; }
        public string ReimbursementAccNo { get; set; }
        public string ExpenseStatus { get; set; }
    
        public virtual TravelDetail TravelDetail { get; set; }
    }
}