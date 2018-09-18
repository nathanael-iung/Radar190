using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ContatosEmergenciaisController
    {
        public void Insert(ContatosEmergenciais cont)
        {
            //UsuarioSet ?? Usuario
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.ContatosEmergenciaisSet.Add(cont);
            contexto.SaveChanges();
        }

        public ContatosEmergenciais BuscaID(int id)
        {
            //UsuarioSet ?? Usuario
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.ContatosEmergenciaisSet.Find();
        }

        public void Edit(int id, ContatosEmergenciais contEditado)
        {
            ContatosEmergenciais contAntigo = BuscaID(id);

            if (contAntigo != null)
            {
                contAntigo.Numero = contEditado.Numero;
                contAntigo.Nome = contEditado.Nome;
                contAntigo.Descricao = contEditado.Descricao;
               
             
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(contAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            ContatosEmergenciais contExcluir = BuscaID(id);

            if (contExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.ContatosEmergenciaisSet.Remove(contExcluir);
                contexto.SaveChanges();
            }
        }

        public List<ContatosEmergenciais> ListContatosEmergenciais()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.ContatosEmergenciaisSet.ToList();
        }
    }
}
