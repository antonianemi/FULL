using System;
using InglesDLL;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;
using System.Linq;

namespace InglesBLL
{
   public  class CredentialsManagerBLL : BaseBusiness
    {
        CredentialsManagerDLL _dll;
        public CredentialsManagerBLL()
        {
            _dll = new CredentialsManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}
