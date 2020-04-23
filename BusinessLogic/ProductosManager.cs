using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BusinessLogic
{
    public static class ProductosManager
    {
        public static int Guardar(Producto pProducto)
        {
            // Validamos que el stock sea mayor que 0
            if (pProducto.Stock < 0)
            {
                return 0;
            }
            // Validamos que el precio sea mayor a 0
            if (pProducto.Precio < 0)
            {
                return 0;
            }
            return ProductosDAL.Guardar(pProducto);
        }
        public static List<Producto> Buscar()
        {
            return ProductosDAL.Buscar();
        }
        public static List<Producto> Buscar(string pNombre)
        {
            return ProductosDAL.Buscar(pNombre);
        }
        public static int Eliminar(int pID)
        {
            return ProductosDAL.Eliminar(pID);
        }
    }
}
