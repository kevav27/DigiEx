using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PersonController : IDataBaseMethods
    {

        public void addElement(object o)
        {
            PersonaModel persona = (PersonaModel)o;
            try
            {
                DBConectionController.con.Open();
                string query = "INSERT INTO dbo.Persona VALUES()";
                

            }catch(Exception e)
            {
                //Error
            }

        }

        public void editElement(int id, object o)
        {
            throw new NotImplementedException();
        }

        public void fetchElement(string f)
        {
            throw new NotImplementedException();
        }

        public void findElement(int id)
        {
            throw new NotImplementedException();
        }
    }

}
