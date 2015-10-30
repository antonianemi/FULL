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
            obj.NIVELES = null;//se asegura de que no se registren niveles con este periodo
            obj.STATUS = estatusPeriodo.Activo;// registra el periodo como activo
            _dll.AddPeriodo(obj);
        }
        /// <summary>
        /// Registra un Nuevo Periodo Con niveles en la base de datos.
        /// Se asegura de insertarlos con niveles, de no tener niveles el periodo que se mando a guardar, este
        /// rechaza la solicitud y notifica al objeto cliente el error ocurrido, esto mediante un mensaje de excepcion.
        /// </summary>
        /// <param name="obj">Representa el Periodo con </param>
        public void NewPeriodoConNiveles(Periodo obj)
        {
            if(obj.NIVELES != null && obj.NIVELES.Count > 0){
                obj.STATUS = estatusPeriodo.Activo;
                _dll.AddPeriodo(obj);
            }
            else
            {
                throw new Exception("Por Favor Especifique almenos un Nivel Para este Periodo");
            }

            
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
