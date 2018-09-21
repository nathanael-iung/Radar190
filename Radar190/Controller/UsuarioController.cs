using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public bool userOk, pasOk;
        public bool VerificaLogin(string usuario, string senha)
        {
            BDRadarContainer contexto = new BDRadarContainer();

            var log = from usu in contexto.UsuarioSet
                      where usu.User == usuario
                      select usu;

            //necessita verificação
            var pas = from usu in contexto.UsuarioSet
                      where usu.Senha == senha
                      select usu;

            //retorna true caso seja encontrada usuário e senha no BD e false caso o resultado do select seja 0
            if (log.ToList().Count > 0)
            {
                userOk = true;
            }
            if (pas.ToList().Count > 0)
            {
                pasOk = true;
            }

            if (userOk && pasOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert(Usuario user)
        {
            BDRadarContainer contexto = new BDRadarContainer();

            contexto.UsuarioSet.Add(user);
            contexto.SaveChanges();
        }

        public Usuario BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();

            return contexto.UsuarioSet.Find();
        }

        public void Edit(int id, Usuario usuarioEditado)
        {
            Usuario usuarioAntigo = BuscaID(id);

            if (usuarioAntigo != null)
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

            if (usuarioExcluir != null)
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
