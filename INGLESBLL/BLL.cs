using System;
using InglesDLL;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace InglesBLL
{
    
    public class BLL :BaseBusiness
    {
        DLL dll;
        #region CONSTRUCTOR
        public BLL()
        {
            dll = new DLL(_StringConexion, TypeDataBase.Firebird);
        }
        #endregion
        /// <summary>
        /// Registra las carreras 
        /// </summary>
        /// <param name="objNivel"></param>
        public void registrarCarrera(Carrera obj)
        {
            dll.insertCarrera(obj);
        }      
        /// <summary>
        /// LLeva acabo una inscripcion, que consiste en modificar el objeto curso
        /// agregandole un objeto alumno.
        /// </summary>
        /// <param name="objAlumno">representa el alumno que sera inscrito.</param>
        public void inscripcion(Curso objCurso)
        {
            
        }
        public void insertPeriodo(Periodo obj)
        {
            dll.insertPeriodo(obj);
        }
        public void updatePeriodo(Periodo obj)
        {
            dll.updatePeriodo(obj);
        }
        public List<Periodo> getPeriodos()
        {
           // return AutoMapper.Mapper.Map<List<ViewModelPeriodo>, List<Periodo>>(dll.getPeriodos());
            return dll.getPeriodos();
        }
        public List<Curso> getCursos()
        {
            return dll.getCursos();
        }     
        public List<Nivel> getCatNiveles()
        {
            return dll.getCatNiveles();
        }
        public List<Carrera> getCarreras()
        {
            return dll.getCarreras();
        }
        public List<Horario> getHorarios()
        {
            return dll.getHorarios();
        }
        public List<Docente> getDocentes()
        {
            return dll.getDocentes();
        }//pendiente        
        /// <summary>
        /// Obtiene el catalogo de calificaciones dispobibles para aplicar.
        /// </summary>
        /// <returns>Objetos calificacion.</returns>
        public List<Calificacion> getCalificaciones()
        {
            return dll.getCalificaciones();
        }//pendiente
        public List<Nivel> nivelesDisponibles(Periodo periodo)
        {
            List<Nivel> nx = new List<Nivel>();
            List<Nivel> niveles = getCatNiveles();
            List<Nivel> nivelesPeriodo = periodo.NIVELES;           
            
            var n = niveles.Except(nivelesPeriodo);

            foreach (Nivel item in n)
            {
                 nx.Add(item);
             }
            return nx;
        }
        public void actualizaNivelesPeriodo(Periodo obj)
        {
            dll.eliminaNivelesPeriodo(obj);
            dll.insertNivelesPeriodo(obj);
        }       

    }


}
