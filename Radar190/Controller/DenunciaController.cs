using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DenunciaController
    {

        BDRadarContainer contexto = new BDRadarContainer();
        public int id;

        public int RetornaID(string nome)
        {
            var encontraID = from userNome in contexto.UsuarioSet
                             where userNome.NomeCompleto == nome
                             select userNome.IdUsuario;

            if (encontraID.ToList().Count > 0)
            {
                return id = encontraID.First();
            }
            else
            {
                return id = 0;
            }

        }

        public void Insert(Denuncia denun)
        {
            try
            {
                contexto.DenunciaSet.Add(denun);
                contexto.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public Denuncia BuscaID(int id)
        {
            return contexto.DenunciaSet.Find();
        }

        public void Edit(int id, Denuncia denunEditado)
        {
            Denuncia denunAntigo = BuscaID(id);

            if (denunAntigo != null)
            {
                denunAntigo.NomeCompleto = denunEditado.NomeCompleto;
                denunAntigo.Idade = denunEditado.Idade;
                denunAntigo.Tipo = denunEditado.Tipo;
                denunAntigo.Sexo = denunEditado.Sexo;
                denunAntigo.CPF = denunEditado.CPF;
                denunAntigo.Data = denunEditado.Data;
                denunAntigo.Hora = denunEditado.Hora;
                denunAntigo.BO = denunEditado.BO;
                denunAntigo.TipoOcorrencia = denunEditado.TipoOcorrencia;
                denunAntigo.Prejuizo = denunEditado.Prejuizo;
                denunAntigo.Descricao = denunEditado.Prejuizo;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(denunAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Denuncia denunExcluir = BuscaID(id);

            if (denunExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.DenunciaSet.Remove(denunExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Denuncia> ListDenuncia()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.DenunciaSet.ToList();
        }
    }
}


