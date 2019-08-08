using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class DiagnosticoPreliminarController : IDataBaseMethods
    {

        public void addElement(object o)
        {
            DiagnosticoPreliminarModel diagnostico = (DiagnosticoPreliminarModel)o;
            try
            {
                DBConectionController.con.Open();
                string query = "INSERT INTO dbo.DiagnosticoPreliminar VALUES ()";

            }catch(Exception e)
            {
                
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