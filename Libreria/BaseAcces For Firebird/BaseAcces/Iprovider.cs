using System;
using System.Data;

namespace BaseAcces
{
    internal interface IProvider
    {
        IDataAdapter Adapter
        {
            get;
        }

        IDbCommand Command
        {
            get;
        }

        IDbConnection Connection
        {
            get;
        }

        IDataParameter[] Parameters
        {
            get;
        }

        IDataReader Reader
        {
            get;
        }

        IDbTransaction Transaction
        {
            get;
        }
    }
}

