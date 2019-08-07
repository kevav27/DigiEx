using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido encontrado en el segundo formulario
    //Todos los datos estan en la tabla HIAntecedentesSexuales
    //Todos las variables con terminacion Desc pueden ser nulas dependiendo de la respuesta de su contra parte
    public class HIAntecedentesSexualesModel
    {
    public string asInformacionSexual { get; set; }
    public string asRelacionesSexuales { get; set; }
    public string asPrimerContacto { get; set; }
    public string asMasturbacionAdolescencia { get; set; }
    public string asActualmenteMasturba { get; set; }
    public string asPrimeraPareja { get; set; }
    public string asAbusadoSexualmente { get; set; }
    public string asTemorRelaciones { get; set; }
    public string asActoSexual { get; set; }
    public string asPracticoSexual { get; set; }
    public string asPreferencialSexual { get; set; }
    public string asSexoBajoDrogas { get; set; }
    public string asRelacionesIncestuosas { get; set; }
    public string asRelacionesIncestuosasDesc { get; set; }

        public HIAntecedentesSexualesModel()
        {

        }
    }

}
