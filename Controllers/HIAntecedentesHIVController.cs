using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIAntecedentesHIVController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIAntecedentesHIVModel antecedentesHIV = (HIAntecedentesHIVModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.HIAntecedentesHIV VALUES (HIVTatuajes = @hivTatuajes, " +
                    "HIVUsoJeringas = @hivUsoJeringas, " +
                    "HIVPadeceSIDA = @hivPadeceSIDA, " +
                    "HIVHigenePersonal = @hivHigenePersonal, " +
                    "HIVHigeneHabitacional = @hivHigeneHabitacional, " +
                    "HIVProblemasAlimentaciones = @hivProblemasAlimentaciones, " +
                    "HIVProblemasAlimentacionesDesc = @hivProblemasAlimentacionesDesc, " +
                    "HIVTiempoLibre = @hivTiempoLibre, " +
                    "HIVFrecuencuasActividades = @hivFrecuenciasActividades, " +
                    "HIVEntretenimiento = @hivEntretenimiento)";

                SqlCommand addAntecendesHIV = new SqlCommand(query, DBConectionController.con);
                addAntecendesHIV.Parameters.AddWithValue("hivTatuajes", antecedentesHIV.hivTatuajes);
                addAntecendesHIV.Parameters.AddWithValue("hivUsoJeringas", antecedentesHIV.hivUsoJeringas);
                addAntecendesHIV.Parameters.AddWithValue("hivPadeceSIDA", antecedentesHIV.hivPadeceSIDA);
                addAntecendesHIV.Parameters.AddWithValue("hivHigenePersonal", antecedentesHIV.hivHigenePersonal);
                addAntecendesHIV.Parameters.AddWithValue("hivHigeneHabitacional", antecedentesHIV.hivHigeneHabitacional);
                addAntecendesHIV.Parameters.AddWithValue("hivProblemasAlimentaciones", antecedentesHIV.hivProblemasAlimenticios);
                addAntecendesHIV.Parameters.AddWithValue("hivProblemasAlimentacionesDesc", antecedentesHIV.hivProblemasAlimenticiosDesc);
                addAntecendesHIV.Parameters.AddWithValue("hivTiempoLibre", antecedentesHIV.hivTiempoLibre);
                addAntecendesHIV.Parameters.AddWithValue("hivFrecuenciasActividades", antecedentesHIV.hivFrecuenciasActividades);
                addAntecendesHIV.Parameters.AddWithValue("hivEntretenimiento", antecedentesHIV.hivEntretenimiento);

                addAntecendesHIV.ExecuteNonQuery();
                DBConectionController.con.Close();
            }
            catch (Exception e)
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
