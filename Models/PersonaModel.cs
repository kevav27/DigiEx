using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    //Contenido en el primer y segundo formulario
    //Todo los datos dentro de la tabla Persona
    public class PersonaModel
    {
        public string nombrePaciente { get; set; } //Nombre en tabla Persona
        public string primerApellido { get; set; } //PrimerApellido en tabla Persona
        public string segundoApellido { get; set; } //SegundoApellido en tabla Persona
        public DateTime fechaNacimiento { get; set; } //a fechaNacimiento debemos convertirla al formato correcto con: DateTime.Now.ToString ("formato deseado")
        public int cedula { get; set; } //tomar en cuenta que en la base de datos, la cedula es tipo NUMERIC
        public string sexo { get; set; } //Sexo en tabla Persona
        public string estadoCivil { get; set; } //EstadoCivil en tabla Persona
        public string hijos { get; set; } //Hijos en tabla Persona
        public int hijosCant { get; set; } //HijosCant en tabla Persona
        public string ocupacion { get; set; } //Ocupacion en tabla Persona
        public string nacionalidad { get; set; } //Nacionalidad en tabla Persona
        public DateTime fechaIngreso { get; set; } //en fechaIngreso se toma la fecha del sistema
        public float estatura { get; set; } //Estatura en tabla Persona
        public float peso { get; set; } //Peso e tabla Persona
        public string colorCabello { get; set; } //ColorCabello en tabla Persona
        public string colorOjos { get; set; } //ColorOjos en tabla Persona
        public string colorPiel { get; set; } //ColorPiel en tabla Persona

        //falta agregar los queries dentro del constructor, agreagar cuando se conecte a la base de datos
        public PersonaModel()
        {

        }
    }
}
