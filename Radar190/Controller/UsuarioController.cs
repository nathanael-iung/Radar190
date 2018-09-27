using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController
    {
        BDRadarContainer contexto = new BDRadarContainer();

        public bool userOk, pasOk; // Verificação do usuário cadastrado ou não

        public bool VerificaLogin(string usuario, string senha)
        {
            // log recebe os usuários iguais a usuario
            var log = from usu in contexto.UsuarioSet
                      where usu.User == usuario
                      select usu;
           
            // pas recebe os usuários iguais a senha
            var pas = from usu in contexto.UsuarioSet
                      where usu.Senha == senha
                      select usu;

            // caso log e pas retornam + do 0, significa que o usuário está correto
            if (log.ToList().Count > 0)
            {
                userOk = true;
            }
            if (pas.ToList().Count > 0)
            {
                pasOk = true;
            }

            //caso usuário e senha sejam encontrados no BD, retorna true e false caso o resultado do select seja 0
            if (userOk && pasOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region "Lista teste de consulta ao BD - Não Funcional"
        /*
        public List<char> TotalBairros()
        {

            var verifica = "SELECT TOP 10 Distrito, COUNT(*) AS Total FROM DenunciaSet GROUP BY Distrito ORDER BY Total DESC";

            return verifica.ToList();
        }
        */
        #endregion


        public void Insert(Usuario user)
        {
            try
            {
                contexto.UsuarioSet.Add(user);
                contexto.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public Usuario BuscaID(int id)
        {
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

                contexto.Entry(usuarioAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Usuario usuarioExcluir = BuscaID(id);

            if (usuarioExcluir != null)
            {
                contexto.UsuarioSet.Remove(usuarioExcluir);
                contexto.SaveChanges();
            }
        }

        public List<Usuario> ListUsuarios()
        {
            return contexto.UsuarioSet.ToList();
        }

    }
}
