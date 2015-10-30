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

        public Session DoLogin(Credentials obj)
        {
            return _dll.DoLogin(obj);
        }
    }
}
