using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIAntecedentesHIV
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIAntecedentesHIV
    { 
        private string hivTatuajes { get; set; }
        private string hivUsoJeringas { get; set; }
        private string hivPadeceSIDA { get; set; }
        private string hivHigenePersonal { get; set; }
        private string hivHigeneHabitacional { get; set; }
        private string hivProblemasAlimenticios { get; set; }
        private string hivProblemasAlimenticiosDesc { get; set; }
        private string hivTiempoLibre { get; set; }
        private string hivFrecuenciasActividades { get; set; }
        private string hivEntretenimiento { get; set; }

        public HIAntecedentesHIV()
        {

        }
    }
}
