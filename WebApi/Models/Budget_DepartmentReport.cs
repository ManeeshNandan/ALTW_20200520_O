//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Budget_DepartmentReport
    {
        public int Id { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Factory { get; set; }
        public string DeptExpense { get; set; }
        public string Scrap { get; set; }
        public string Travelling { get; set; }
        public string KPI { get; set; }
        public string Headcount { get; set; }
        public string Capex { get; set; }
    }
}