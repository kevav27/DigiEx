using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIPatronConsumo
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIConsecuenciaConsumoModel
    { 
        private string ccConsumoAfectado { get; set; }
        private string ccConsumoAfectadoDesc { get; set; }
        private string ccAntecedentesFamiliares { get; set; }
        private string ccAntecedentesPersonales { get; set; }

        public HIConsecuenciaConsumoModel()
        {

        }
    }
}
