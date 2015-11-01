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
        public Session DoLogin(Credentials obj)
        {
            Session session = null;           
            session = new Session();
            Usuario user = new Usuario();
            user.Nombre = "Silvester";
            user.ApellidoPaterno = "Stallone";
            user.ApellidoMaterno = "Balboa";
            session.User = user;
            session.IdSession = 1;
            return session;
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
