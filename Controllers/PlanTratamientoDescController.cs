using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PlanTratamientoDescController : IDataBaseMethods
    {

        public void addElement(object o)
        {
            PlanTratamientoDescModel planTratamientoDesc = (PlanTratamientoDescModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.PlanTratamientoDesc VALUES (PTObjetivo = @ptObjetivo, " + 
                    "PTEstrategias = @ptEstrategias, " + 
                    "PTMeta = @ptMeta)";

                SqlCommand addPlanTratamientoDesc = new SqlCommand(query, DBConectionController.con);
                addPlanTratamientoDesc.Parameters.AddWithValue("ptObjetivo", planTratamientoDesc.ptObjetivo);
                addPlanTratamientoDesc.Parameters.AddWithValue("ptEstrategias", planTratamientoDesc.ptEstrategias);
                addPlanTratamientoDesc.Parameters.AddWithValue("ptMeta", planTratamientoDesc.ptMeta);

                addPlanTratamientoDesc.ExecuteNonQuery();
                DBConectionController.con.Close();
            }catch (Exception e)
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