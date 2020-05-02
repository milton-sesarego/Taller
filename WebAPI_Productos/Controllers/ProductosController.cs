using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BusinessLogic;
using Domain;

namespace WebAPIClientes
{
    public class ProductosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Producto> Get()
        {
            return ProductosManager.Buscar();
        }

        // POST api/<controller>
        public void Post([FromBody]Producto producto)
        {
            ProductosManager.Guardar(producto);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Producto producto)
        {
            ProductosManager.Guardar(producto);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            ProductosManager.Eliminar(id);
        }
    }
}