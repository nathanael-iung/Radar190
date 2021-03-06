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
        public int IdDenuncia { get; set; }
        public string NomeCompleto { get; set; }
        public Nullable<short> Idade { get; set; }
        public string Tipo { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public short Numero { get; set; }
        public string CPF { get; set; }
        public string Distrito { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public System.DateTime Data { get; set; }
        public string Hora { get; set; }
        public Nullable<bool> BO { get; set; }
        public string TipoOcorrencia { get; set; }
        public string Prejuizo { get; set; }
        public string Descricao { get; set; }
        public Nullable<bool> Dinheiro { get; set; }
        public Nullable<bool> Carteira { get; set; }
        public Nullable<bool> Documentos { get; set; }
        public Nullable<bool> Celular { get; set; }
        public Nullable<bool> Notebook { get; set; }
        public Nullable<bool> Motocicleta { get; set; }
        public Nullable<bool> Veiculo { get; set; }
        public Nullable<bool> OutrosEletronicos { get; set; }
        public Nullable<bool> Outros { get; set; }
        public Nullable<int> UsuarioIdUsuario { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
