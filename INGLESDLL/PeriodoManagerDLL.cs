using System;
using System.Data;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;

namespace InglesDLL
{
    public class PeriodoManagerDLL : BaseDLL
    {
        public PeriodoManagerDLL(string pstrConn, TypeDataBase pTypeDB) : base(pstrConn, pTypeDB) { }


        /// <summary>
        /// Crea un nuevo periodo en la base de datos.
        /// </summary>
        /// <param name="obj"></param>
        public void AddPeriodo(Periodo obj)
        {
            this.ExecuteNonQuery(String.Format("EXECUTE PROCEDURE SP_REGISTRA_PERIODO({0},'{1}','{2}',{3})", getPKPeriodo(), obj.PERIODO, obj.DESCRIPCION, obj.STATUS));
            if (this.ExistError)
                throw new Exception(this.MessageError);
        }


        /// <summary>
        /// Obtiene la LLave Primaria de el registro nuevo a insertar.
        /// </summary>
        /// <returns></returns>
        private int getPKPeriodo()
        {
            int num = Convert.ToInt32(this.ExecuteScalar(String.Format("SELECT ID_PERIODO FROM PERIODOS ORDER BY ID_PERIODO DESC"))) + 1;
            if (this.ExistError)
                throw new Exception(this.MessageError);
            return num;
        }

    }
}
