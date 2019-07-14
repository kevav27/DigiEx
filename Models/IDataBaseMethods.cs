using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiEx.Models
{
    interface IDataBaseMethods
    {
        void addElement(Object o); //que le ingrese un modelo por parámetro
        void editElement(int id);
        void findElement(int id);
        void fetchElement(string f);
    }
}
