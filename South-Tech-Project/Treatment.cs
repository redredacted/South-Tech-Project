//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace South_Tech_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Treatment
    {
        public System.Guid TreatmentID { get; set; }
        public System.Guid EmployeeID { get; set; }
        public System.Guid PatientID { get; set; }
        public int Type { get; set; }
        public string Result { get; set; }
        public byte[] Timestamp { get; set; }
    }
}