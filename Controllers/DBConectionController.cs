using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DigiEx.Controllers
{
    public class DBConectionController : Controller
    {
        public static SqlConnection con = new SqlConnection
        ("Data Source= DESKTOP-VHF3JQF; database = FusavoPrueba; Initial Catalog = DatabaseConnectivity;Trusted_Connection=true;");

        public void PruebaLogin(string user, string password)
        {
            try
            {
                //con.Open();
                //Console.WriteLine("Ingrese el usuario");
                //var user = Console.ReadLine();
                //Console.WriteLine("Ingrese el password");
                //var password = Console.ReadLine();

                SqlCommand userDB = new SqlCommand("SELECT User FROM dbo.LoginUsuario");
                SqlCommand passwordDB = new SqlCommand("SELECT User FROM dbo.LoginUsuario");

                if (user.Equals(userDB) && password.Equals(passwordDB))
                {
                    Console.WriteLine("Logged in");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Failed");
                    Console.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Excepción encontrada: "+e.GetType());
                Console.ReadLine();
            }
        }
    }
}