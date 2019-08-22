using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIAntecedentesSexualesController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIAntecedentesSexualesModel antecedentesSexuales = (HIAntecedentesSexualesModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.HIAntecedentesSexuales VALUES (ASInformacionSexual = @asInformacionSexual, " + 
                    "ASRelacionesSexuales = @asRelacionesSexuales, " + 
                    "ASPrimerContacto = @asPrimerContacto, " + 
                    "ASMasturbacionAdolescencia = @asMasturbacionAdolescencia, " + 
                    "ASActualmenteMasturba = @asActualmenteMasturba, " + 
                    "ASPrimeraPareja = @asPrimeraPareja, " + 
                    "ASAbusadoSexualmente = @asAbusadoSexualmente, " + 
                    "ASTemorRelaciones = @asTemorRelaciones, " + 
                    "ASActoSexual = @asActoSexual, " + 
                    "ASPracticoSexo = @asPracticoSexual, " + 
                    "ASPreferenciaSexual = @asPreferencialSexual, " + 
                    "ASSexoBajoDrogas = @asSexoBajoDrogas, " + 
                    "ASRelacionesIncestuosas = @asRelacionesIncestuosas, " + 
                    "ASRelacionesIncestuosasDesc = @asRelacionesIncestuosasDesc)";

                SqlCommand addAntecedentesSexuales = new SqlCommand(query, DBConectionController.con);
                addAntecedentesSexuales.Parameters.AddWithValue("asInformacionSexual", antecedentesSexuales.asInformacionSexual);
                addAntecedentesSexuales.Parameters.AddWithValue("asRelacionesSexuales", antecedentesSexuales.asRelacionesSexuales);
                addAntecedentesSexuales.Parameters.AddWithValue("asPrimerContacto", antecedentesSexuales.asPrimerContacto);
                addAntecedentesSexuales.Parameters.AddWithValue("asMasturbacionAdolescencia", antecedentesSexuales.asMasturbacionAdolescencia);
                addAntecedentesSexuales.Parameters.AddWithValue("asActualmenteMasturba", antecedentesSexuales.asActualmenteMasturba);
                addAntecedentesSexuales.Parameters.AddWithValue("asPrimeraPareja", antecedentesSexuales.asPrimeraPareja);
                addAntecedentesSexuales.Parameters.AddWithValue("asAbusadoSexualmente", antecedentesSexuales.asAbusadoSexualmente);
                addAntecedentesSexuales.Parameters.AddWithValue("asTemorRelaciones", antecedentesSexuales.asTemorRelaciones);
                addAntecedentesSexuales.Parameters.AddWithValue("asActoSexual", antecedentesSexuales.asActoSexual);
                addAntecedentesSexuales.Parameters.AddWithValue("asPracticoSexual", antecedentesSexuales.asPracticoSexual);
                addAntecedentesSexuales.Parameters.AddWithValue("asPreferencialSexual", antecedentesSexuales.asPreferencialSexual);
                addAntecedentesSexuales.Parameters.AddWithValue("asSexoBajoDrogas", antecedentesSexuales.asSexoBajoDrogas);
                addAntecedentesSexuales.Parameters.AddWithValue("asRelacionesIncestuosas", antecedentesSexuales.asRelacionesIncestuosas);
                addAntecedentesSexuales.Parameters.AddWithValue("asRelacionesIncestuosasDesc", antecedentesSexuales.asRelacionesIncestuosasDesc);

                addAntecendentesSexuales.ExecuteNonQuery();
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
