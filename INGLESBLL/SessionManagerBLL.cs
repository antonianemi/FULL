using InglesDLL;
using BaseAcces;
using InglesEntity;


namespace InglesBLL
{

    public class SessionManagerBLL : BaseBusiness
    {
        SessionManagerDLL _dll;
        public SessionManagerBLL()
        {
            _dll = new SessionManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}