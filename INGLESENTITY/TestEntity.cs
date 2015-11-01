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


    }


}
