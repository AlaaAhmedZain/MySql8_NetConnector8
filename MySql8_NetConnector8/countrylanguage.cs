//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql8_NetConnector8
{
    using System;
    using System.Collections.Generic;
    
    public partial class countrylanguage
    {
        public string CountryCode { get; set; }
        public string Language { get; set; }
        public string IsOfficial { get; set; }
        public float Percentage { get; set; }
    
        public virtual country country { get; set; }
    }
}
