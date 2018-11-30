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

            data = search.getData("Select * from products " + cond, "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readInProduct(String cond, String col)
        {

            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + col + " from products " + cond + " order by idproduct", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public static DataSet readInProductV2(String cond, String col)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + col + " from products " + cond + " order by idproduct", "littlerp");
            return data;
        }

        public void readInProductV3(String cond, String col, String groupby)
        {

            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + col + " from products " + cond + " group by " + groupby, "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public static bool existProduct(String name)
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "products", "UPPER(NAME)= '" + name.ToUpper() + "' AND DELETED=0"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }

        public static bool existProductOrders(String id)
        {
            bool exist = false;
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "orders", "IDORDER= (Select REFORDER from ordersproducts Where REFPRODUCT ='" + id +"')"));
            if (resp > 0)
            {
                exist = true;
            }
            return exist;
        }


        public static void writeProduct(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }

        public static void deleteProduct(String sentencia)
        {
            ConnectOracle delete = new ConnectOracle();
            delete.setData(sentencia);     
        }

        public static void updateProduct(String sentencia, String id)
        {
            ConnectOracle update = new ConnectOracle();
            sentencia += " Where IDPRODUCT =" + id;
            update.setData(sentencia);
        }
    }
}
