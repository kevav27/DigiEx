using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el cuarto formulario (plan tratamiento)
    //Todos los datos estan en la tabla PlanTratamientoDesc
    public class PlanTratamientoDescModel
    {
        public string ptObjetivo { get; set; }
        public string ptEstrategias { get; set; }
        public string ptMeta { get; set; }

        public PlanTratamientoDescModel()
        {

        }
    }
}
