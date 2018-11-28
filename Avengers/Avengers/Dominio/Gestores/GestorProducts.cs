using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avengers.Persistencia;

namespace Avengers.Dominio.Gestores
{
    class GestorProducts
    {
        private DataTable tabla;

        public GestorProducts()
        {
            tabla = new DataTable();
        }

        public DataTable getProducts()
        {
            return this.tabla;
        }

        public void readProducts()
        {
            DataSet data = new DataSet();
            Persistencia.ConnectOracle search = new Persistencia.ConnectOracle();

            data = search.getData("Select * from products order by idproduct", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readProducts(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from products " + cond + " order by idproduct", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readInProduct(String cond, String col) {

            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + col + " from products " + cond + " order by idproduct", "littlerp");
            tabla = data.Tables["littlerp"];
        }
    }
}
