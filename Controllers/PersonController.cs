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
        void IDataBaseMethods.addElement(object o)
        {
            throw new NotImplementedException();
        }

        void IDataBaseMethods.editElement(int id)
        {
            throw new NotImplementedException();
        }

        void IDataBaseMethods.fetchElement(string f)
        {
            throw new NotImplementedException();
        }

        void IDataBaseMethods.findElement(int id)
        {
            throw new NotImplementedException();
        }
    }
}
