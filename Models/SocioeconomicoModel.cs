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
        private int ingresoSalario { get; set; } //Ingreso_Salario en tabla Socioeconomico
        private int pensionAlimenticia { get; set; } //PensionAlimenticia en tabla Socioeconomico
        private int egresoAgua { get; set; } //EgresoAgua en tabla Socioeconomico
        private int egresoElectricidad { get; set; } //EgresoElectricidad en tabla Socioeconomico
        private int egresoAlquier { get; set; } //EgresoAlquier en tabla Socioeconomico
        private int egresoTelefono { get; set; } //EgresoTelefono en tabla Socioeconomico
        private int Vivendia { get; set; } //Viviendia en tabla Socioeconomico
        private string otrosIngresosFamiliares { get; set; } //OtrosIngresosFamiliares en tabla Socioeconomico
        private int ingresosCapita { get; set; } //IngresosCapita en tabla Socioeconomico
        private int aporteEconomico { get; set; } //AporteEconomico en tabla Socioeconomico

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public SocioeconomicoModel()
        {
            
        }
    }

}
