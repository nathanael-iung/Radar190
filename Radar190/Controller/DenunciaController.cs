using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DenunciaController
    {
        public void Insert(Denuncia denun)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.DenunciaSet.Add(denun);
            contexto.SaveChanges();
        }

        public Denuncia BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
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
                denunAntigo.DataHora = denunEditado.DataHora;
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

            if(denunExcluir != null)
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


