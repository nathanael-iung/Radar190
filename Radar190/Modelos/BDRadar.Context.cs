﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDRadarContainer : DbContext
    {
        public BDRadarContainer()
            : base("name=BDRadarContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Usuario> UsuarioSet { get; set; }
        public virtual DbSet<Denuncia> DenunciaSet { get; set; }
        public virtual DbSet<ObjRoubado> ObjRoubadoSet { get; set; }
        public virtual DbSet<Administrador> AdministradorSet { get; set; }
        public virtual DbSet<ContatosEmergenciais> ContatosEmergenciaisSet { get; set; }
        public virtual DbSet<DicasSeguranca> DicasSegurancaSet { get; set; }
        public virtual DbSet<FaleConosco> FaleConoscoSet { get; set; }
        public virtual DbSet<Chat> ChatSet { get; set; }
    }
}
