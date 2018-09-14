using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class BairroController
    {
        void Insert(Bairro bai)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.BairroSet.Add(bai);
            contexto.SaveChanges();
        }

        Bairro BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.BairroSet.Find();
        }

        void Edit(int id, Bairro baiEditado)
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

        void Delete(int id)
        {
            Bairro baiExcluir = BuscaID(id);

            if(baiExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.BairroSet.Remove(baiExcluir);
                contexto.SaveChanges();
            }
        }

        List<Bairro> ListBairros()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.BairroSet.ToList();
        }
    }
}
