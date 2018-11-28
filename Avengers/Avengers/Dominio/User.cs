using Avengers.Dominio.Gestores;
using System;

namespace Avengers.Dominio
{
    class User
    {
        private String Nombre;
        private GestorUsers g;

        public User()
        {
            g = new GestorUsers();
        }
        public GestorUsers gestor()
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
