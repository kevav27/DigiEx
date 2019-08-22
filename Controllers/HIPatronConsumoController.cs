using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIPatronConsumoController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIPatronConsumoModel patronConsumo = (HIPatronConsumoModel)o;

            try
            {
                DBConectionController.conn.Open();

                string query = "INSERT INTO dbo.HIPatronConsumo VALUES (PCLugarConsumo = @pcLugarConsumo, " + 
                    "PCLugarConsumoDesc = @pcLugarConsumoDesc, " + 
                    "PCQuienesConsumo = @pcQuienesConsumo, " + 
                    "PCQuienesConsumoDesc = @pcQuienesConsumoDesc, " + 
                    "PCMotivoConsumo = @pcMotivoConsumo, " + 
                    "PCMotivoConsumoDesc = @pcMotivoConsumoDesc, " + 
                    "PCDrogasConsumidas = @pcDrogasConsumidas, " + 
                    "PCFrecuenciaConsumo = @pcFrecuenciaConsumo, " + 
                    "PCNivelConsumo = @pcNivelConsumo, " + 
                    "PCDrogasUsadasUltimamente = @pcDrogasUsdasUltimamente)";

                SqlCommand addPatronConsumo = new SqlCommand(query, DBConectionController.conn);
                addPatronConsumo.Parameters.AddWithValue("pcLugarConsumo", patronConsumo.pcLugarConsumo);
                addPatronConsumo.Parameters.AddWithValue("pcLugarConsumoDesc", patronConsumo.pcLugarConsumoDesc);
                addPatronConsumo.Parameters.AddWithValue("pcQuienesConsumo", patronConsumo.pcQuienesConsumo);
                addPatronConsumo.Parameters.AddWithValue("pcQuienesConsumoDesc", patronConsumo.pcQuienesConsumoDesc);
                addPatronConsumo.Parameters.AddWithValue("pcMotivoConsumo", patronConsumo.pcMotivoConsumo);
                addPatronConsumo.Parameters.AddWithValue("pcMotivoConsumoDesc", patronConsumo.pcMotivoConsumoDesc);
                addPatronConsumo.Parameters.AddWithValue("pcDrogasConsumidas", patronConsumo.pcDrogasConsumidas);
                addPatronConsumo.Parameters.AddWithValue("pcFrecuenciaConsumo", patronConsumo.pcFrecuenciaConsumo);
                addPatronConsumo.Parameters.AddWithValue("pcNivelConsumo", patronConsumo.pcNivelConsumo);
                addPatronConsumo.Parameters.AddWithValue("pcDrogasUsdasUltimamente", patronConsumo.pcDrogasUsdasUltimamente);

                addPatronConsumo.ExecuteNonQuery();
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
