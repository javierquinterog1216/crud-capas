using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core;
using Model;

namespace Web.Controllers
{

    public class ClientesController : ApiController
    {
        private ClienteCore _core = new ClienteCore();
        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<ClienteModel> Get()
        {
            try
            {
                var lista = _core.GetAll();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: api/Clientes/5
        [HttpGet]
        public ClienteModel Get(int id)
        {
            try
            {
                var model = _core.Get(id);
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST: api/Clientes
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Clientes/5
        [HttpPost]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Clientes/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
