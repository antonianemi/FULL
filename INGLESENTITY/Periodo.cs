using System;
using System.Collections.Generic;

namespace InglesEntity
{
    public class Periodo
    {

        /// <summary>
        /// Representa el id de este periodo.
        /// </summary>
        public int ID_PERIODO
        {
            set; get;
        }
        /// <summary>
        /// Representa la descripcion de este periodo.
        /// </summary>
        public string DESCRIPCION
        {
            set; get;
        }
        /// <summary>
        /// Representa el periodo
        /// </summary>
        public string PERIODO
        {
            set; get;
        }
        /// <summary>
        /// Representa el status del periodo
        /// </summary>
        public estatusPeriodo STATUS
        {
            set; get;
        }
    }
}
