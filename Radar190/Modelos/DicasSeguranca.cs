//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DicasSeguranca
    {
        public int IdDicasSeguranca { get; set; }
        public string Descricao { get; set; }
        public int AdministradorIdAdministrador { get; set; }
    
        public virtual Administrador Administrador { get; set; }
    }
}
