using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BairroController
    {
        public void Insert(Bairro bai)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.BairroSet.Add(bai);
            contexto.SaveChanges();
        }

        public Bairro BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.BairroSet.Find();
        }

        public void Edit(int id, Bairro baiEditado)
        {
            Bairro baiAntigo = BuscaID(id);

            if(baiAntigo != null)
            {
                baiAntigo.Distrito = baiEditado.Distrito;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(baiAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Bairro baiExcluir = BuscaID(id);

            if(baiExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.BairroSet.Remove(baiExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Bairro> ListBairros()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.BairroSet.ToList();
        }
    }
}
