using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class DiagnosticoPreliminarController : IDataBaseMethods
    {

        public void addElement(object o)
        {
            DiagnosticoPreliminarModel diagnostico = (DiagnosticoPreliminarModel)o;
            try
            {
                DBConectionController.con.Open();
                string query = "INSERT INTO dbo.DiagnosticoPreliminar VALUES (FechaDiagnostico = @fechaDiagnostico, " +
                    "ECPreContemplacion = @ecPreContemplacion, " +
                    "ECContemplacion = @ecContemplacion," +
                    "ECDeterminacion = @ecDeterminacion," +
                    "ECAccion = @ecAccion," +
                    "ECMantenimiento = @ecMantenimiento, " +
                    "ConsumoDeSustancias = @consumoDeSustancias," +
                    "PsiquiatricaRecurrente = @psiquiatricaRecurrente," +
                    "ViolenciaIntrafamiliar = @violenciaIntrafamiliar," + 
                    "ProblematicaJudicial = @problematicaJudicial," +
                    "InestabilidadLaboral = @inestabilidadLaboral," +
                    "DeterioroRelacion = @deterioroRelacion," +
                    "RelacionesInterpersonales = @relacionesInterpersonales," +
                    "EnfermedadesColaterales = @enfermedadesColaterales," +
                    "AutoestimaBaja = @autoestimaBaja," +
                    "SituacionAdiccion = @situacionAdiccion," +
                    "BienesMateriales = @bienesMateriales," +
                    "PresentaOtros = @presentaOtros," +
                    "NiveldeDeterioro = @nivelDeDeterioro," +
                    "RecomendacionesTratamiento = @recomendacionesTratamiento)";
                SqlCommand addDiagnostico = new SqlCommand(query, DBConectionController.con);
                addDiagnostico.Parameters.AddWithValue("fechaDiagnostico", diagnostico.fechaDiagnostico);
                addDiagnostico.Parameters.AddWithValue("ecPreContemplacion", diagnostico.ecPreComtemplacion);
                addDiagnostico.Parameters.AddWithValue("ecContemplacion", diagnostico.ecComtemplacion);
                addDiagnostico.Parameters.AddWithValue("ecDeterminacion", diagnostico.ecDeterminacion);
                addDiagnostico.Parameters.AddWithValue("ecAccion", diagnostico.ecAccion);
                addDiagnostico.Parameters.AddWithValue("ecMantenimiento", diagnostico.ecMantenimiento);
                addDiagnostico.Parameters.AddWithValue("consumoDeSustancias", diagnostico.consumoDeSustancias);
                addDiagnostico.Parameters.AddWithValue("psiquiatricaRecurrente", diagnostico.psiquiatricaRecurrente);
                addDiagnostico.Parameters.AddWithValue("violenciaIntrafamiliar", diagnostico.violenciaIntrafamiliar);
                addDiagnostico.Parameters.AddWithValue("problematicaJudicial", diagnostico.problematicaJudicial);
                addDiagnostico.Parameters.AddWithValue("inestabilidadLaboral", diagnostico.inestabilidadLaboral);
                addDiagnostico.Parameters.AddWithValue("deterioroRelacion", diagnostico.deteriorioRelacion);
                addDiagnostico.Parameters.AddWithValue("relacionesInterpersonales", diagnostico.relacionesInterpersonales);
                addDiagnostico.Parameters.AddWithValue("autoestimaBaja", diagnostico.autoetimaBaja);
                addDiagnostico.Parameters.AddWithValue("situacionAdiccion", diagnostico.situacionAdiccion);
                addDiagnostico.Parameters.AddWithValue("bienesMateriales", diagnostico.bienesMateriales);
                addDiagnostico.Parameters.AddWithValue("presentaOtros", diagnostico.presentaOtros);
                addDiagnostico.Parameters.AddWithValue("nivelDeDeterioro", diagnostico.nivelDeDeterioro);
                addDiagnostico.Parameters.AddWithValue("recomendacionesTratamiento", diagnostico.recomendacionesTratamiento);
                addDiagnostico.ExecuteNonQuery();
                DBConectionController.con.Close();
            }catch(Exception e)
            {
                   //Error
            }
        }

        public void editElement(int id)
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