using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIPatronConsumo
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIPatronConsumoModel
    {
        public string pcLugarConsumo { get; set; }
        public string pcLugarConsumoDesc { get; set; }
        public string pcQuienesConsumo { get; set; }
        public string pcQuienesConsumoDesc { get; set; }
        public string pcMotivoConsumo { get; set; }
        public string pcMotivoConsumoDesc { get; set; }
        public string pcDrogasConsumidas { get; set; }
        public string pcFrecuenciaConsumo { get; set; }
        public string pcNivelConsumo { get; set; }
        public string pcDrogasUsdasUltimamente { get; set; }


        public HIPatronConsumoModel()
        {

        }
    }
}
