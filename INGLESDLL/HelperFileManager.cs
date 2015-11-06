using System;
using System.Data;

namespace InglesDLL
{


    internal class HelperFileManager
    {
        string _PATH { set; get; }

        DataTable data;

        /// <summary>
        /// 
        /// </summary>
        public HelperFileManager()
        {
            data = new DataTable();

            if (_PATH == String.Empty)
            {
                //get path of resources.
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal IDataReader ExecuteReader()
        {
             return data.CreateDataReader();
        }
    }


}
