using Avengers.Persistencia;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Avengers.Dominio.Gestores
{
    public class GestorUsers
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

        public void readUsersRoles(String condition)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select us.name, ro.name as role from usuario us, rol ro " + condition + " and us.refrol = ro.idrol", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readPermits(String condition)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("select name from permits " + condition + " order by name", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public void readInDB(String column, String table, String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select " + column + " from " + table + " " + cond, "littlerp");
            tabla = data.Tables["littlerp"];
        }
        
        public void readUsers(String cond)
        {
            DataSet data = new DataSet();
            ConnectOracle search = new ConnectOracle();

            data = search.getData("Select * from usuario " + cond + " order by idcustomer", "littlerp");
            tabla = data.Tables["littlerp"];
        }

        public static void insertUser(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }

        public static String getData(String column, String table, String cond)
        {
            ConnectOracle select = new ConnectOracle();
            return select.DLookUp(column, table, cond).ToString();
        }

        public static bool existsUser(String user)
        {
            ConnectOracle search = new ConnectOracle();
            int resp = Convert.ToInt16(search.DLookUp("count(*)", "usuario", "UPPER(NAME)= '" + user.ToUpper() + "' AND DELETED=0"));
            if (resp > 0)
            {
                return true;
            }
            return false;
        }

        public static void delUser(String sentencia)
        {
            ConnectOracle insert = new ConnectOracle();
            insert.setData(sentencia);
        }

        public static void setData(String sentencia)
        {
            ConnectOracle update = new ConnectOracle();
            update.setData(sentencia);
        }
        public void setDataV2(String sentencia)
        {
            ConnectOracle update = new ConnectOracle();
            update.setData(sentencia);
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public string GetMD5V2(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public int Validar(User u1)
        {
            ConnectOracle Search = new ConnectOracle();
            String cond = "UPPER(NAME) ='" + u1.getNombre() + "' AND UPPER(PASSWORD) ='" + u1.getContra() + "'";

            Object resul = Search.DLookUp("IDUSER", "USUARIO", cond);
            return Int32.Parse(resul.ToString());
        }
        public String getUnString(String sql)
        {
            ConnectOracle select = new ConnectOracle();
            return select.getData(sql);
        }
    }
}