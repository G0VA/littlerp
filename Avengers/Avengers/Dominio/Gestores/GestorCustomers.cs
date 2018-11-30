using Avengers.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avengers.Dominio.Gestores
{
    class GestorCustomers
    {
        private DataTable tabla;

        public GestorCustomers()
        {
            tabla = new DataTable();
        }

        public DataTable getCustomers()
        {
            return this.tabla;
        }

        public void readCustomers()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from customers order by idcustomer", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readCustomers(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from customers " + cond + " order by idcustomer", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readInCustomers(String column, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from customers " + cond + " order by idcustomer", "littlerp");
            tabla = data.Tables["littlerp"];
        }
        public void readInDB(String column, String table, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from " + table + " " + cond, "littlerp");
            tabla = data.Tables["littlerp"];
        }
        public static bool existCustomer(String id)
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "orders", "REFCUSTOMER= '" + id + "' AND DELETED=0"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }
        public static bool existDNI(String DNI)
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "customers", "UPPER(DNI)= '" + DNI.ToUpper() + "' AND DELETED=0"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }

        public static void delCustomers(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);

        }
        public static void insertCustomer(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }

    }
}
