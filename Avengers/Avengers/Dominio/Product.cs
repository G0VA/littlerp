using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avengers.Dominio.Gestores;

namespace Avengers.Dominio
{
    class Product
    {
        private String name;
        private GestorProducts g;

        public Product() {
            
            g = new GestorProducts();
        }

        public GestorProducts getGestor() {
            return this.g;
        }

        public String getName() {
            return this.name;
        }

        public void setName(String name) {
            this.name = name;
        }
    }
}
