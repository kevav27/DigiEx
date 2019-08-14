using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido del primer forulario
    //Todos los datos dentro de la tabla Socioeconomico de la base de datos
    public class SocioeconomicoModel
    {
        public int ingresoSalario { get; set; } //Ingreso_Salario en tabla Socioeconomico
        public int pensionAlimenticia { get; set; } //PensionAlimenticia en tabla Socioeconomico
        public int egresoAgua { get; set; } //EgresoAgua en tabla Socioeconomico
        public int egresoElectricidad { get; set; } //EgresoElectricidad en tabla Socioeconomico
        public int egresoAlquier { get; set; } //EgresoAlquier en tabla Socioeconomico
        public int egresoTelefono { get; set; } //EgresoTelefono en tabla Socioeconomico
        public int Vivendia { get; set; } //Viviendia en tabla Socioeconomico
        public string otrosIngresosFamiliares { get; set; } //OtrosIngresosFamiliares en tabla Socioeconomico
        public int ingresosCapita { get; set; } //IngresosCapita en tabla Socioeconomico
        public int aporteEconomico { get; set; } //AporteEconomico en tabla Socioeconomico

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public SocioeconomicoModel()
        {
            
        }
    }

}
