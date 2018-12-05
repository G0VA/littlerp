using Avengers.Dominio.Gestores;
using System;

namespace Avengers.Dominio
{
    public class User
    {
        private String Nombre;
        private String contra;
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
        public String getContra()
        {
            return this.contra;
        }
        public void setContra(String contra)
        {
            if (contra.Equals("admin1234", StringComparison.OrdinalIgnoreCase))
            {
                this.contra = (contra);
            }
            else
            {
                GestorUsers g = new GestorUsers();
                this.contra = g.GetMD5V2(contra);
            }
        }
    }
}
