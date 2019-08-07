using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla ProyectoVidaModel
    public class ProyectoVidaModel
    {
        public string pvFortalezas { get; set; }
        public string pvOportunidades { get; set; }
        public string pvDebilidades { get; set; }
        public string pvAmenazas { get; set; }
        public string pvObjetivoVidaEgresar { get; set; }
        public string pvMetas { get; set; }
        public string pvTareas { get; set; }
        public string pvSeguimientoTratamiento { get; set; }
        public string pvTiempoLibre { get; set; }
        public string pvAcuerdosUltimaSesion { get; set; }

        public ProyectoVidaModel()
        {

        }
    }
}
