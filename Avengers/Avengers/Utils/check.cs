using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers.Utils
{
    class check
    {
        /*
         * Metodo para comprobar si el DNI cumple con el formato correcto
         */
        public static bool checkDNI(String dni)
        {
            Regex regex = new Regex("[0-9]{8,8}[A-Za-z]");
            return regex.IsMatch(dni);
        }
        /*
         * Metodo para comprobar si el email cumple el formato correcto
         */
        public static bool checkEmail(String email)
        {
            Regex regex = new Regex("^[a-zA-Z0-9_!#$%&’*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$");
            return regex.IsMatch(email);
        }
    }
}
