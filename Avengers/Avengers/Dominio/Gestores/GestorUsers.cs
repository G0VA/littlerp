using Avengers.Persistencia;
using System;
using System.Data;


namespace Avengers.Dominio.Gestores
{
    class GestorUsers
    {
        private DataTable tabla;

        public GestorUsers()
        {
            tabla = new DataTable();
        }

        public DataTable getUsers()
        {
            return this.tabla;
        }

        public void readUsers()
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from usuario order by name", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readUsers(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from usuario " + cond + " order by name", "littlerp");
            tabla = data.Tables["littlerp"];
        }
    }
}
