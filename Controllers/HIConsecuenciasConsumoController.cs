using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIConsecuenciasConsumoController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIConsecuenciasConsumoModel consecuenciasConsumo = (HIConsecuenciasConsumoModel)o;

            try
            {
                DBConectionController.conn.Open();

                String query = "INSERT INTO dbo.HIConsecuenciasConsumo VALUES (CCConsumoAfectado = @ccConsumoAfectado, " + 
                    "CCConsumoAfectadoDesc = @ccConsumoAfectadoDesc, " + 
                    "CCAntecedentesFamiliares = @ccAntecedentesFamiliares, " + 
                    "CCAntecedentesPersonales = @ccAntecedentesPersonales)";
                
                SqlCommand addConsecuenciasConsumo = new SqlCommand(query, DBConectionController.conn);
                addConsecuenciasConsumo.Parameters.AddWithValue("ccConsumoAfectado", consecuenciasConsumo.ccConsumoAfectado);
                addConsecuenciasConsumo.Parameters.AddWithValue("ccConsumoAfectadoDesc", consecuenciasConsumo.ccConsumoAfectadoDesc);
                addConsecuenciasConsumo.Parameters.AddWithValue("ccAntecedentesFamiliares", consecuenciasConsumo.ccAntecedentesFamiliares);
                addConsecuenciasConsumo.Parameters.AddWithValue("ccAntecedentesPersonales", consecuenciasConsumo.ccAntecedentesPersonales);

                addConsecuenciasConsumo.ExecuteNonQuery();
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
