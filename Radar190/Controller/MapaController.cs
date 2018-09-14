using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class MapaController
    {
        void Insert(Mapa map)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.MapaSet.Add(map);
            contexto.SaveChanges();
        }

        Mapa BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.MapaSet.Find();
        }

        void Edit(int id, Mapa mapEditado)
        {
            Mapa mapAntigo = BuscaID(id);

            if(mapAntigo != null)
            {
                mapAntigo.Endereco = mapEditado.Endereco;
                mapAntigo.Numero = mapEditado.Numero;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(mapAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        void Delete(int id)
        {
            Mapa mapExcluir = BuscaID(id);

            if (mapExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.MapaSet.Remove(mapExcluir);
                contexto.SaveChanges();
            }
        }

        List<Mapa> ListMap()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.MapaSet.ToList();
        }
    }
}
