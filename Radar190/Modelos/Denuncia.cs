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
    
    public partial class Denuncia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Denuncia()
        {
            this.ObjRoubado = new HashSet<ObjRoubado>();
            this.Mapa = new HashSet<Mapa>();
        }
    
        public int IdDenuncia { get; set; }
        public string NomeCompleto { get; set; }
        public Nullable<short> Idade { get; set; }
        public string Tipo { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public System.DateTime Data { get; set; }
        public string Hora { get; set; }
        public Nullable<bool> BO { get; set; }
        public string TipoOcorrencia { get; set; }
        public string Descricao { get; set; }
        public string Prejuizo { get; set; }
        public Nullable<int> UsuarioIdUsuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjRoubado> ObjRoubado { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mapa> Mapa { get; set; }
    }
}
