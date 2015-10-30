using InglesDLL;
using BaseAcces;
using InglesEntity;


namespace InglesBLL
{
    public class AsistenciaManagerBLL : BaseBusiness
    {
        AsistenciaManagerDLL _dll;
        public AsistenciaManagerBLL()
        {
            _dll = new AsistenciaManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}
