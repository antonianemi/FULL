using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class NivelManagerBLL : BaseBusiness
    {
        NivelManagerDLL _dll;
        public NivelManagerBLL()
        {
            _dll = new NivelManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}