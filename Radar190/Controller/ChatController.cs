using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ChatController
    {
        public void Insert(Chat ch)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.ChatSet.Add(ch);
            contexto.SaveChanges();
        }

        public Chat BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.ChatSet.Find();
        }

        public void Edit(int id, Chat chatEditado)
        {
            Chat ChatAntigo = BuscaID(id);

            if (ChatAntigo != null)
            {
                ChatAntigo.Nome = chatEditado.Nome;
                ChatAntigo.Mensagem = chatEditado.Mensagem;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(ChatAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Chat chatExcluir = BuscaID(id);

            if (chatExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.ChatSet.Remove(chatExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Chat> ListChat()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.ChatSet.ToList();
        }

    }
}
