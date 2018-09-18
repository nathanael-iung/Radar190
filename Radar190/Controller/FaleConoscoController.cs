using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FaleConoscoController
    {
        public void Insert(FaleConosco fale)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.FaleConoscoSet.Add(fale);
            contexto.SaveChanges();
        }

        public FaleConosco BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.FaleConoscoSet.Find();
        }

        public void Edit(int id, FaleConosco faleEditado)
        {
            FaleConosco faleAntigo = BuscaID(id);

            if(faleAntigo != null)
            {
                faleAntigo.Nome = faleEditado.Nome;
                faleAntigo.Email = faleEditado.Email;
                faleAntigo.Assunto = faleEditado.Assunto;
                faleAntigo.Mensagem = faleEditado.Mensagem;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(faleAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            FaleConosco faleExcluir = BuscaID(id);
            
            if(faleExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.FaleConoscoSet.Remove(faleExcluir);
                contexto.SaveChanges();
            }
        }

        public List<FaleConosco> ListFaleConosco()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.FaleConoscoSet.ToList();
        }
    }
}
