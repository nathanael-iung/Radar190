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
        public bool logado;

        //List<Product> PesquisarPorCor(string cor)
        //{
        //    AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
        //    var list = from prod in contexto.Product
        //               where prod.Color == cor
        //               select prod;

        //    return list.ToList();
        //}

        public bool VerificaLogin(string usuario)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            var log = from usu in contexto.UsuarioSet
                      where usu.User == usuario
                      select usu;

            if (log.ToList().Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            /*
            BDRadarContainer contexto = new BDRadarContainer();
            SqlConnection con = new SqlConnection("data source = DESKTOP - V1BANKD; initial catalog = Radar190DB;integrated security=True;MultipleActiveResultSets=True;");
            con.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM UsuarioSet WHERE User = '" + usuario + "' AND Senha = '" + senha + "'");
            sql.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sql;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                return logado = true;
            }
            else
            {
                return logado = false;
            }
            */
        }

        public void Insert(Usuario user)
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
