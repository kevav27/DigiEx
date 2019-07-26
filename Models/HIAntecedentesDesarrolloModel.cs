using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{

    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIAntecedenteDesarrollo
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIAntecedentesDesarrolloModel
    {
        private string adDesarrollo { get; set; }
        private string adDesarrolloDesc { get; set; }
        private string adOtros { get; set; }

        public HIAntecedentesDesarrolloModel()
        {

        }
    }
}
