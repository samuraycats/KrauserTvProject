//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KrauserTv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblcapituloservers
    {
        public int idservidor { get; set; }
        public int idcapitulo { get; set; }
        public string link { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual tblcapitulos tblcapitulos { get; set; }
        public virtual tblservidores tblservidores { get; set; }
    }
}
