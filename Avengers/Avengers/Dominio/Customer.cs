using Avengers.Dominio.Gestores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers.Dominio
{
    class Customer
    {
        private String Nombre;
        private GestorCustomers g;

        public Customer()
        {
            g = new GestorCustomers();
        }
        public GestorCustomers gestor()
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
