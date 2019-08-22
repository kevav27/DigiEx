using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class ProyectoVidaController : IDataBaseMethods
    {

        public void addElement(object o)
        {
            ProyectoVidaModel proyectoVida = (ProyectoVidaModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.ProyectoVida VALUES (PVFortalezas = @pvFortalezas, " + 
                    "PVOportunidades = @pvOportunidades, " + 
                    "PVDebilidades = @pvDebilidades, " + 
                    "PVAmenazas = @pvAmenazas, " + 
                    "PVObjetivoVidaEgresar = @pvObjetivoVidaEgresar, " + 
                    "PVMetas = @pvMetas, " + 
                    "PVTareas = @pvTareas, " + 
                    "PVSeguimientoTratamiento = @pvSeguimientoTratamiento, " + 
                    "PVTiempoLibre = @pvTiempoLibre, " + 
                    "PVAcuerdosUltimaSesion = @pvAcuerdosUltimaSesion)";

                SqlCommand addProyectoVida = new SqlCommand(query, DBConectionController.con);
                addProyectoVida.Parameters.AddWithValue("pvFortalezas", proyectoVida.pvFortalezas);
                addProyectoVida.Parameters.AddWithValue("pvOportunidades", proyectoVida.pvOportunidades);
                addProyectoVida.Parameters.AddWithValue("pvDebilidades", proyectoVida.pvDebilidades);
                addProyectoVida.Parameters.AddWithValue("pvAmenazas", proyectoVida.pvAmenazas);
                addProyectoVida.Parameters.AddWithValue("pvObjetivoVidaEgresar", proyectoVida.pvObjetivoVidaEgresar);
                addProyectoVida.Parameters.AddWithValue("pvMetas", proyectoVida.pvMetas);
                addProyectoVida.Parameters.AddWithValue("pvTareas", proyectoVida.pvTareas);
                addProyectoVida.Parameters.AddWithValue("pvSeguimientoTratamiento", proyectoVida.pvSeguimientoTratamiento);
                addProyectoVida.Parameters.AddWithValue("pvTiempoLibre", proyectoVida.pvTiempoLibre);
                addProyectoVida.Parameters.AddWithValue("pvAcuerdosUltimaSesion", proyectoVida.pvAcuerdosUltimaSesion);

                addProyectoVida.ExecuteNonQuery();
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
