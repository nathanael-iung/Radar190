using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MapaController
    {
        public void Insert(Mapa map)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.MapaSet.Add(map);
            contexto.SaveChanges();
        }

        public Mapa BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.MapaSet.Find();
        }

        public void Edit(int id, Mapa mapEditado)
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

        public void Delete(int id)
        {
            Mapa mapExcluir = BuscaID(id);

            if (mapExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.MapaSet.Remove(mapExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Mapa> ListMap()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.MapaSet.ToList();
        }
    }
}
