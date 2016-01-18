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
        Credentials _credencialescurrent;
        Usuario _usuario;
        Session _sesion;
        
        public Session _SESION { get { return _sesion; } }

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
            _credencialescurrent = obj;
            
            
            _usuario = _dll.GetCredenciales(obj);
            DoAutenticar();
            if (_dll.ExistError)
            {
                _dll.CodeError = Errores.PasswordIncorrecto;
                _dll.MessageError = "";
            }
            
            _sesion.Status = STATUSSESSION.Open;
            return _sesion;
        }

        private void DoAutenticar()
        {
            if (_credencialescurrent.Username == _usuario.username && _credencialescurrent.Password == _usuario.password)
            {
                doGenerarSesion();
            }
            else
            {
                ExistError = true;
                MessageError = "Usuario y password incorrecto";
            }
                
        }

        private void doGenerarSesion()
        {
            _sesion = new Session();
            _sesion.User = _usuario;
            _sesion.IdSession = 1;//este numero va a ser generado por autenticationmanagerdll.getsesionid()
            _sesion.Status = STATUSSESSION.Open;
            _sesion.FechaInicio = DateTime.Now;
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
