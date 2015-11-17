using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesBLL
{

    public class FormatDate
    {
        /// <summary>
        /// Devuelve l formato de la fecha en [dd/mm/aaaa]
        /// </summary>
        /// <param name="obj">Representa la estructura con la fecha a convertir.</param>
        /// <returns></returns>
        public static string DoConverFormato(DateTime obj)
        {
            return obj.ToString("d");
        }
    }

}
