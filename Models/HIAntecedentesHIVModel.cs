using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIAntecedentesHIV
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIAntecedentesHIVModel
    { 
        public string hivTatuajes { get; set; }
        public string hivUsoJeringas { get; set; }
        public string hivPadeceSIDA { get; set; }
        public string hivHigenePersonal { get; set; }
        public string hivHigeneHabitacional { get; set; }
        public string hivProblemasAlimenticios { get; set; }
        public string hivProblemasAlimenticiosDesc { get; set; }
        public string hivTiempoLibre { get; set; }
        public string hivFrecuenciasActividades { get; set; }
        public string hivEntretenimiento { get; set; }

        public HIAntecedentesHIVModel()
        {

        }
    }
}
