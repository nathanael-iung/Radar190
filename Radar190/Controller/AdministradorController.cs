using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class AdministradorController
    {
        void Insert(Administrador admin)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.AdministradorSet.Add(admin);
            contexto.SaveChanges();
        }

        Administrador BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.AdministradorSet.Find();
        }

        void Edit(int id, Administrador adminEditado)
        {
            Administrador adminAntigo = BuscaID(id);

            if(adminAntigo != null)
            {
                adminAntigo.Nome = adminEditado.Nome;
                adminAntigo.Usuario = adminEditado.Usuario;
                adminAntigo.Senha = adminEditado.Senha;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(adminAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        void Delete(int id)
        {
            Administrador adminExcluir = BuscaID(id);

            if(adminExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.AdministradorSet.Remove(adminExcluir);
                contexto.SaveChanges();
            }
        }

        List<Administrador> ListAdministradores()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.AdministradorSet.ToList();
        }
    }
}
