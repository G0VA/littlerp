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

            data = search.getData("Select * from customers order by idcustomer","littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readCustomers(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from customers "+cond+" order by idcustomer", "littlerp");
            tabla = data.Tables["littlerp"];
        }
    }
}
