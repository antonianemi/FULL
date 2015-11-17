using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InglesEntity;

namespace InglesBLL
{


    /// <summary>
    /// This Builder Create An Object Horario For the use
    /// </summary>
    public class HorarioBuilder
    {   
        private Horario _Horario;
        /// <summary>
        /// 
        /// </summary>
        public HorarioBuilder()
        {
            _Horario = new Horario();
            _Horario.Dias = new List<Dia>();
        }
        /// <summary>
        /// Add a new course in 
        /// </summary>
        /// <param name="obj"></param>
        public void AddDias(Dia obj)
        {
            _Horario.Dias.Add(obj);
        }
        /// <summary>
        /// get the schedule.
        /// </summary>
        /// <returns></returns>
        public Horario getHorario()
        {
            return _Horario;
        }
    }


}
