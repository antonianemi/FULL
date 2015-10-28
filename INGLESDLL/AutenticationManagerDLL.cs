using System;
using System.Data;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;

namespace InglesDLL
{
    public class AutenticationManagerDLL : BaseDLL
    {
        /// <summary>
        /// Representa el contructor de dll del administrador.
        /// </summary>
        public AutenticationManagerDLL(string pstrConn, TypeDataBase pTypeDB) : base(pstrConn, pTypeDB)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public Session DoLogin(Credentials obj)
        {
            /*Preuntar si el usuario existe en la base de datos.*/
            Session session = new Session();

            Usuario user = new Usuario();
            user.Nombre = "Silvester";
            user.ApellidoPaterno = "Stallone";
            user.ApellidoMaterno = "Balboa";


            session.User = user;
            session.IdSession = 1;

            return session;
        }

    }
}
