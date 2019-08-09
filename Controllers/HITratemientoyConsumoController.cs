using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class HITratemientoyConsumoController : IDataBaseMethods
    {

        public void addElement(object o)
        {
            HITratamientoyConsumoModel tratamientoyConsumo = (HITratamientoyConsumoModel)o;
            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.HITratamientoyConsumo VALUES (TCRecibidoTratamiento = @tcRecibidoTratamiento, " +
                    "TCRecibidoTratamientoDesc = @tcRecibidoTratamientoDesc, " +
                    "TCAtendieron = @tcAtendieron, " +
                    "TCAtendieronDesc = @tcAtendieronDesc, " +
                    "TCCompletoTratamiento = @tcCompletoTratamiento, " +
                    "TCCompletoTratamientoDesc = @tcCompletoTratamientoDesc, " +
                    "TCTratamientoAntes = @tcTratamientoAntes, " +
                    "TCConsultasDrogas = @tcConsultasDrogas, " +
                    "TCInterrumpidoConsumo = @tcInterrumpidoConsumo, " +
                    "TCInterrumpidoConsumoDesc = tcInterrumpidoConsumoDesc, " +
                    "TCMotivoInterrupcion = @tcMotivoInterrupcion, " +
                    "TCMotivoInterrupcionDesc = @tcMotivoInterrupcionDesc, " +
                    "TCMotivoConsumir = @tcMotivoConsumir, " +
                    "TCMotivoConsumirDesc = @tcMotivoConsumirDesc, " +
                    "TCActitudPareja = @tcActitudPareja, " +
                    "TCActitudFamilia = @tcActitudFamilia, " +
                    "TCTrabajo_CentroEducativo = @tcTrabajo_CentroEducativo, " +
                    "TCTrabajo_CentroEducativoDesc = @tcTrabajo_CentroEducativoDesc, " +
                    "TCActitudCompaneros = @tcActitudCompaneros);";

                SqlCommand addTratamiento = new SqlCommand(query, DBConectionController.con);

                addTratamiento.Parameters.AddWithValue("tcRecibidoTratamiento", tratamientoyConsumo.tcRecibidoTratamiento);
                addTratamiento.Parameters.AddWithValue("tcRecibidoTratamientoDesc", tratamientoyConsumo.tcRecibidoTratamientoDesc);
                addTratamiento.Parameters.AddWithValue("tcAtendieron", tratamientoyConsumo.tcAtendieron);
                addTratamiento.Parameters.AddWithValue("tcAtendieronDesc", tratamientoyConsumo.tcAtendieronDesc);
                addTratamiento.Parameters.AddWithValue("tcCompletoTratamiento", tratamientoyConsumo.tcCompletoTratamiento);
                addTratamiento.Parameters.AddWithValue("tcCompletoTratamientoDesc", tratamientoyConsumo.tcCompletoTratamientoDesc);
                addTratamiento.Parameters.AddWithValue("tcTratamientoAntes", tratamientoyConsumo.tcTratamientoAntes);
                addTratamiento.Parameters.AddWithValue("tcConsultasDrogas", tratamientoyConsumo.tcConsultasDrogas);
                addTratamiento.Parameters.AddWithValue("tcInterrumpidoConsumo", tratamientoyConsumo.tcInterrumpidoConsumo);
                addTratamiento.Parameters.AddWithValue("tcMotivoInterrupcion", tratamientoyConsumo.tcMotivoInterrupcion);
                addTratamiento.Parameters.AddWithValue("tcMotivoInterrupcionDesc", tratamientoyConsumo.tcMotivoInterrupcionDesc);
                addTratamiento.Parameters.AddWithValue("tcMotivoConsumir", tratamientoyConsumo.tcMotivoInterrupcion);
                addTratamiento.Parameters.AddWithValue("tcMotivoConsumirDesc", tratamientoyConsumo.tcMotivoInterrupcionDesc);
                addTratamiento.Parameters.AddWithValue("tcActitudPareja", tratamientoyConsumo.tcActitudPareja);
                addTratamiento.Parameters.AddWithValue("tcActitudFamilia", tratamientoyConsumo.tcActitudFamilia);
                addTratamiento.Parameters.AddWithValue("tcTrabajo_CentroEducativo", tratamientoyConsumo.tcTrabajo_CentroEducativo);
                addTratamiento.Parameters.AddWithValue("tcTrabajo_CentroEducativoDesc", tratamientoyConsumo.tcTrabajo_CentroEducativoDesc);
                addTratamiento.Parameters.AddWithValue("tcActitudCompaneros", tratamientoyConsumo.tcActitudCompaneros);

                addTratamiento.ExecuteNonQuery();
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