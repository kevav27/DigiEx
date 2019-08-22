using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PersonController : PersonModel, IDataBaseMethods
    {

        public void addElement(object o)
        {
            PersonaModel persona = (PersonaModel)o;
            try
            {
                DBConectionController.con.Open();
                string query = "INSERT INTO dbo.Persona VALUES(Nombre = @nombrePaciente, " + 
                    "PrimerApellido = @primerApellido, " + 
                    "SegundoApellido = @segundoApellido" + 
                    "FechaNacimiento = @fechaNacimiento, " + 
                    "Cedula = @cedula, " + 
                    "Sexo = @sexo, " + 
                    "EstadoCivil = @estadoCivil, " + 
                    "Hijos = @hijos, " + 
                    "HijosCant = @hijosCant, " + 
                    "Ocupacion = @ocupacion, " + 
                    "Nacionalidad = @nacionalidad, " + 
                    "Procedencia = @procedencia, " + 
                    "FechaIngresoSistema = @fechaIngreso, " + 
                    "Estatura = @estatura, " + 
                    "Peso = @peso, " + 
                    "ColorCabello = @colorCabello, " + 
                    "ColorOjos = @colorOjos, " + 
                    "colorPiel = @colorPiel)";

                SqlCommand addPersona = new SqlCommand(query, DBConectionController.con);
                addPersona.Parameters.AddWithValue("nombrePaciente", persona.nombrePaciente);
                addPersona.Parameters.AddWithValue("primerApellido", persona.primerApellido);
                addPersona.Parameters.AddWithValue("segundoApellido", persona.segundoApellido);
                addPersona.Parameters.AddWithValue("fechaNacimiento", persona.fechaNacimiento);
                addPersona.Parameters.AddWithValue("cedula", persona.cedula);
                addPersona.Parameters.AddWithValue("sexo", persona.sexo);
                addPersona.Parameters.AddWithValue("estadoCivil", persona.estadoCivil);
                addPersona.Parameters.AddWithValue("hijos", persona.hijos);
                addPersona.Parameters.AddWithValue("hijosCant", persona.hijosCant);
                addPersona.Parameters.AddWithValue("ocupacion", persona.ocupacion);
                addPersona.Parameters.AddWithValue("nacionalidad", persona.nacionalidad);
                addPersona.Parameters.AddWithValue("procedencia", persona.procedencia);
                addPersona.Parameters.AddWithValue("fechaIngreso", persona.fechaIngreso);
                addPersona.Parameters.AddWithValue("estatura", persona.estatura);
                addPersona.Parameters.AddWithValue("peso", persona.peso);
                addPersona.Parameters.AddWithValue("colorCabello", persona.colorCabello);
                addPersona.Parameters.AddWithValue("colorOjos", persona.colorOjos);
                addPersona.Parameters.AddWithValue("colorPiel", persona.colorPiel);

                addPersona.ExecuteNonQuery();
                DBConectionController.con.Close();
            }catch(Exception e)
            {
                //Error
            }

        }

        public void editElement()
        {
            throw new NotImplementedException();
        }

        public void fetchElement()
        {
            throw new NotImplementedException();
        }

        public void findElement()
        {
            throw new NotImplementedException();
        }

        public void findElement(int id)
        {
            throw new NotImplementedException();
        }
    }

}
