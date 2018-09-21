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
        public string CPF { get; set; }
        public System.DateTime Data { get; set; }
        public string Hora { get; set; }
        public Nullable<bool> BO { get; set; }
        public string TipoOcorrencia { get; set; }
        public string Descricao { get; set; }
        public string Prejuizo { get; set; }
        public Nullable<int> UsuarioIdUsuario { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Distrito { get; set; }
        public string City { get; set; }
        public bool Dinheiro { get; set; }
        public bool Carteira { get; set; }
        public bool Documentos { get; set; }
        public bool Celular { get; set; }
        public bool Notebook { get; set; }
        public bool Motocicleta { get; set; }
        public bool Veiculo { get; set; }
        public bool OutrosEletronicos { get; set; }
        public bool Outros { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
