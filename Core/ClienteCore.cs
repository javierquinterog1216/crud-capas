using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Helper;
using Model;
using Newtonsoft.Json;

namespace Core
{
    public class ClienteCore
    {
        public ClienteModel Get(int id)
        {
            try
            {
                var tabla = ClienteDal.GetCliente(id);
                ClienteModel cliente = Helper.Utilidades.ToList<ClienteModel>(tabla).FirstOrDefault();
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<ClienteModel> GetAll()
        {
            
            try
            {
                var tabla = ClienteDal.GetCliente(Helper.Constantes.all);
                var lista = tabla.ToList<ClienteModel>();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public int Add(ClienteModel model)
        {
            try
            {
                return Dal.ClienteDal.Add(model);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Modify(ClienteModel model)
        {
            try
            {
                ClienteDal.Modify(model);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
