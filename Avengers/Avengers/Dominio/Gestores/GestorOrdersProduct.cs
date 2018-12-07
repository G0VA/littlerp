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

            data = search.getData("Select * from ordersproducts order by idorderproduct", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readOrderProduct(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from ordersproducts " + cond + " order by idorderproduct", "littlerp");
            tabla = data.Tables["littlerp"];
        }
        public String getUnString(String sql)
        {
            ConnectOracle select = new ConnectOracle();
            return select.getData(sql);
        }
        public void readInDB(String column, String table, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from " + table + " " + cond, "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public static void insertOrderProduct(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }
    }
}
