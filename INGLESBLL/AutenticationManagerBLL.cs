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
        AutenticationManagerDLL dll;        
        public AutenticationManagerBLL()
        {
            dll = new AutenticationManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }

        public Session DoLogin(Credentials obj)
        {
            return dll.DoLogin(obj);
        }
    }
}
