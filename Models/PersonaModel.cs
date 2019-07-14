using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Todo los datos dentro de la tabla Persona
    public class PersonaModel
    {

        private string nombrePaciente { get; set; } //Nombre en tabla Persona
        private string primerApellido { get; set; } //PrimerApellido en tabla Persona
        private string segundoApellido { get; set; } //SegundoApellido en tabla Persona
        private DateTime fechaNacimiento { get; set; } //a fechaNacimiento debemos convertirla al formato correcto con: DateTime.Now.ToString ("formato deseado")
        private int cedula { get; set; } //tomar en cuenta que en la base de datos, la cedula es tipo NUMERIC
        private string sexo { get; set; } //Sexo en tabla Persona
        private string estadoCivil { get; set; } //EstadoCivil en tabla Persona
        private string hijos { get; set; } //Hijos en tabla Persona
        private int hijosCant { get; set; } //HijosCant en tabla Persona
        private string ocupacion { get; set; } //Ocupacion en tabla Persona
        private string nacionalidad { get; set; } //Nacionalidad en tabla Persona
        private DateTime fechaIngreso { get; set; } //en fechaIngreso se toma la fecha del sistema
        private float estatura { get; set; } //Estatura en tabla Persona
        private float peso { get; set; } //Peso e tabla Persona
        private string colorCabello { get; set; } //ColorCabello en tabla Persona
        private string colorOjos { get; set; } //ColorOjos en tabla Persona
        private string colorPiel { get; set; } //ColorPiel en tabla Persona

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public PersonaModel()
        {

        }
    }
}
