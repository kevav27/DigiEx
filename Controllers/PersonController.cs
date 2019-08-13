using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigiEx.Models;

namespace DigiEx.Controllers
{
    public class PersonController : PersonaModel, IDataBaseMethods
    {
        public void addElement()
        {
            
        }

        public void addElement(object o)
        {
            throw new NotImplementedException();
        }

        public void editElement()
        {
            throw new NotImplementedException();
        }

        public void editElement(int id)
        {
            throw new NotImplementedException();
        }

        public void fetchElement()
        {
            throw new NotImplementedException();
        }

        public void fetchElement(string f)
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
