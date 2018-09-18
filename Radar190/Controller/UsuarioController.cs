using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController
    {
        //List<Product> PesquisarPorCor(string cor)
        //{
        //    AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
        //    var list = from prod in contexto.Product
        //               where prod.Color == cor
        //               select prod;

        //    return list.ToList();
        //}

        public void Insert (Usuario user)
        {
            //UsuarioSet ?? Usuario
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.UsuarioSet.Add(user);
            contexto.SaveChanges();
        }

        public Usuario BuscaID(int id)
        {   
            //UsuarioSet ?? Usuario
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.UsuarioSet.Find();
        }

        public void Edit(int id, Usuario usuarioEditado)
        {
            Usuario usuarioAntigo = BuscaID(id);

            if(usuarioAntigo != null)
            {
                usuarioAntigo.NomeCompleto = usuarioEditado.NomeCompleto;
                usuarioAntigo.DtNasc = usuarioEditado.DtNasc;
                usuarioAntigo.Experiencia = usuarioEditado.Experiencia;
                usuarioAntigo.Cidade = usuarioEditado.Cidade;
                usuarioAntigo.Descricao = usuarioEditado.Descricao;
                usuarioAntigo.User = usuarioEditado.User;
                usuarioAntigo.Senha = usuarioEditado.Senha;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(usuarioAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Usuario usuarioExcluir = BuscaID(id);

            if(usuarioExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.UsuarioSet.Remove(usuarioExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Usuario> ListUsuarios()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.UsuarioSet.ToList();
        }

    }
}
