using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla DiagnosticoPreliminar
    public class DiagnosticoPreliminarModel
    {
        private DateTime fechaDiagnostico { get; set; }
        private string ecPreComtemplacion { get; set; }
        private string ecComtemplacion { get; set; }
        private string ecDeterminacion { get; set; }
        private string ecAccion { get; set; }
        private string ecMantenimiento { get; set; }
        private string consumoDeSustancias { get; set; }
        private string psiquiatricaRecurrente { get; set; }
        private string violenciaIntrafamiliar { get; set; }
        private string problematicaJudicial { get; set; }
        private string inestabilidadLaboral { get; set; }
        private string deteriorioRelacion { get; set; }
        private string relacionesInterpersonales { get; set; }
        private string enfermedadesColaterales { get; set; }
        private string autoetimaBaja { get; set; }
        private string situacionAdiccion { get; set; }
        private string bienesMateriales { get; set; }
        private string presentaOtros { get; set; }
        private string nivelDeDeterioro { get; set; }
        private string recomendacionesTratamiento { get; set; }

        public DiagnosticoPreliminarModel()
        {

        }
    }
}
