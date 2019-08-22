using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{

    public class HIElementosSexualesController : IDataBaseMethods
    {
        public void addElement(object o)
        {
            HIElementosSexualesModel elementosSexuales = (HIElementosSexualesModel)o;

            try
            {
                DBConectionController.con.Open();

                string query = "INSERT INTO dbo.HIElementosSexuales VALUES (ESUsoCondon = @esUsoCondon, )" + 
                    "ESMetodoPlanificacion = @esMetodoPlanificacion, " + 
                    "ESMotivoAnticonceptivos = @esMotivoAnticonceptivos, " + 
                    "ESSexoOral = @esSexoOral, " + 
                    "ESSexoAnal = @esSexoAnal" + 
                    "ESSentimientoHombreMujer = @esSentimientoHombreMujer" + 
                    "ESSentimientoHombreMujerDesc = @esSentimientoHombreMujerDesc" + 
                    "ESRopaSexoOpuesto = @esRopaSexoOpuesto, " + 
                    "ESGenitalesDesconocidos = @esGenitalesDesconocidos, " +
                    "ESObservarRelaciones = @esObservarRelaciones, " + 
                    "ESFaltaDeseoSexual = @esFaltaDeseoSexual, " + 
                    "ESMalestares = @esMalestares, " + 
                    "ESRelacionesDesconocidos = @esRelacionesDesconocidos, " + 
                    "ESObjetosSexuales = @esObjetosSexuales, " + 
                    "ESMenoresEdad = @esMenoresEdad, " + 
                    "ESRelacionesAnimales = @esRelacionesAnimales, " + 
                    "ESLastimadoRelaciones = @esLastimadoRelaciones, " + 
                    "ESDisfuncionErectil = @esDisfuncionErectil, " + 
                    "ESEyacualcionPrecoz = @esEyaculacionPrecoz, " + 
                    "ESDificultadPenetrar = @esDificultadPenetrar, " + 
                    "ESLubricacionGenital = @esLubricacionGenital, " + 
                    "ESOrientacionSexual = @esOrientacionSexual, " + 
                    "ESConsecuenciaDrogas = @esConsecuenciaDrogas, " + 
                    "ESRechazoRelaciones = @esRechazoRelaciones, " + 
                    "ESAusenciaPlacer = @esAusenciaPlacer, " + 
                    "ESImaginacionSexual = @esImaginacionSexual)";

                SqlCommand addElementosSexuales = new SqlCommand(query, DBConectionController.con);
                addElementosSexuales.Parameters.AddWithValue("esUsoCondon", elementosSexuales.esUsoCondon);
                addElementosSexuales.Parameters.AddWithValue("esMetodoPlanificacion", elementosSexuales.esMetodoPlanificacion);
                addElementosSexuales.Parameters.AddWithValue("esMotivoAnticonceptivos", elementosSexuales.esMotivoAnticonceptivos);
                addElementosSexuales.Parameters.AddWithValue("esSexoOral", elementosSexuales.esSexoOral);
                addElementosSexuales.Parameters.AddWithValue("esSexoAnal", elementosSexuales.esSexoAnal);
                addElementosSexuales.Parameters.AddWithValue("esSentimientoHombreMujer", elementosSexuales.esSentimientoHombreMujer);
                addElementosSexuales.Parameters.AddWithValue("esSentimientoHombreMujerDesc", elementosSexuales.esSentimientoHombreMujerDesc);
                addElementosSexuales.Parameters.AddWithValue("esRopaSexoOpuesto", elementosSexuales.esRopaSexoOpuesto);
                addElementosSexuales.Parameters.AddWithValue("esGenitalesDesconocidos", elementosSexuales.esGenitalesDesconocidos);
                addElementosSexuales.Parameters.AddWithValue("esObservarRelaciones", elementosSexuales.esObservarRelaciones);
                addElementosSexuales.Parameters.AddWithValue("esFaltaDeseoSexual", elementosSexuales.esFaltaDeseoSexual);
                addElementosSexuales.Parameters.AddWithValue("esMalestares", elementosSexuales.esMalestares);
                addElementosSexuales.Parameters.AddWithValue("esRelacionesDesconocidos", elementosSexuales.esRelacionesDesconocidos);
                addElementosSexuales.Parameters.AddWithValue("esLastimadoRelaciones", elementosSexuales.esLastimadoRelaciones);
                addElementosSexuales.Parameters.AddWithValue("esDisfuncionErectil", elementosSexuales.esDisfuncionErectil);
                addElementosSexuales.Parameters.AddWithValue("esEyaculacionPrecoz", elementosSexuales.esEyaculacionPrecoz);
                addElementosSexuales.Parameters.AddWithValue("esDificultadPenetrar", elementosSexuales.esDificultadPenetrar);
                addElementosSexuales.Parameters.AddWithValue("esLubricacionGenital", elementosSexuales.esLubricacionGenital);
                addElementosSexuales.Parameters.AddWithValue("esConsecuenciaDrogas", elementosSexuales.esConsecuenciaDrogas);
                addElementosSexuales.Parameters.AddWithValue("esRechazoRelaciones", elementosSexuales.esRechazoRelaciones);
                addElementosSexuales.Parameters.AddWithValue("esAusenciaPlacer", elementosSexuales.esAusenciaPlacer);
                addElementosSexuales.Parameters.AddWithValue("esImaginacionSexual", elementosSexuales.esImaginacionSexual);

                addElementosSexuales.ExecuteNonQuery();
                DBConectionController.con.Close();

            }catch(Exception e)
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
