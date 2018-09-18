using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ObjRoubadocontroller
    {
        public void Insert(ObjRoubado obj)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            contexto.ObjRoubadoSet.Add(obj);
            contexto.SaveChanges();
        }

        public ObjRoubado BuscaID(int id)
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.ObjRoubadoSet.Find();
        }

        public void Edit(int id, ObjRoubado objEditado)
        {
            ObjRoubado objAntigo = BuscaID(id);

            if (objAntigo != null)
            {
                objAntigo.Dinheiro = objEditado.Dinheiro;
                objAntigo.Carteira = objEditado.Carteira;
                objAntigo.Documentos = objEditado.Documentos;
                objAntigo.Celular = objEditado.Celular;
                objAntigo.Notebook = objEditado.Notebook;
                objAntigo.Motocicleta = objEditado.Motocicleta;
                objAntigo.Veiculo = objEditado.Veiculo;
                objAntigo.OutrosEletronicos = objEditado.OutrosEletronicos;
                objAntigo.Outros = objEditado.Outros;

                BDRadarContainer contexto = new BDRadarContainer();
                contexto.Entry(objAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            ObjRoubado objExcluir = BuscaID(id);

            if(objExcluir != null)
            {
                BDRadarContainer contexto = new BDRadarContainer();
                contexto.ObjRoubadoSet.Remove(objExcluir);
                contexto.SaveChanges();
            }
        }

        public List<ObjRoubado> ListObjRoubado()
        {
            BDRadarContainer contexto = new BDRadarContainer();
            return contexto.ObjRoubadoSet.ToList();
        }
    }
}
