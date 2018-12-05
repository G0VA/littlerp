using Avengers.Dominio;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avengers
{
    public partial class Login : Form
    {
        private User u1;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            u1 = new User();
            u1.setNombre(nom.Text.ToUpper());
            u1.setContra(pass.Text);
            String sql;
            if (pass.Text.Equals("admin1234", StringComparison.OrdinalIgnoreCase))            
            {
                sql = "SELECT IDUSER FROM USUARIO WHERE UPPER(NAME) = '" + u1.getNombre() + "' AND UPPER(PASSWORD) = '" + u1.getContra().ToUpper() + "'";
            }
            else
            {
                sql = "SELECT IDUSER FROM USUARIO WHERE UPPER(NAME) = '" + u1.getNombre() + "' AND PASSWORD = '" + u1.getContra() + "'";
            }
            
            int id = int.Parse(u1.gestor().getUnString(sql));

            //Console.WriteLine("Traza--" + u1.getContra());
            //Console.WriteLine("Traza--" + u1.getNombre());
            //Console.WriteLine("Traza--" + id);
            if (id != -1)
            {
                if (u1.getContra().Equals("admin1234", StringComparison.OrdinalIgnoreCase)){
                    String newPass = (Interaction.InputBox("Welcolme " + u1.getNombre() + " Input your new pass", "New Pass"));
                    //Console.WriteLine(newPass);
                    u1.setContra(newPass);                    
                    u1.gestor().setDataV2("update usuario set password = '" + u1.getContra() + "' Where iduser = 1");
                    MessageBox.Show("pass modify successful");
                    Presentacion.Menu m1 = new Presentacion.Menu(u1);
                    this.Hide();
                    m1.Show();
                }
                else{
                    MessageBox.Show("Login successful " + u1.getNombre());
                    Presentacion.Menu m1 = new Presentacion.Menu(u1);
                    this.Hide();
                    m1.Show();
                }
                

            }
        }
    }
}
