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
            HITratemientoyConsumoModel hITratemientoyConsumo = (HITratemientoyConsumoModel)o;
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

                addTratamiento.Parameters.AddWithValue("tcRecibidoTratamiento", hITratemientoyConsumo.tcRecibidoTratamiento);
                addTratamiento.Parameters.AddWithValue("tcRecibidoTratamientoDesc", hITratemientoyConsumo.tcRecibidoTratamientoDesc);
                addTratamiento.Parameters.AddWithValue("tcAtendieron", hITratemientoyConsumo.tcAtendieron);
                addTratamiento.Parameters.AddWithValue("tcAtendieronDesc", hITratemientoyConsumo.tcAtendieronDesc);
                addTratamiento.Parameters.AddWithValue("tcCompletoTratamiento", hITratemientoyConsumo.tcCompletoTratamiento);
                addTratamiento.Parameters.AddWithValue("tcCompletoTratamientoDesc", hITratemientoyConsumo.tcCompletoTratamientoDesc);
                addTratamiento.Parameters.AddWithValue("tcTratamientoAntes", hITratemientoyConsumo.tcTratamientoAntes);
                addTratamiento.Parameters.AddWithValue("tcConsultasDrogas", hITratemientoyConsumo.tcConsultasDrogas);
                addTratamiento.Parameters.AddWithValue("tcInterrumpidoConsumo", hITratemientoyConsumo.tcInterrumpidoConsumo);
                addTratamiento.Parameters.AddWithValue("tcMotivoInterrupcion", hITratemientoyConsumo.tcMotivoInterrupcion);
                addTratamiento.Parameters.AddWithValue("tcMotivoInterrupcionDesc", hITratemientoyConsumo.tcMotivoInterrupcionDesc);
                addTratamiento.Parameters.AddWithValue("tcMotivoConsumir", hITratemientoyConsumo.tcMotivoInterrupcion);
                addTratamiento.Parameters.AddWithValue("tcMotivoConsumirDesc", hITratemientoyConsumo.tcMotivoInterrupcionDesc);
                addTratamiento.Parameters.AddWithValue("tcActitudPareja", hITratemientoyConsumo.tcActitudPareja);
                addTratamiento.Parameters.AddWithValue("tcActitudFamilia", hITratemientoyConsumo.tcActitudFamilia);
                addTratamiento.Parameters.AddWithValue("tcTrabajo_CentroEducativo", hITratemientoyConsumo.tcTrabajo_CentroEducativo);
                addTratamiento.Parameters.AddWithValue("tcTrabajo_CentroEducativoDesc", hITratemientoyConsumo.tcTrabajo_CentroEducativoDesc);
                addTratamiento.Parameters.AddWithValue("tcActitudCompaneros", hITratemientoyConsumo.tcActitudCompaneros);

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