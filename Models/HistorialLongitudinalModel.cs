using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido del segundo forulario
    //Todos los datos dentro de la tabla HistorialLongitudinal de la base de datos
    public class HistorialLongitudinalModel
    {
        public string cargoInternamiento { get; set; }
        public string diAcude { get; set; }
        public string diAcudeDesc { get; set; }
        public string diAfecta { get; set; }
        public string diTratamiento { get; set; }
        public string diTratamientoDesc { get; set; }

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public HistorialLongitudinalModel()
        {

        }
    }

}
