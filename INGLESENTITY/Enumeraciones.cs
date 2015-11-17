using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{
    public enum STATUSSESSION
    {
        /// <summary>
        /// Representa el status abierto de una session.
        /// </summary>
        Open=1,
        /// <summary>
        /// Representa el status cerrado de una session.
        /// </summary>
        Close = 2

    }
    public enum estatusPeriodo
    {
        Activo=1,
        Inactivo=2,
            Baja=3
    }

    public enum DIAS
    {
        LUNES=1,
        MARTES=2,
        MIERCOLES=3,
        JUEVES=4,
        VIERNES=5,
        SABADO=6,
        DOMINGO=7
    }

    public enum TIPOALUMNO
    {
        Interno = 1,
        InternoNuevoIngreso = 2,
        Foraneo = 3,
        ForaneoNuevoIngreso = 5
    }


}
