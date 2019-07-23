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
        private string esUsoCondon { get; set; }
        private string esMetodoPlanificacion { get; set; }
        private string esMotivoAnticonceptivos { get; set; }
        private string esSexoOral { get; set; }
        private string esSexoAnal { get; set; }
        private string esSentimientoHombreMujer { get; set; }
        private string esSentimientoHombreMujerDesc { get; set; }
        private string esRopaSexoOpuesto { get; set; }
        private string esGenitalesDesconocidos { get; set; }
        private string esFaltaDeseoSexual { get; set; }
        private string esMalestares { get; set; }
        private string esRelacionesDesconocidos { get; set; }
        private string esObjetosSexuales { get; set; }
        private string esMenoresEdad { get; set; }
        private string esRelacionesAnimales { get; set; }
        private string esLastimadoRelaciones { get; set; }
        private string esDisfuncionErectil { get; set; }
        private string esEyaculacionPrecoz { get; set; }
        private string esDificultadPenetrar { get; set; }
        private string esLubricacionGenital { get; set; }
        private string esOrientacionSexual { get; set; }
        private string esConsecuenciaDrogas { get; set; }
        private string esRechazoRelaciones { get; set; }
        private string esAusenciaPlacer { get; set; }
        private string esImaginacionSexual { get; set; }

        public HIElementosSexualesModel()
        {

        }
    }
}
