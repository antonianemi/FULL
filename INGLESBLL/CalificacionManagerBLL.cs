using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class CalificacionManagerBLL : BaseBusiness
    {
        CalificacionManagerDLL _dll;
        public CalificacionManagerBLL()
        {
            _dll = new CalificacionManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}
