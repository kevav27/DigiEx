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
        public DateTime fechaDiagnostico { get; set; }
        public string ecPreComtemplacion { get; set; }
        public string ecComtemplacion { get; set; }
        public string ecDeterminacion { get; set; }
        public string ecAccion { get; set; }
        public string ecMantenimiento { get; set; }
        public string consumoDeSustancias { get; set; }
        public string psiquiatricaRecurrente { get; set; }
        public string violenciaIntrafamiliar { get; set; }
        public string problematicaJudicial { get; set; }
        public string inestabilidadLaboral { get; set; }
        public string deteriorioRelacion { get; set; }
        public string relacionesInterpersonales { get; set; }
        public string enfermedadesColaterales { get; set; }
        public string autoetimaBaja { get; set; }
        public string situacionAdiccion { get; set; }
        public string bienesMateriales { get; set; }
        public string presentaOtros { get; set; }
        public string nivelDeDeterioro { get; set; }
        public string recomendacionesTratamiento { get; set; }

        public DiagnosticoPreliminarModel()
        {

        }

    }
}
