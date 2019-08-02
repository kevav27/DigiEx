using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el ultimo formulario (plan tratamiento)
    //Todos los datos estan en la tabla PlanTratamientoDesc
    public class PlanTratamientoDescModel
    {
        private string ptObjetivo { get; set; }
        private string ptEstrategias { get; set; }
        private string ptMeta { get; set; }

        public PlanTratamientoDescModel()
        {

        }
    }
}
