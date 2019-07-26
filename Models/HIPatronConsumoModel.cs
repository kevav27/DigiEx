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
        private string pcLugarConsumo { get; set; }
        private string pcLugarConsumoDesc { get; set; }
        private string pcQuienesConsumo { get; set; }
        private string pcQuienesConsumoDesc { get; set; }
        private string pcMotivoConsumo { get; set; }
        private string pcMotivoConsumoDesc { get; set; }
        private string pcDrogasConsumidas { get; set; }
        private string pcFrecuenciaConsumo { get; set; }
        private string pcNivelConsumo { get; set; }
        private string pcDrogasUsdasUltimamente { get; set; }


        public HIPatronConsumoModel()
        {

        }
    }
}
