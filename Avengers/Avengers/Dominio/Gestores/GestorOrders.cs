using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avengers.Persistencia;
using System.Data;

namespace Avengers.Dominio.Gestores
{
    class GestorOrders
    {

        private DataTable tabla;

        public GestorOrders()
        {
            tabla = new DataTable();
        }

        public DataTable getOrders()
        {
            return this.tabla;
        }

        public void readOrders()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from orders order by idorder", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readOrders2(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from orders " + cond + " order by idorder", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readInOrders(String column, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from orders " + cond + " order by idorder", "littlerp");
            tabla = data.Tables["littlerp"];
        }
    
        public void readInDB(String column, String table, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from " + table + " " + cond, "littlerp");
            tabla = data.Tables["littlerp"];

        }

        public void readInDB2(String query)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData(query,"littlerp");
            tabla = data.Tables["littlerp"];
        }
        public static bool existOrder(String id)
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "orders", "IDORDER= '" + id + "' AND DELETED=0"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }


        public static void deleteOrder(String sentencia)
        {
            ConnectOracle delete = new ConnectOracle();
            delete.setData(sentencia);

        }
        public static void insertOrder(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }
        public static String getData(String column, String table, String cond)
        {
            ConnectOracle select = new ConnectOracle();
            return select.DLookUp(column, table, cond).ToString();

        }

        public static void setData(String sentencia)
        {
            ConnectOracle update = new ConnectOracle();
            update.setData(sentencia);
        }

    }
}

