using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HistorialLongitudinalController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HistorialLongitudinalModel historialLongitudinal = (HistorialLongitudinalModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.HistorialLongitudinal VALUES (CargoInternamiento = @cargoInternamiento, )" + 
                    "DIAcude = @diAcude, " + 
                    "DIAcudeDesc = @diAcudeDesc, " + 
                    "DIAfecta = @diAfecta, " + 
                    "DITratemiento = @diTratamiento, " + 
                    "DITratemientoDesc = diTratamientoDesc)";

                SqlCommand addHistorialLongitudinal = new SqlCommand(query, DBConectionController.con);
                addHistorialLongitudinal.Parameters.AddWithValue("cargoInternamiento", historialLongitudinal.cargoInternamiento);
                addHistorialLongitudinal.Parameters.AddWithValue("diAcude", historialLongitudinal.diAcude);
                addHistorialLongitudinal.Parameters.AddWithValue("diAcudeDesc", historialLongitudinal.diAcudeDesc);
                addHistorialLongitudinal.Parameters.AddWithValue("diAfecta", historialLongitudinal.diAfecta);
                addHistorialLongitudinal.Parameters.AddWithValue("diTratamiento", historialLongitudinal.diTratamiento);
                addHistorialLongitudinal.Parameters.AddWithValue("diTratamientoDesc", historialLongitudinal.diTratamientoDesc);

                addHistorialLongitudinal.ExecuteNonQuery();
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
