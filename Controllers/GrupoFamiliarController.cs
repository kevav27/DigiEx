using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class GrupoFamiliarController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            GrupoFamiliarModel grupoFamiliar = (GrupoFamiliarModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.GrupoFamiliar VALUES (GFNombre = @gfNombre, " +
                    "GFRelacion = @gfRelacion, " +
                    "GFEscolaridad = @gfEscolaridad, " +
                    "GFOcupacion = @gfOcupacion, " +
                    "GFIngresos = @gfIngresos)";

                SqlCommand addGrupoFamiliar = new SqlCommand(query, DBConectionController.con);

                addGrupoFamiliar.Parameters.AddWithValue("gfNombre", grupoFamiliar.gfNombre);
                addGrupoFamiliar.Parameters.AddWithValue("gfRelacion", grupoFamiliar.gfRelacion);
                addGrupoFamiliar.Parameters.AddWithValue("gfEscolaridad", grupoFamiliar.gfEscolaridad);
                addGrupoFamiliar.Parameters.AddWithValue("gfOperacion", grupoFamiliar.gfOcupacion);
                addGrupoFamiliar.Parameters.AddWithValue("gfIngresos", grupoFamiliar.gfIngresos);

                addGrupoFamiliar.ExecuteNonQuery();
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
