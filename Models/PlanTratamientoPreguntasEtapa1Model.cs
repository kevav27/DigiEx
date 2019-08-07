using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el cuarto formulario (plan tratamiento)
    //Todos los datos estan en la tabla PlanTratamientoPreguntasEtapa1
    public class PlanTratamientoPreguntasEtapa1Model
    {
        public string e1AdaptaGrupo { get; set; }
        public string e1ConductaSituacionAdictiva { get; set; }
        public string e1MotivadoAlCambio { get; set; }
        public string e1FamiliaInvolucradaCambio { get; set; }
        public string e1VinculosRedesApoyo { get; set; }

        public PlanTratamientoPreguntasEtapa1Model()
        {

        }
    }
}
