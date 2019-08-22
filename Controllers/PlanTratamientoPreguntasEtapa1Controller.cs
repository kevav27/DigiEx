using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PlanTratamientoPreguntasEtapa1Controller : IDataBaseMethods
    {

        public void addElement(object o)
        {
            PlanTratamientoPreguntasEtapa1Model planTratamientoPreguntasEtapa1 = (PlanTratamientoPreguntasEtapa1Model)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.PlanTratamientoPreguntasEtapa1 VALUES (E1AdaptaGrupo = @e1AdaptaGrupo, " + 
                    "E1ConductaSituacionAdictiva = @e1ConductaSituacionAdictiva, " + 
                    "E1MotivadoAlCambio = @e1MotivadoAlCambio, " + 
                    "E1FamiliaInvolucradaCambio = @e1FamiliaInvolucradaCambio, " + 
                    "E1VinculosRedesApoyo = @e1VinculosRedesApoyo)";

                SqlCommand addPlanTratamientoPreguntasE1 = new SqlCommand(query, DBConectionController.con);
                addPlanTratamientoPreguntasE1.Parameters.AddWithValue("e1AdaptaGrupo", planTratamientoPreguntasEtapa1.e1AdaptaGrupo);
                addPlanTratamientoPreguntasE1.Parameters.AddWithValue("e1ConductaSituacionAdictiva", planTratamientoPreguntasEtapa1.e1ConductaSituacionAdictiva);
                addPlanTratamientoPreguntasE1.Parameters.AddWithValue("e1MotivadoAlCambio", planTratamientoPreguntasEtapa1.e1MotivadoAlCambio);
                addPlanTratamientoPreguntasE1.Parameters.AddWithValue("e1FamiliaInvolucradaCambio", planTratamientoPreguntasEtapa1.e1FamiliaInvolucradaCambio);
                addPlanTratamientoPreguntasE1.Parameters.AddWithValue("e1VinculosRedesApoyo", planTratamientoPreguntasEtapa1.e1VinculosRedesApoyo);

                addPlanTratamientoPreguntasE1.ExecuteNonQuery();
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
