using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIAntecedentesDesarolloController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIAntecedentesDesarrolloModel antecedentesDesarollo = (HIAntecedentesDesarrolloModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.HIAntecedentesDesarrollo VALUES (ADDesarrollo = @adDesarrollo, " +
                    "ADDesarrolloDesc = @adDesarrolloDesc, " +
                    "ADOtros = @adOtros)";

                SqlCommand addAntecedentesDesarrollo = new SqlCommand(query, DBConectionController.con);

                addAntecedentesDesarrollo.Parameters.AddWithValue("adDesarrollo", antecedentesDesarollo.adDesarrollo);
                addAntecedentesDesarrollo.Parameters.AddWithValue("adDesarrolloDesc", antecedentesDesarollo.adDesarrolloDesc);
                addAntecedentesDesarrollo.Parameters.AddWithValue("adOtros", antecedentesDesarollo.adOtros);
                

                addAntecedentesDesarrollo.ExecuteNonQuery();
                DBConectionController.con.Close();
            }
            catch (Exception e)
            {
                //error
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
