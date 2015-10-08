using System;
using System.Data;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;

namespace InglesDLL
{

    public class DLL : BaseDLL 
    {
        /// <summary>
        /// Representa el contructor de dll del administrador.
        /// </summary>
        public DLL(string pstrConn, TypeDataBase pTypeDB) : base(pstrConn, pTypeDB)
        {

        }
        
        #region REGISTRADORES

        /// <summary>
        /// Registra Los niveles al periodo en cuestion.
        /// </summary>
        public void insertNivelesPeriodo(Periodo obj)
        {
            foreach(Nivel nivel in obj.NIVELES)
            {  this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_REGISTRA_NIVEL({0},'{1}','{2}','{3}','{4}',{5},'{6}',{7})", getPKNivel(), nivel.DESCRIPCION, nivel.MISION, nivel.VISION, nivel.OBJETIVO, nivel.STATUS, nivel.NIVEL, nivel.ID_PERIODO));
                if (this.ExistError)
                    throw new Exception(this.MessageError);                
            }
        }
        /// <summary>
        /// Registra una carrera.
        /// </summary>
        /// <param name="obj">Representa una carrera.</param>
        public void insertCarrera(Carrera obj)
        {   this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_REGISTRA_CARRERA({0},'{1}','{2}')", getPKCarrera(), obj.DESCRIPCION, obj.NOMBRE));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        /// <summary>
        /// Da de alta unnuevoperiodo en el sistema
        /// </summary>
        /// <param name="obj">representa los datos del periodo a insertar en el sistema.</param>
        public void insertPeriodo(Periodo obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_REGISTRA_PERIODO({0},'{1}','{2}',{3})", getPKPeriodo(), obj.PERIODO, obj.DESCRIPCION, obj.STATUS));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        /// <summary>
        /// Registra una nueva calificacion.
        /// </summary>
        /// <param name="obj">Representa la calificacion.</param>
        public void insertCalificacion(Calificacion obj)
        {   
            this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_REGISTRA_CARRERA({0},'{1}','{2}')", getPKCarrera(), obj.DESCRIPCION));
            if (this.ExistError)
                throw new Exception(this.MessageError);         
        }
        /// <summary>
        /// Registra una nueva asistencia en la base de datos.
        /// </summary>
        /// <param name="obj">Representa la asistencia que se registrara en la base de datos.</param>
        public void insertAsistencia(Asistencia obj)
        {   
            this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_REGISTRA_CARRERA({0},'{1}','{2}')", getPKCarrera()));
            if (this.ExistError)
                throw new Exception(this.MessageError);  
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void insertFuncion(Funcion obj)
        {
            this.ExecuteNonQuery(String.Format(""));
            if (this.ExistError)
                throw new Exception(this.MessageError); 
        }
        /// <summary>
        /// Registra un Curso.
        /// </summary>
        /// <param name="obj">Representa un Curso.</param>
        public void insertCurso(Curso obj)
        {
            this.ExecuteNonQuery(String.Format(""));
            if (this.ExistError)
                throw new Exception(this.MessageError); 
        }
        /// <summary>
        /// Registra una CuotaNivel.
        /// </summary>
        /// <param name="obj">Representa una CuotaNivel.</param>
        public void insertCuotanivel(CuotaNivel obj)
        {
            this.ExecuteNonQuery(String.Format(""));
            if (this.ExistError)
                throw new Exception(this.MessageError); 
        }
        /// <summary>
        /// Registra un docente.
        /// </summary>
        /// <param name="obj">Representa un Docente.</param>
        public void insertDocente(Docente obj)
        {
            this.ExecuteNonQuery(String.Format(""));
            if (this.ExistError)
                throw new Exception(this.MessageError); 
        }
        /// <summary>
        /// Inscribe un alumno en el curso especificado
        /// </summary>
        /// <param name="obj">Representa el curso con la informacion.</param>

        public void insertNew(Object obj)
        {
            this.ExecuteNonQuery(String.Format(""));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }


        #endregion

        #region ACTUALIZADORES
        public void updateNivel(Nivel obj)
        {
        }

        public void updatePeriodo(Periodo obj)
        {
            this.Query = String.Format("EXECUTE PROCEDURE SP_UPDATE_PERIODO ({0},'{1}','{2}')", obj.ID_PERIODO, obj.PERIODO, obj.DESCRIPCION);
            this.ExecuteNonQuery(this.Query);
            if (this.ExistError)
            {
                throw new Exception(this.MessageError);
            }
        }
        public void updateCarrera(Carrera obj)
        {
        }
        public void updateCalificacion(Calificacion obj)
        {
        }
        public void updateAsistencia(Asistencia obj)
        {
        }
        public void updateFuncion(Funcion obj)
        {
        }
        public void updateNivele(Nivel obj)
        {
        }
        public void updateCurso(Curso obj)
        {
        }
        public void updateCuotanivel(CuotaNivel obj)
        {
        }
        public void updateDocente(Docente obj)
        {
        }
        #endregion

        #region ELIMINADORES
        public void eliminaPeriodo(Periodo obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_CLEAN_PERIODOS"));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaNivel(Nivel obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }        
        public void eliminaCarrera(Carrera obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaCalificacion(Calificacion obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaAsistencia(Asistencia obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaFuncion(Funcion obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaNivele(Nivel obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaCurso(Curso obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaCuotanivel(CuotaNivel obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaDocente(Docente obj) 
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        public void eliminaNivelesPeriodo(Periodo obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE "));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }
        #endregion

        #region OBTENER LISTAS DE OBJETOS
        /// <summary>
        /// Obtiene la lista de cursos.
        /// </summary>
        /// <returns></returns>
        public List<Curso> getCursos()
        {
            IDataReader reader = this.ExecuteReader(String.Format("SELECT * FROM CURSOS"));
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Curso> objs = new List<Curso>();
            while (reader.Read())
            {   objs.Add( new Curso(){
                ID_ALUMNO = Convert.ToInt32(reader["ID_ALUMNO"]),
                ID_CALIFICACION = Convert.ToInt32(reader["ID_CALIFICACION"]),
                ID_CURSO = Convert.ToInt32(reader["ID_CURSO"]),
                ID_HORARIO = Convert.ToInt32(reader["ID_HORARIO"]),
                ID_NIVEL = Convert.ToInt32(reader["ID_NIVEL"]),
                ID_PERIODO = Convert.ToInt32(reader["ID_PERIODO"])
            });
            }
            return objs;

        }
        /// <summary>
        /// Obtiene la lista de niveles
        /// </summary>
        /// <returns></returns>
        public List<Nivel> getCatNiveles()
        {            
            IDataReader reader = this.ExecuteReader(String.Format("SELECT * FROM CAT_NIVELES WHERE ID_NIVEL <> 0"));
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Nivel> objs = new List<Nivel>();
            while (reader.Read())
            {
                objs.Add(new Nivel(){
                ID_NIVEL = Convert.ToInt32(reader["ID_NIVEL"]),
                NIVEL = reader["NIVEL"].ToString(),
                DESCRIPCION = reader["DESCRIPCION"].ToString(),
                MISION = reader["MISION"].ToString(),
                OBJETIVO = reader["OBJETIVO"].ToString(),
                VISION = reader["VISION"].ToString()
            });
            }
            return objs;
        }
        /// <summary>
        /// Obtiene la lista de niveles, del periodo indicado.
        /// </summary>
        /// <returns></returns>
        public List<Nivel> getNivelesPeriodo(int obj)
        {            
            IDataReader reader = this.ExecuteReader(String.Format("SELECT * FROM CAT_NIVELES WHERE ID_NIVEL <> 0"));
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Nivel> objs = new List<Nivel>();
            while (reader.Read())
            {objs.Add(new Nivel()
                    {
                        ID_NIVEL = Convert.ToInt32(reader["ID_NIVEL"]),
                        NIVEL = reader["NIVEL"].ToString(),
                        DESCRIPCION = reader["DESCRIPCION"].ToString(),
                        MISION = reader["MISION"].ToString(),
                        OBJETIVO = reader["OBJETIVO"].ToString(),
                        VISION = reader["VISION"].ToString()
                    }
            );
            }
            return objs;
        }
        /// <summary>
        /// Obtiene la lista de carreras.
        /// </summary>
        /// <returns></returns>
        public List<Carrera> getCarreras()
        {     
            this.Query = String.Format("SELECT * FROM CAT_CARRERAS");
            IDataReader reader = this.ExecuteReader(this.Query);
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Carrera> objs = new List<Carrera>();
            while (reader.Read())
            {
             objs.Add(new Carrera(){
                ID_CARRERA = Convert.ToInt32(reader["ID_CARRERA"]),
                NOMBRE = reader["NOMBRE"].ToString(),
                DESCRIPCION = reader["DESCRIPCION"].ToString()
            });
            }
            return objs;
        }
       
        /// <summary>
        /// Obtiene la lista de priodos, y sus niveles asignados del mismo.
        /// </summary>
        /// <returns>lista de objetos periodos.</returns>
        public List<Periodo> getPeriodos()
        {            
            IDataReader reader = this.ExecuteReader(String.Format("SELECT * FROM PERIODOS WHERE ID_PERIODO <> 0"));
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Periodo> objs = new List<Periodo>();
            while (reader.Read())
            {
                Periodo obj = new Periodo();                
                obj.ID_PERIODO = Convert.ToInt32(reader["ID_PERIODO"]);
                obj.DESCRIPCION = reader["DESCRIPCION"].ToString().ToUpperInvariant();
                obj.PERIODO = reader["PERIODO"].ToString().ToUpperInvariant();
                obj.NIVELES = getNivelesPeriodo(Convert.ToInt32(reader["ID_PERIODO"]));
                switch(Convert.ToInt32(reader["STATUS"].ToString())){
                    case 0:
                        obj.STATUS = estatusPeriodo.Baja;
                        break;
                    
                    case 1:
                        obj.STATUS = estatusPeriodo.Activo;
                        break;

                    case 2:
                        obj.STATUS = estatusPeriodo.Inactivo;
                        break;                
                }
                objs.Add(obj);            
            }
            return objs;
        }
        /// <summary>
        /// Obtiene la lista de horarios de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Horario> getHorarios()
        {   
            IDataReader reader = this.ExecuteReader(String.Format("SELECT * FROM HORARIOS"));
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Horario> objs = new List<Horario>();
            while (reader.Read())
            {                   
                objs.Add(new Horario(){
                ID_HORARIO = Convert.ToInt32(reader["ID_HORARIO"]),
                DESCRIPCION = reader["DESCRIPCION"].ToString(),
                FECHA = reader["FECHA"].ToString(),
                HORA_FIN = reader["HORA_FIN"].ToString(),
                HORA_INI = reader["HORA_INI"].ToString()});
            }
            return objs;
        }
        /// <summary>
        /// Obtiene la lista de docentes de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Docente> getDocentes()
        {
            IDataReader reader = this.ExecuteReader(String.Format("SELECT * FROM DOCENTES"));
            List<Docente> objs = new List<Docente>();
            if (this.ExistError)
                throw new Exception(this.MessageError);
            while (reader.Read())
            {
                objs.Add(new Docente(){
                ID_DOCENTE = Convert.ToInt32(reader["ID_DOCENTE"]),
                APELLIDO_MATERNO = reader[""].ToString(),
                APELLIDO_PATERNO = reader[""].ToString(),
                CURP = reader[""].ToString(),
                RFC = reader[""].ToString(),
                NOMBRE = reader[""].ToString(),
                ID_PERSONA = Convert.ToInt32(reader[""].ToString()),
                FECHANACIMIENTO = reader[""].ToString()
            });
            }
            return objs;
        }//pendiente
        /// <summary>
        /// Obtiene el catalogo de calificaciones dispobibles para aplicar.
        /// </summary>
        /// <returns>Objetos calificacion.</returns>
        public List<Calificacion> getCalificaciones()
        {   
            this.Query = String.Format("SELECT * FROM CAT_CALIFICACIONES");
            IDataReader reader = this.ExecuteReader(this.Query);
            if (this.ExistError)
                throw new Exception(this.MessageError);
            List<Calificacion> objs = new List<Calificacion>();
            while (reader.Read())
            {
                objs.Add(new Calificacion(){
                ID_CALIFICACION = Convert.ToInt32(reader["ID_CALIFICACION"]),
                CALIFICACION = reader["CALIFICACION"].ToString(),
                DESCRIPCION = reader["DESCRIPCION"].ToString()
            });
            }
            return objs;
        }//pendiente
        #endregion

        #region BUSQUEDAS DE OBJETOS PERSONALIZADOS
        /// <summary>
        /// Obtiene la lista de niveles
        /// </summary>
        /// <returns>
        /// DEvuelve los niveles correspondientes al periodo indicado
        /// </returns>
        public List<Nivel> getNivelesPeriodoById(Periodo obj)
        {
            List<Nivel> niveles = new List<Nivel>();
            this.Query = String.Format("SELECT ID_NIVEL FROM PERIODOS WHERE ID_PERIODO = {0}", obj.ID_PERIODO);            
            IDataReader r = this.ExecuteReader(this.Query);
            
            while (r.Read())
            {
                this.Query = String.Format("SELECT * FROM NIVELES WHERE ID_NIVEL IN ({0})", r[""].ToString());
                IDataReader reader = this.ExecuteReader(this.Query);
                if (this.ExistError)
                {
                    //this.MessageError;
                }
                while (reader.Read())
                {
                    Nivel nivel = new Nivel();
                    nivel.ID_NIVEL = Convert.ToInt32(reader["ID_NIVEL"]);
                    nivel.NIVEL = reader["NIVEL"].ToString();
                    nivel.DESCRIPCION = reader["DESCRIPCION"].ToString();
                    nivel.MISION = reader["MISION"].ToString();
                    nivel.OBJETIVO = reader["OBJETIVO"].ToString();
                    nivel.VISION = reader["VISION"].ToString();
                    niveles.Add(nivel);
                }
            }
           
            
            return niveles;
        }
        #endregion

        #region OBTENER CLAVES PRIMARIAS
        private int getPKNivel(){
            this.Query = String.Format("SELECT ID_NIVEL FROM CAT_NIVELES ORDER BY ID_NIVEL DESC");
            int num = Convert.ToInt32(this.ExecuteScalar(this.Query)) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKPeriodo()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_PERIODO FROM PERIODOS ORDER BY ID_PERIODO DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKCarrera()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_CARRERA FROM CAT_CARRERAS ORDER BY ID_CARRERA DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKCalificacion()
        {   
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_CALIFICACION FROM CALIFICACIONES ORDER BY ID_CALIFICACION DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKAsistencias()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_ASISTENCIA FROM ASISTENCIAS ORDER BY ID_ASISTENCIA DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKFunciones()
        {   
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_FUNCION FROM FUNCION ORDER BY ID_FUCION DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKNiveles()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_NIVEL FROM NIVELES ORDER BY ID_NIVEL DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKCursos()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_ALUMNO FROM ALUMNO ORDER BY ID_ALUMNO DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKCuotanivel()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_CUOTA FROM CUOTASNIVEL ORDER BY ID_CUOTA DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        private int getPKDocente()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_DOCENTE FROM DOCENTE ORDER BY ID_DOCENTE DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }
        #endregion

    }
}
