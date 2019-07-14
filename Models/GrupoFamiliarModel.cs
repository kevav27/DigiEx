using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido del primer forulario
    //Todos los datos dentro de la tabla GrupoFamiliar de la base de datos
    public class GrupoFamiliarModel
    {
        private string gfNombre { get; set; } //GFNombre en tabla GrupoFamiliar
        private string gfRelacion { get; set; } //GFRelacion en tabla GrupoFamiliar
        private string gfEscolaridad { get; set; } //GFEscolaridad en tabla GrupoFamiliar
        private string gfOcupacion { get; set; } //GFOcupacion en tabla GrupoFamiliar
        private string gfIngresos { get; set; }  //GFIngresos en tabla GrupoFamiliar

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public GrupoFamiliarModel()
        {

        }
    }

}
