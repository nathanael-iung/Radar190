using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class DicasSegurancaController
    {
        void Insert(DicasSeguranca dic)
        {
            //UsuarioSet ?? Usuario
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.DicasSegurancaSet.Add(dic);
            contexto.SaveChanges();
        }

        DicasSeguranca BuscaID(int id)
        {
            //UsuarioSet ?? Usuario
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.DicasSegurancaSet.Find();
        }

        void Edit(int id, DicasSeguranca dicEditado)
        {
            DicasSeguranca dicAntigo = BuscaID(id);

            if (dicAntigo != null)
            {
                dicAntigo.Descricao = dicEditado.Descricao;
              
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(dicAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        void Delete(int id)
        {
            DicasSeguranca dicExcluir = BuscaID(id);

            if (dicExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.DicasSegurancaSet.Remove(dicExcluir);
                contexto.SaveChanges();
            }
        }

        List<DicasSeguranca> ListDicasSeguranca()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.DicasSegurancaSet.ToList();
        }
    }
}
