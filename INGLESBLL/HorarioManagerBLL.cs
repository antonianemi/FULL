using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class HorarioManagerBLL : BaseBusiness
    {
        HorarioManagerDLL _dll;
        public HorarioManagerBLL()
        {
            _dll = new HorarioManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}