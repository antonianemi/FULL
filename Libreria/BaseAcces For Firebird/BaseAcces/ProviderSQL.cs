using System;
using System.Data;
using System.Data.SqlClient;
using FirebirdSql.Data.FirebirdClient;

namespace BaseAcces
{
   internal class ProviderSQL : IProvider
    {
        private TypeDataBase tipoDB;

        private int parameterLenght;

        private IDataParameter[] parameter = null;

        private IDbCommand idbComm = null;

        public IDataAdapter Adapter
        {
            get
            {
                IDataAdapter DataAdapter = null;
                switch (this.TipoDB)
                {
                    case TypeDataBase.Firebird:
                    {
                        DataAdapter = new FbDataAdapter((FbCommand)this.Command);
                        break;
                    }
                }
                return DataAdapter;
            }
        }

        public IDbCommand Command
        {
            get
            {
                return getCommand();
            }
            set
            {
                setCommand(value);
            }
        }

       /// <summary>
       /// Construye un comando de base de datos de firebird.
       /// </summary>
       /// <returns>
       /// Retorna el comando creado para la base de datos firebird.
       /// </returns>
        public IDbCommand getCommand()
        {
            switch (this.TipoDB)
            {
                case TypeDataBase.Firebird:
                {
                    if (this.idbComm == null)
                    {
                        this.idbComm = new FbCommand();
                    }
                    break;
                }
                
            }
            return this.idbComm;
        }

        public void setCommand(IDbCommand value)
        {
            this.idbComm = value;
        }

        public IDbConnection Connection
        {
            get
            {
                IDbConnection Connection = null;
                switch (this.TipoDB)
                {
                    case TypeDataBase.Firebird:
                    {
                        Connection = new FbConnection();
                        break;
                    }
                }
                return Connection;
            }
        }

        public int ParameterLenght
        {
            get
            {
                return this.parameterLenght;
            }
            set
            {
                this.parameterLenght = value;
            }
        }

        public IDataParameter[] Parameters
        {
            get
            {
                return getParameters();
            }
            set
            {
                setParameters(value);
            }
        }

        public IDataParameter[] getParameters()
        {
            int i;
            switch (this.TipoDB)
            {
                
                case TypeDataBase.Firebird:
                {
                    for (i = 0; i < this.ParameterLenght; i++)
                    {
                        if (this.parameter[i] == null)
                        {
                            FbParameter sqlParameter = new FbParameter();
                            this.parameter[i] = sqlParameter;
                        }
                    }
                    break;
                }
            }
            return this.parameter;
        }

        public void setParameters(IDataParameter[] value)
        {
            this.parameter = value;
        }

        public IDataReader Reader
        {
            get
            {
                IDataReader dataReader = null;
                switch (this.TipoDB)
                {
                    case TypeDataBase.Firebird:
                    {
                        dataReader = null;
                        break;
                    }
                }
                return dataReader;
            }
        }

        public TypeDataBase TipoDB
        {
            get
            {
                return this.tipoDB;
            }
            set
            {
                this.tipoDB = value;
            }
        }

        public IDbTransaction Transaction
        {
            get
            {
                IDbTransaction dbTransaction = null;
                switch (this.TipoDB)
                {
                    case TypeDataBase.Firebird:
                    {
                        dbTransaction = null;
                        break;
                    }
                }
                return dbTransaction;
            }
        }

        public ProviderSQL()
        {
        }
    }
}
