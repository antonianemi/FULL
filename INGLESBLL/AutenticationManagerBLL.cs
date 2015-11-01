using System;
using InglesDLL;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;
using System.Linq;

namespace InglesBLL
{

    public class AutenticationManagerBLL:BaseBusiness
    {
        AutenticationManagerDLL _dll;

        public AutenticationManagerBLL()
        {
            _dll = new AutenticationManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }

        /// <summary>
        /// Crea una nueva session en la base de datos.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Session DoLogin(Credentials obj)
        {
            Session sesion = new Session();

            sesion = _dll.DoLogin(obj);

            if (_dll.ExistError)
            {
                _dll.CodeError = Errores.PasswordIncorrecto;
                _dll.MessageError = "";
            }
            
            sesion.Status = STATUSSESSION.Open;
            return sesion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        public void DoCloseSession(Session obj)
        {   
            _dll.DoCloseSession(obj);

            if (_dll.ExistError)
            {                
            }
        }
    }
}
