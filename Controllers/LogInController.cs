using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DigiEx.Controllers;

namespace DigiEx.Controllers
{
    public class LogInController
    {
        public void Login(string user, string password)
        {
            try
            {
                DBConectionController.con.Open();
                SqlCommand userDB = new SqlCommand("SELECT User FROM dbo.LoginUsuario WHERE User = "+user);
                SqlCommand passwordDB = new SqlCommand("SELECT User FROM dbo.LoginUsuario WHERE Password = "+password);
                DBConectionController.con.Close();

                if (user.Equals(userDB) && password.Equals(passwordDB))
                {
                    
                }
                else
                {
                    //se dice que no tiene un usuario permitido, que verifique credenciales
                }
            }
            catch (Exception e)
            {
                //Manejo de errores en caso de falla, que devuelva un alert de error
            }
        }
    }
}
