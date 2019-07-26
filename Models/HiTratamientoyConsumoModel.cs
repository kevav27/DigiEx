using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HITratameintoyConsumo
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HITratamientoyConsumoModel
    {
        private string tcRecibidoTratamiento { get; set; }
        private string tcRecibidoTratamientoDesc { get; set; }
        private string tcAtendieron { get; set; }
        private string tcAtendieronDesc { get; set; }
        private string tcCompletoTratamiento { get; set; }
        private string tcCompletoTratamientoDesc { get; set; }
        private string tcTratamientoAntes { get; set; }
        private string tcConsultasDrogas { get; set; }
        private string tcInterrumpidoConsumo { get; set; }
        private string tcInterrumpidoConsumoDesc { get; set; }
        private string tcMotivoInterrupcion { get; set; }
        private string tcMotivoInterrupcionDesc { get; set; }
        private string tcActitudPareja { get; set; }
        private string tcActitudFamilia { get; set; }
        private string tcTrabajo_CentroEducativo { get; set; }
        private string tcTrabajo_CentroEducativoDesc { get; set; }
        private string tcActitudCompaneros { get; set; }

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public HITratamientoyConsumoModel()
        {

        }
    }
}
