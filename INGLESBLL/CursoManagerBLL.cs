using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class CursoManagerBLL : BaseBusiness
    {
        CursoManagerDLL _dll;
        public CursoManagerBLL()
        {
            _dll = new CursoManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}