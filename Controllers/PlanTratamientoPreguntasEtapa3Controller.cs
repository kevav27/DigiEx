using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PlanTratamientoPreguntasEtapa3Controller : IDataBaseMethods
    {

        public void addElement(object o)
        {
            PlanTratamientoPreguntasEtapa3Model planTratamientoPreguntasEtapa3 = (PlanTratamientoPreguntasEtapa3Model)o;

            try
            {
                string query = "INSERT INTO dbo.PlanTratamientoPreguntasEtapa3 VALUES (E3SituacionAdiccion = @e3SituacionAdiccion, " + 
                    "E3ExistenciaRedesApoyo = @e3ExistenciaRedesApoyo, " + 
                    "E3ParticipacionGruposApoyo = @e3ParticipacionGruposApoyo, " + 
                    "E3DesarrolloHabilidadesSociales = @e3DesarrolloHabilidadesSociales, " + 
                    "E3UsuarioAutonomia = @e3UsuarioAutonomia, " + 
                    "E3MotivacionCambio = @e3MotivacionCambio, " + 
                    "E3ProyectoVida = @e3ProyectoVida, " + 
                    "E3PLanEgreso = @e3Planegreso)";

                SqlCommand addPlanTratamientoPreguntasE3 = new SqlCommand(query, DBConectionController.con);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3SituacionAdiccion", planTratamientoPreguntasEtapa3.e3SituacionAdiccion);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3ExistenciaRedesApoyo", planTratamientoPreguntasEtapa3.e3ExistenciaRedesApoyo);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3ParticipacionGruposApoyo", planTratamientoPreguntasEtapa3.e3ParticipacionGruposApoyo);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3DesarrolloHabilidadesSociales", planTratamientoPreguntasEtapa3.e3DesarrolloHabilidadesSociales);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3UsuarioAutonomia", planTratamientoPreguntasEtapa3.e3UsuarioAutonomia);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3MotivacionCambio", planTratamientoPreguntasEtapa3.e3MotivacionCambio);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3ProyectoVida", planTratamientoPreguntasEtapa3.e3ProyectoVida);
                addPlanTratamientoPreguntasE3.Parameters.AddWithValue("e3Planegreso", planTratamientoPreguntasEtapa3.e3Planegreso);

                addPlanTratamientoPreguntasE3.ExecuteNonQuery();
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
