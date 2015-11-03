using InglesDLL;
using BaseAcces;
using InglesEntity;


namespace InglesBLL
{

    public class UsuarioManagerBLL : BaseBusiness
    {
        UsuarioManagerDLL _dll;
        public UsuarioManagerBLL()
        {
            _dll = new UsuarioManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}