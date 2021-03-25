using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Filters
{
    public class FilterDesktop
    {
        
        public static List<T> Filter<T>(List<T> entities, string filter)
        {
            List<T> listVacia = new List<T>();
            var propierties = typeof(T).GetProperties();
            foreach (var esp in entities)
            {
                foreach (var propierty in propierties)
                {
                    if (typeof(Especialidad).GetProperty(propierty.Name).GetValue(esp, null) != null && typeof(Especialidad).GetProperty(propierty.Name).GetValue(esp, null).ToString().ToLower().Contains(filter))
                    {
                        listVacia.Add(esp);
                        break;
                    }
                }
            }
            return listVacia;
        }
   
    }
}
