using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIConsecuenciaConsumo
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIConsecuenciaConsumoModel
    { 
        public string ccConsumoAfectado { get; set; }
        public string ccConsumoAfectadoDesc { get; set; }
        public string ccAntecedentesFamiliares { get; set; }
        public string ccAntecedentesPersonales { get; set; }

        public HIConsecuenciaConsumoModel()
        {

        }
    }
}
