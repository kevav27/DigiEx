using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el cuarto formulario (plan tratamiento)
    //Todos los datos estan en la tabla PlanTratamientoPreguntasEtapa2
    public class PlanTratamientoPreguntasEtapa2Model
    {
        public string e2ContactoFamiliarMejorado { get; set; }
        public string e2CodependenciaResidente { get; set; }
        public string e2MejoraComunicacion { get; set; }
        public string e2MejoraResponsabilidades { get; set; }
        public string e2MotivacionCambio { get; set; }

        public PlanTratamientoPreguntasEtapa2Model()
        {

        }
    }
}
