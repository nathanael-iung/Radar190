using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ChatController
    {
        BDRadarContainer contexto = new BDRadarContainer();
        public int id;

        public int RetornaID(string nome)
        {
            var encontraID = from chatNome in contexto.UsuarioSet
                             where chatNome.NomeCompleto == nome
                             select chatNome.IdUsuario;

            if (encontraID.ToList().Count > 0)
            {
                return id = encontraID.First();
            }
            else
            {
                return id = 0;
            }
        }

        public void Insert(Chat ch)
        {
            contexto.ChatSet.Add(ch);
            contexto.SaveChanges();
        }

        public Chat BuscaID(int id)
        {
            return contexto.ChatSet.Find();
        }

        public void Edit(int id, Chat chatEditado)
        {
            Chat ChatAntigo = BuscaID(id);

            if (ChatAntigo != null)
            {
                ChatAntigo.Nome = chatEditado.Nome;
                ChatAntigo.Mensagem = chatEditado.Mensagem;

                contexto.Entry(ChatAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Chat chatExcluir = BuscaID(id);

            if (chatExcluir != null)
            {
                contexto.ChatSet.Remove(chatExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Chat> ListChat()
        {
            return contexto.ChatSet.ToList();
        }

    }
}
