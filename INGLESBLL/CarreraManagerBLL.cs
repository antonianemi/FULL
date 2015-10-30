using InglesDLL;
using BaseAcces;
using InglesEntity;

namespace InglesBLL
{
    public class CarreraManagerBLL : BaseBusiness
    {
        CarreraManagerDLL _dll;
        public CarreraManagerBLL()
        {
            _dll = new CarreraManagerDLL(_StringConexion, TypeDataBase.Firebird);
        }
    }
}