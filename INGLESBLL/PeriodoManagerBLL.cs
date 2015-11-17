using System;
using InglesDLL;
using BaseAcces;
using InglesEntity;
using System.Collections.Generic;
using System.Linq;

namespace InglesBLL
{
    public class PeriodoManagerBLL : BaseBusiness
    {
        PeriodoManagerDLL _dll;
        public PeriodoManagerBLL()
        {
            _dll = new PeriodoManagerDLL(_StringConexion, TypeDataBase.Firebird);

        }
        /// <summary>
        /// Prepara la entidad para crear un nuevo periodo en la base de datos de forma limpia.
        /// Este metodo da de alta un periodo sin niveles unicamente preparado para agregarle niveles.
        /// </summary>
        /// <param name="obj"></param>
        public void NewPeriodoSinNiveles(Periodo obj)
        {
            obj.STATUS = estatusPeriodo.Activo;// registra el periodo como activo
            _dll.AddPeriodo(obj);
        }
        /// <summary>
        /// Cambia el Estatus de un Periodo Para Darlo de Baja.
        /// este cambio se puede llevar acabo unicamente si el estatus del periodo no es ya el periodo de baja.
        /// </summary>
        /// <param name="obj"></param>
        public void DoBajaPeriodo(Periodo obj)
        {
            //CONSULTAR EL ESTATUS ACTUAL DEL PERIODO EN LA BASE DE DATOS PARA VER SI ESTE ESTA ACTIVO
            obj.STATUS = estatusPeriodo.Baja;

        }
    }
}
