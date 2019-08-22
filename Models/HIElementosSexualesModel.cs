using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIElementosSexuales
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIElementosSexualesModel
    {
        public string esUsoCondon { get; set; }
        public string esMetodoPlanificacion { get; set; }
        public string esMotivoAnticonceptivos { get; set; }
        public string esSexoOral { get; set; }
        public string esSexoAnal { get; set; }
        public string esSentimientoHombreMujer { get; set; }
        public string esSentimientoHombreMujerDesc { get; set; }
        public string esRopaSexoOpuesto { get; set; }
        public string esGenitalesDesconocidos { get; set; }
        public string esFaltaDeseoSexual { get; set; }
        public string esObservarRelaciones { get; set; }
        public string esMalestares { get; set; }
        public string esRelacionesDesconocidos { get; set; }
        public string esObjetosSexuales { get; set; }
        public string esMenoresEdad { get; set; }
        public string esRelacionesAnimales { get; set; }
        public string esLastimadoRelaciones { get; set; }
        public string esDisfuncionErectil { get; set; }
        public string esEyaculacionPrecoz { get; set; }
        public string esDificultadPenetrar { get; set; }
        public string esLubricacionGenital { get; set; }
        public string esOrientacionSexual { get; set; }
        public string esConsecuenciaDrogas { get; set; }
        public string esRechazoRelaciones { get; set; }
        public string esAusenciaPlacer { get; set; }
        public string esImaginacionSexual { get; set; }

        public HIElementosSexualesModel()
        {

        }
    }
}
