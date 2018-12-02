using Avengers.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers.Dominio.Gestores
{
    class GestorOrdersProduct
    {
        private DataTable tabla;

        public GestorOrdersProduct()
        {
            tabla = new DataTable();
        }

        public DataTable getOrderProduct()
        {
            return this.tabla;
        }

        public void readOrderProduct()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from ordersproducts order by name", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readOrderProduct(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from ordersproducts " + cond + " order by name", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public static void insertOrderProduct(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }
    }
}
