using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido del segundo forulario
    //Todos los datos dentro de la tabla HistorialLongitudinal de la base de datos
    public class HistorialLongitudinal
    {
        private string cargoInternamiento { get; set; }
        private string diAcude { get; set; }
        private string diAcudeDesc { get; set; }
        private string diAfecta { get; set; }
        private string diTratamiento { get; set; }
        private string diTratamientoDesc { get; set; }

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public HistorialLongitudinal()
        {

        }
    }

}
