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
        public string tcRecibidoTratamiento { get; set; }
        public string tcRecibidoTratamientoDesc { get; set; }
        public string tcAtendieron { get; set; }
        public string tcAtendieronDesc { get; set; }
        public string tcCompletoTratamiento { get; set; }
        public string tcCompletoTratamientoDesc { get; set; }
        public string tcTratamientoAntes { get; set; }
        public string tcConsultasDrogas { get; set; }
        public string tcInterrumpidoConsumo { get; set; }
        public string tcInterrumpidoConsumoDesc { get; set; }
        public string tcMotivoInterrupcion { get; set; }
        public string tcMotivoInterrupcionDesc { get; set; }
        public string tcActitudPareja { get; set; }
        public string tcActitudFamilia { get; set; }
        public string tcTrabajo_CentroEducativo { get; set; }
        public string tcTrabajo_CentroEducativoDesc { get; set; }
        public string tcActitudCompaneros { get; set; }

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public HITratamientoyConsumoModel()
        {

        }


    }
}
