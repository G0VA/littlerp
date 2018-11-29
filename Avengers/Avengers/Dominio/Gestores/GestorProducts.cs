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

        public DataSet readInProductV2(String cond, String col)
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



        public void writeProduct(String gender, String editorial, float price, String name, String desc, int stock)
        {
            ConnectOracle search = new ConnectOracle();
            search.setData("Insert into products values(1,'" + gender + "','" + editorial + "','" + price + "',0,'" + name + "','" + desc + "','" + stock + "')");
        }
    }
}
