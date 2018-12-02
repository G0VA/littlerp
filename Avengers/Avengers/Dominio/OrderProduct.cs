using Avengers.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers.Dominio
{
    class OrderProduct
    {
        private String Nombre;
        private GestorOrdersProduct g;

        public OrderProduct()
        {
            g = new GestorOrdersProduct();
        }
        public GestorOrdersProduct getGestor()
        {
            return g;
        }
        public String getNombre()
        {
            return Nombre;
        }
        public void setNombre(String nombre)
        {
            this.Nombre = nombre;
        }
    }
}
