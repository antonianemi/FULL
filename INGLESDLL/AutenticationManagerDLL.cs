using System;
using System.Data;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;

namespace InglesDLL
{
    public class AutenticationManagerDLL : BaseLayerDLL
    {
        /// <summary>
        /// Representa el contructor de dll del administrador.
        /// </summary>
        public AutenticationManagerDLL(string pstrConn, TypeDataBase pTypeDB) : base(pstrConn, pTypeDB)
        {

        }

        

        /// <summary>
        /// En caro de que sea una sesion valida Registrar esa sesion en la base de datos.
        /// con la fecha y hora. y retornar el id de session de la misma.
        /// </summary>
        /// <param name="obj"></param>
        public Usuario GetCredenciales(Credentials obj)
        {

            //Usuario user = new Usuario();
            //user.Nombre = "";
            //user.ApellidoPaterno = "Stallone";
            //user.ApellidoMaterno = "Balboa";

            Usuario user1 = new Usuario();
            user1.Nombre = "Tom";
            user1.ApellidoPaterno = "Misaki";
            user1.ApellidoMaterno = "Yunei";
            user1.username = "Tom";
            user1.password = "Misaki";
            return user1;
        }


        /// <summary>
        /// Actualiza el registro de sesion en la base de datos y cierra la sesion del usuario en cuestion.
        /// cambiando tambien el status de la sesion.
        /// </summary>
        /// <param name="obj"></param>
        public void DoCloseSession(Session obj)
        {
            /*
            Buscar la sesion en la tabla de sesiones y actualizar la tabla con la fecha 
            */
            

        }


    }
}
