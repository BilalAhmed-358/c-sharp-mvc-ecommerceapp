//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Khareedo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class admin_Login
    {
        public int LoginID { get; set; }
        public int EmpID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleType { get; set; }
        public string Notes { get; set; }
    
        public virtual admin_Employee admin_Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
