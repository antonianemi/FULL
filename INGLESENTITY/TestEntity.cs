using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InglesEntity
{


    /// <summary>
    /// in this class you can see all implements of entitys wiht your information.
    /// </summary>
    public static class TestEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public static List<OpcionMenu> getTodosMenus()
        {
            return new List<OpcionMenu>()
            {
                  new OpcionMenu() { IdMenu=1, DescripcionMenu = "Registrar Alumno" },
                  new OpcionMenu() { IdMenu=2, DescripcionMenu = "Actualizar Informacion Alumno" },
                  new OpcionMenu() { IdMenu=3, DescripcionMenu = "Actualizar Estatus Alumno" },
                  new OpcionMenu() { IdMenu=4, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=5, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=6, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=7, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=8, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=9, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=10, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=11, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=12, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=13, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=14, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=15, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=16, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=17, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=18, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=19, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=20, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=21, DescripcionMenu = "" },
                  new OpcionMenu() { IdMenu=22, DescripcionMenu = "" },
            };

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        public static List<OpcionMenu> getMenusByRol(int rol)
        {
            List<OpcionMenu> objs = new List<OpcionMenu>();

            switch (rol)
            {

                case 1:
                    objs.Add(new OpcionMenu() { IdMenu = 1, DescripcionMenu = "Registrar Alumno"               });
                    objs.Add(new OpcionMenu() { IdMenu = 2, DescripcionMenu = "Actualizar Informacion Alumno"  });
                    objs.Add(new OpcionMenu() { IdMenu = 3, DescripcionMenu = "Actualizar Estatus Alumno"      });
                    objs.Add(new OpcionMenu() { IdMenu = 4, DescripcionMenu = "Registrar Docente"              });
                    objs.Add(new OpcionMenu() { IdMenu = 5, DescripcionMenu = "Actualizar Informacion Docente" });
                    objs.Add(new OpcionMenu() { IdMenu = 6, DescripcionMenu = "Actualizar Estatus Docente"     });
                    objs.Add(new OpcionMenu() { IdMenu = 7, DescripcionMenu = "Registrar Usuario"              });
                    objs.Add(new OpcionMenu() { IdMenu = 8, DescripcionMenu = "Actualizar Informacion Usuario" });
                    objs.Add(new OpcionMenu() { IdMenu = 9, DescripcionMenu = "Actualizar Estatus Usuario"     });
                    break;

                case 2:
                    objs.Add(new OpcionMenu() { IdMenu = 2, DescripcionMenu = "Actualizar Informacion Alumno"  });
                    objs.Add(new OpcionMenu() { IdMenu = 3, DescripcionMenu = "Actualizar Estatus Alumno"      });
                    objs.Add(new OpcionMenu() { IdMenu = 5, DescripcionMenu = "Actualizar Informacion Docente" });
                    objs.Add(new OpcionMenu() { IdMenu = 6, DescripcionMenu = "Actualizar Estatus Docente"     });
                    objs.Add(new OpcionMenu() { IdMenu = 8, DescripcionMenu = "Actualizar Informacion Usuario" });
                    objs.Add(new OpcionMenu() { IdMenu = 9, DescripcionMenu = "Actualizar Estatus Usuario"     });
                    break;

                case 3:
                    objs.Add(new OpcionMenu() { IdMenu = 3, DescripcionMenu = "Actualizar Estatus Alumno"      });
                    objs.Add(new OpcionMenu() { IdMenu = 6, DescripcionMenu = "Actualizar Estatus Docente"     });
                    objs.Add(new OpcionMenu() { IdMenu = 9, DescripcionMenu = "Actualizar Estatus Usuario"     });
                    break;
            }
            return objs;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> getUsers()
        {
            return new List<Usuario>()
            {
                new Usuario() {  Nombre="A", ApellidoPaterno="AA", ApellidoMaterno="AA", Curp="ABC123465BCDEFGHIJK", Rfc ="ABC123465BCD", Edad="20", PathFoto="C:Photos" }
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Curso> getCurso()
        {
            return new List<Curso>()
            {
                //new Curso() { ID_CURSO=1, ID_ALUMNO=1, ID_NIVEL=1,ID_PERIODO=1, ID_CALIFICACION=1, ID_HORARIO=1},
                //new Curso() { ID_CURSO=2, ID_ALUMNO=2, ID_NIVEL=2,ID_PERIODO=2, ID_CALIFICACION=2, ID_HORARIO=2},
                //new Curso() { ID_CURSO=3, ID_ALUMNO=3, ID_NIVEL=3,ID_PERIODO=3, ID_CALIFICACION=3, ID_HORARIO=4},
                //new Curso() { ID_CURSO=4, ID_ALUMNO=4, ID_NIVEL=4,ID_PERIODO=4, ID_CALIFICACION=4, ID_HORARIO=4},
                //new Curso() { ID_CURSO=5, ID_ALUMNO=5, ID_NIVEL=5,ID_PERIODO=5, ID_CALIFICACION=5, ID_HORARIO=5},
                //new Curso() { ID_CURSO=6, ID_ALUMNO=6, ID_NIVEL=6,ID_PERIODO=6, ID_CALIFICACION=6, ID_HORARIO=6},
                //new Curso() { ID_CURSO=7, ID_ALUMNO=7, ID_NIVEL=7,ID_PERIODO=7, ID_CALIFICACION=7, ID_HORARIO=7}
            };
        }//fin del metodo estatico
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Curso Curso()
        {
            return new Curso() { ID_CURSO = 1, ALUMNOS = getAlumnos(), DESCRIPCION = "", DOCENTE = getDocentes().SingleOrDefault(), HORARIO = null, NIVEL = getNiveles().SingleOrDefault(), PERIODO = getPeriodos().SingleOrDefault() };
        }//fin del metodo
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Docente> getDocentes()
        {
            return new List<Docente>()
            {
                new Docente() {ID_DOCENTE=1, ID_PERSONA=1, NOMBRE="Arnold", APELLIDO_PATERNO="Martinez", APELLIDO_MATERNO="Martinez", RFC="MAMA910821HV", CURP="MAMA910821HVZRRR04", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=2, ID_PERSONA=2, NOMBRE="Alan", APELLIDO_PATERNO="Benites", APELLIDO_MATERNO="Hiram", RFC="HIBEA873645JV", CURP="HIBEA873015JVRTHG01", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=3, ID_PERSONA=3, NOMBRE="Anabeth", APELLIDO_PATERNO="Hernandez", APELLIDO_MATERNO="Lara", RFC="HELAA100865KR", CURP="HELAA800825KRTYHN04", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=4, ID_PERSONA=4, NOMBRE="Antonio", APELLIDO_PATERNO="Cortez", APELLIDO_MATERNO="Lagunes", RFC="COLAA030767CV", CURP="COLAA701107CVBMRN03", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=5, ID_PERSONA=5, NOMBRE="Anibal", APELLIDO_PATERNO="Marin", APELLIDO_MATERNO="Gaona", RFC="MAGOA311285JK", CURP="MAGOA811205JKLYTG04", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=6, ID_PERSONA=6, NOMBRE="Rosa", APELLIDO_PATERNO="Gil", APELLIDO_MATERNO="Gomez", RFC="GIGOR151080ASD", CURP="GIGOR751008ASDTRA01", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=7, ID_PERSONA=7, NOMBRE="Sara", APELLIDO_PATERNO="Blasco", APELLIDO_MATERNO="Salcedo", RFC="BLSAS251192QW", CURP="BLSAS831102QWPRZC02", FECHANACIMIENTO="20/04/1991" },
                new Docente() {ID_DOCENTE=8, ID_PERSONA=8, NOMBRE="Juan", APELLIDO_PATERNO="Contreras", APELLIDO_MATERNO="Hernandez", RFC="COHEJ111190BNX", CURP="COHEJ911109BNXPERTGC03", FECHANACIMIENTO="20/04/1991" }
            };
        }//fin del metodo statico
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Alumno> getAlumnos()
        {
            return new List<Alumno>() {
         new Alumno() { ID_PERSONA = 1, ID_ALUMNO = 1, NOMBRE = "Antonio de Jesus", APELLIDO_PATERNO = "cortes", APELLIDO_MATERNO = "Lopez", NO_CONTROL = "092T0101", CARRERA = "Ingenieria en sistemas computacionales", RFC = "HEMEM900410FF", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 2, ID_ALUMNO = 2, NOMBRE = "Pedro Antonio", APELLIDO_PATERNO = "Gutierrez", APELLIDO_MATERNO = "Martinez", NO_CONTROL = "092T0102", CARRERA = "Ingenieria Ambiental", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 3, ID_ALUMNO = 3, NOMBRE = "Mario", APELLIDO_PATERNO = "Sambrano", APELLIDO_MATERNO = "Gonzales", NO_CONTROL = "092T0103", CARRERA = "Ingenieria en Sistemas Computacionales", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 4, ID_ALUMNO = 4, NOMBRE = "Ramon", APELLIDO_PATERNO = "Medina", APELLIDO_MATERNO = "Rodriguez", NO_CONTROL = "092T0104", CARRERA = "Ingenieria Bioquimica", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 5, ID_ALUMNO = 5, NOMBRE = "Roberto", APELLIDO_PATERNO = "Patino", APELLIDO_MATERNO = "Lopez", NO_CONTROL = "092T0105", CARRERA = "Ingenieria en sistemas computacionales", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 6, ID_ALUMNO = 6, NOMBRE = "Miguel", APELLIDO_PATERNO = "Marcial", APELLIDO_MATERNO = "Perez", NO_CONTROL = "092T0106", CARRERA = "Ingenieria Bioquimica", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 7, ID_ALUMNO = 7, NOMBRE = "Dario", APELLIDO_PATERNO = "Romero", APELLIDO_MATERNO = "Alonso", NO_CONTROL = "092T0107", CARRERA = "Ingenieria en sistemas computacionales", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 8, ID_ALUMNO = 8, NOMBRE = "Fernando", APELLIDO_PATERNO = "Sementeras", APELLIDO_MATERNO = "Gil", NO_CONTROL = "092T0108", CARRERA = "Ingenieria Ambiental", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 9, ID_ALUMNO = 9, NOMBRE = "Rogelio", APELLIDO_PATERNO = "Hernandez", APELLIDO_MATERNO = "Ramos", NO_CONTROL = "092T0109", CARRERA = "Ingenieria Industrial", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 10, ID_ALUMNO = 10, NOMBRE = "Maria", APELLIDO_PATERNO = "Diaz", APELLIDO_MATERNO = "Mendez", NO_CONTROL = "092T0110", CARRERA = "Ingenieria en Electromecanica", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 11, ID_ALUMNO = 11, NOMBRE = "Rosalba", APELLIDO_PATERNO = "Moreno", APELLIDO_MATERNO = "Serrano", NO_CONTROL = "092T0111", CARRERA = "Ingenieria en sistemas computacionales", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 12, ID_ALUMNO = 12, NOMBRE = "Merlin", APELLIDO_PATERNO = "Torres", APELLIDO_MATERNO = "Blanco", NO_CONTROL = "092T0112", CARRERA = "Ingenieria Bioquimica", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
         new Alumno() { ID_PERSONA = 13, ID_ALUMNO = 13, NOMBRE = "Martin", APELLIDO_PATERNO = "Navarro", APELLIDO_MATERNO = "Mendez", NO_CONTROL = "092T0113", CARRERA = "Ingenieria en sistemas computacionales", RFC = "HEMEM900410FFTGTF01", CURP = "HEMEM900410FFTGTF01", FECHANACIMIENTO = "20/04/1991" },
        };
        }//fin del metodo 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Nivel> getNiveles()
        {
            return new List<Nivel>()
            {
                new Nivel() { ID_NIVEL = 1, NIVEL = "NIVEL 1", MISION = "Enseñar al aprendis los elementos teoricos basicos", OBJETIVO = "Superar ambitos generales y basicos", VISION = "Ver al alumno reflejado y motivado por la lengua", STATUS = 1, DESCRIPCION = "Nivel 1" },
                new Nivel() { ID_NIVEL = 2, NIVEL = "NIVEL 2", MISION = "Enseñar al aprendis los elementos teoricos basicos", OBJETIVO = "Superar ambitos generales y basicos", VISION = "Ver al alumno reflejado y motivado por la lengua", STATUS = 1, DESCRIPCION = "Nivel 2" },
                new Nivel() { ID_NIVEL = 3, NIVEL = "NIVEL 3", MISION = "Enseñar al aprendis los elementos teoricos basicos", OBJETIVO = "Superar ambitos generales y basicos", VISION = "Ver al alumno reflejado y motivado por la lengua", STATUS = 1, DESCRIPCION = "Nivel 3" },
                new Nivel() { ID_NIVEL = 4, NIVEL = "NIVEL 4", MISION = "Enseñar al aprendis los elementos teoricos basicos", OBJETIVO = "Superar ambitos generales y basicos", VISION = "Ver al alumno reflejado y motivado por la lengua", STATUS = 1, DESCRIPCION = "Nivel 4" },
                new Nivel() { ID_NIVEL = 5, NIVEL = "NIVEL 5", MISION = "Enseñar al aprendis los elementos teoricos basicos", OBJETIVO = "Superar ambitos generales y basicos", VISION = "Ver al alumno reflejado y motivado por la lengua", STATUS = 1, DESCRIPCION = "Nivel 5" },
                new Nivel() { ID_NIVEL = 6, NIVEL = "NIVEL 6", MISION = "Enseñar al aprendis los elementos teoricos basicos", OBJETIVO = "Superar ambitos generales y basicos", VISION = "Ver al alumno reflejado y motivado por la lengua", STATUS = 1, DESCRIPCION = "Nivel 6" },
            };
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Periodo> getPeriodos()
        {
            return new List<Periodo>()
            {
                new Periodo() { ID_PERIODO=1, PERIODO="PERIODO 1", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 1" },
                new Periodo() { ID_PERIODO=2, PERIODO="PERIODO 2", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 2" },
                new Periodo() { ID_PERIODO=3, PERIODO="PERIODO 3", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 3" },
                new Periodo() { ID_PERIODO=4, PERIODO="PERIODO 4", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 4" },
                new Periodo() { ID_PERIODO=5, PERIODO="PERIODO 5", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 5" },
                new Periodo() { ID_PERIODO=6, PERIODO="PERIODO 6", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 6" },
                new Periodo() { ID_PERIODO=7, PERIODO="PERIODO 7", STATUS=estatusPeriodo.Activo, DESCRIPCION="Periodo 7" }
            };
        }//fin del metodo 
    }


}
