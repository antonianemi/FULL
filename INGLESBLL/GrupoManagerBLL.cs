using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class GrupoManagerBLL : BaseBusiness
    {
        GrupoManagerDLL _dll;
        public GrupoManagerBLL()
        {
            _dll = new GrupoManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}
