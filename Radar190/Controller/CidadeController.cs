using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CidadeController
    {
        public void Insert(Cidade cid)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.CidadeSet.Add(cid);
            contexto.SaveChanges();
        }

        public Cidade BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.CidadeSet.Find();
        }

        public void Edit(int id, Cidade cidEditado)
        {
            Cidade cidAntigo = BuscaID(id);

            if (cidAntigo != null)
            {
                cidAntigo.City = cidEditado.City;
                cidAntigo.UF = cidEditado.UF;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(cidAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Cidade cidExcluir = new Cidade();

            if (cidExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.CidadeSet.Remove(cidExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Cidade> ListCidades()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.CidadeSet.ToList();
        }

    }
}
