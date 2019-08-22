using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PlanTratamientoPreguntasEtapa2Controller : IDataBaseMethods
    {

        public void addElement(object o)
        {
            PlanTratamientoPreguntasEtapa2Model planTratamientoPreguntasEtapa2 = (PlanTratamientoPreguntasEtapa2Model)o;

            try
            {
                string query = "INSERT INTO dbo.PlanTratamientoPreguntasEtapa2 VALUES (E2ContactoFamiliarMejorado = @e2ContactoFamiliarMejorado, " + 
                    "E2CodependenciaResidente = @e2CodependenciaResidente, " + 
                    "E2MejoraComunicacion = @e2MejoraComunicacion, " + 
                    "E2MejoraResponsabilidades = @e2MejoraResponsabilidades, " + 
                    "E2MotivacionCambio = @e2MotivacionCambio)";

                SqlCommand addPlanTratamientoPreguntasE2 = new SqlCommand(query, DBConectionController.con);
                addPlanTratamientoPreguntasE2.Parameters.AddWithValue("e2ContactoFamiliarMejorado", planTratamientoPreguntasEtapa2.e2ContactoFamiliarMejorado);
                addPlanTratamientoPreguntasE2.Parameters.AddWithValue("e2CodependenciaResidente", planTratamientoPreguntasEtapa2.e2CodependenciaResidente);
                addPlanTratamientoPreguntasE2.Parameters.AddWithValue("e2MejoraComunicacion", planTratamientoPreguntasEtapa2.e2MejoraComunicacion);
                addPlanTratamientoPreguntasE2.Parameters.AddWithValue("e2MejoraResponsabilidades", planTratamientoPreguntasEtapa2.e2MejoraResponsabilidades);
                addPlanTratamientoPreguntasE2.Parameters.AddWithValue("e2MotivacionCambio", planTratamientoPreguntasEtapa2.e2MotivacionCambio);

                addPlanTratamientoPreguntasE2.ExecuteNonQuery();
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
