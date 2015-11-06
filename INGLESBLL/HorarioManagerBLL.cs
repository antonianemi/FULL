using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class HorarioManagerBLL : BaseBusiness
    {
        /// <summary>
        /// 
        /// </summary>
        HorarioManagerDLL _dll;
        /// <summary>
        /// 
        /// </summary>
        public HorarioManagerBLL()
        {
            _dll = new HorarioManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
        

        
    }
}