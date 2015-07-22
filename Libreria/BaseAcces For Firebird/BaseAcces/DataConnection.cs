using System;
using System.Data;

namespace BaseAcces
{
    internal class DataConnection : BaseTransaction
    {
        
        private string strConexion = "";

        private string msgError = "";

        private bool existError = false;

        private IDataParameter[] parameters;

        private IDbTransaction transaction = null;

        internal bool ExistError
        {
            get
            {
                return this.existError;
            }
            set
            {
                this.existError = value;
            }
        }

        internal string MsgError
        {
            get
            {
                return this.msgError;
            }
            set
            {
                this.msgError = value;
            }
        }

        protected IDataParameter[] Parameters
        {
            get
            {
                return this.parameters;
            }
            set
            {
                this.parameters = value;
            }
        }

        internal string StringConexion
        {
            get
            {
                return this.strConexion;
            }
            set
            {
                this.strConexion = value;
            }
        }

        internal IDbTransaction Transaction
        {
            get
            {
                return this.transaction;
            }
            set
            {
                this.transaction = value;
            }
        }

        internal DataConnection(string strConnection)
        {
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                base.TypeDB = TypeDataBase.Oracle;
                this.StringConexion = strConnection;
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
        }

        internal DataConnection(string strConexion, TypeDataBase typeDB)
        {
            base.TypeDB = typeDB;
            this.StringConexion = strConexion;
        }

        internal IDataParameter[] AddParameters(IDataParameter[] Parameters, DbType TypeObject, ParameterDirection Direction, string ParameterName, object Value)
        {
            ProviderSQL providerSQL = new ProviderSQL();
            if (Parameters != null)
            {
                providerSQL.ParameterLenght = (int)Parameters.Length + 1;
                providerSQL.Parameters = new IDataParameter[providerSQL.ParameterLenght];
                int i = 0;
                for (i = 0; i < (int)Parameters.Length; i++)
                {
                    providerSQL.Parameters[i] = Parameters[i];
                }
                providerSQL.Parameters[i].DbType = TypeObject;
                providerSQL.Parameters[i].Direction = Direction;
                providerSQL.Parameters[i].ParameterName = ParameterName;
                providerSQL.Parameters[i].Value = Value;
            }
            else
            {
                providerSQL.ParameterLenght = 1;
                providerSQL.Parameters = new IDataParameter[providerSQL.ParameterLenght];
                providerSQL.Parameters[0].DbType = TypeObject;
                providerSQL.Parameters[0].Direction = Direction;
                providerSQL.Parameters[0].ParameterName = ParameterName;
                providerSQL.Parameters[0].Value = Value;
            }
            Parameters = providerSQL.Parameters;
            return Parameters;
        }

        internal void AddParameters(IDbCommand comm, IDataParameter[] parameters)
        {
            IDataParameter[] dataParameterArray = parameters;
            for (int i = 0; i < (int)dataParameterArray.Length; i++)
            {
                IDataParameter dataParameter = dataParameterArray[i];
                comm.Parameters.Add(dataParameter);
            }
        }

        internal void BeginTransaction()
        {
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                this.Transaction = base.BaseBeginTransaction(this.StringConexion);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
        }

        internal void CommitTransaction()
        {
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                base.BaseCommitTransaction();
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
        }

        internal IDataAdapter DataAdapter(string strQuery, IDataParameter[] param, CommandType typeCommand)
        {
            IDataAdapter dataAdapter;
            this.ExistError = false;
            this.MsgError = "";
            IDataAdapter adapter = null;
            try
            {
                try
                {
                    ProviderSQL providerSQL = new ProviderSQL()
                    {
                        TipoDB = base.TypeDB
                    };
                    base.IConnection = providerSQL.Connection;
                    base.IConnection.ConnectionString = this.StringConexion;
                    base.IConnection.Open();
                    base.ICommand = base.IConnection.CreateCommand();
                    this.AddParameters(base.ICommand, param);
                    base.ICommand.CommandType = typeCommand;
                    base.ICommand.CommandText = strQuery;
                    providerSQL.Command = base.ICommand;
                    adapter = providerSQL.Adapter;
                    dataAdapter = adapter;
                    return dataAdapter;
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            finally
            {
                base.ICommand = null;
                if ((base.IConnection == null ? false : base.IConnection.State == ConnectionState.Open))
                {
                    base.IConnection.Close();
                }
                base.IConnection = null;
            }
            dataAdapter = adapter;
            return dataAdapter;
        }

        internal IDataAdapter DataAdapter(string strQuery)
        {
            IDataAdapter dataAdapter;
            this.ExistError = false;
            this.MsgError = "";
            IDataAdapter adapter = null;
            try
            {
                try
                {
                    ProviderSQL providerSQL = new ProviderSQL()
                    {
                        TipoDB = base.TypeDB
                    };
                    base.IConnection = providerSQL.Connection;
                    base.IConnection.ConnectionString = this.StringConexion;
                    base.IConnection.Open();
                    base.ICommand = base.IConnection.CreateCommand();
                    base.ICommand.CommandText = strQuery;
                    providerSQL.Command = base.ICommand;
                    adapter = providerSQL.Adapter;
                    dataAdapter = adapter;
                    return dataAdapter;
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            finally
            {
                base.ICommand = null;
                if ((base.IConnection == null ? false : base.IConnection.State == ConnectionState.Open))
                {
                    base.IConnection.Close();
                }
                base.IConnection = null;
            }
            dataAdapter = adapter;
            return dataAdapter;
        }

        internal void EndTransaction()
        {
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                base.BaseEndTransaction();
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
        }

        internal int ExecuteNonQuery(string strQuery)
        {
            this.ExistError = false;
            this.MsgError = "";
            int num = -1;
            try
            {
                try
                {
                    ProviderSQL providerSQL = new ProviderSQL()
                    {
                        TipoDB = base.TypeDB
                    };
                    base.IConnection = providerSQL.Connection;
                    base.IConnection.ConnectionString = this.StringConexion;
                    base.ICommand = providerSQL.Command;
                    base.IConnection.Open();
                    base.ICommand = base.IConnection.CreateCommand();
                    base.ICommand.CommandText = strQuery;
                    num = base.ICommand.ExecuteNonQuery();
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            finally
            {
                base.ICommand = null;
                if ((base.IConnection == null ? false : base.IConnection.State == ConnectionState.Open))
                {
                    base.IConnection.Close();
                }
                base.IConnection = null;
            }
            return num;
        }

        internal int ExecuteNonQuery(string strQuery, IDataParameter[] param, CommandType typeCommand)
        {
            this.ExistError = false;
            this.MsgError = "";
            int num = -1;
            try
            {
                try
                {
                    ProviderSQL providerSQL = new ProviderSQL()
                    {
                        TipoDB = base.TypeDB
                    };
                    base.IConnection = providerSQL.Connection;
                    base.IConnection.ConnectionString = this.StringConexion;
                    base.IConnection.Open();
                    base.ICommand = base.IConnection.CreateCommand();
                    this.AddParameters(base.ICommand, param);
                    base.ICommand.CommandType = typeCommand;
                    base.ICommand.CommandText = strQuery;
                    num = base.ICommand.ExecuteNonQuery();
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            finally
            {
                base.ICommand = null;
                if ((base.IConnection == null ? false : base.IConnection.State == ConnectionState.Open))
                {
                    base.IConnection.Close();
                }
                base.IConnection = null;
            }
            return num;
        }

        internal int ExecuteNonQuery(IDbTransaction trans, string strQuery)
        {
            this.ExistError = false;
            this.MsgError = "";
            int num = -1;
            try
            {
                IDbCommand dbCommand = trans.Connection.CreateCommand();
                dbCommand.Transaction = trans;
                dbCommand.CommandText = strQuery;
                num = dbCommand.ExecuteNonQuery();
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
            return num;
        }

        internal IDataReader ExecuteReader(string strQuery)
        {
            IDataReader dataReader;
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                ProviderSQL providerSQL = new ProviderSQL()
                {
                    TipoDB = base.TypeDB
                };
                base.IConnection = providerSQL.Connection;
                base.IConnection.ConnectionString = this.StringConexion;
                base.IConnection.Open();
                base.ICommand = base.IConnection.CreateCommand();
                base.ICommand.CommandText = strQuery;
                dataReader = base.ICommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                dataReader = null;
            }
            return dataReader;
        }

        internal object ExecuteScalar(string strQuery)
        {
            this.ExistError = false;
            this.MsgError = "";
            object obj = null;
            try
            {
                try
                {
                    ProviderSQL providerSQL = new ProviderSQL()
                    {
                        TipoDB = base.TypeDB
                    };
                    base.IConnection = providerSQL.Connection;
                    base.IConnection.ConnectionString = this.StringConexion;
                    base.ICommand = providerSQL.Command;
                    base.IConnection.Open();
                    base.ICommand = base.IConnection.CreateCommand();
                    base.ICommand.CommandText = strQuery;
                    obj = base.ICommand.ExecuteScalar();
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            finally
            {
                base.ICommand = null;
                if ((base.IConnection == null ? false : base.IConnection.State == ConnectionState.Open))
                {
                    base.IConnection.Close();
                }
                base.IConnection = null;
            }
            return obj;
        }

        internal object ExecuteScalar(string strQuery, IDataParameter[] param, CommandType typeCommand)
        {
            this.ExistError = false;
            this.MsgError = "";
            object obj = null;
            try
            {
                try
                {
                    ProviderSQL providerSQL = new ProviderSQL()
                    {
                        TipoDB = base.TypeDB
                    };
                    base.IConnection = providerSQL.Connection;
                    base.IConnection.ConnectionString = this.StringConexion;
                    base.ICommand = providerSQL.Command;
                    base.IConnection.Open();
                    base.ICommand = base.IConnection.CreateCommand();
                    this.AddParameters(base.ICommand, param);
                    base.ICommand.CommandType = typeCommand;
                    base.ICommand.CommandText = strQuery;
                    obj = base.ICommand.ExecuteScalar();
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            finally
            {
                base.ICommand = null;
                if ((base.IConnection == null ? false : base.IConnection.State == ConnectionState.Open))
                {
                    base.IConnection.Close();
                }
                base.IConnection = null;
            }
            return obj;
        }

        internal object ExecuteScalar(IDbTransaction trans, string strQuery)
        {
            object obj;
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                IDbCommand dbCommand = trans.Connection.CreateCommand();
                dbCommand.Transaction = trans;
                dbCommand.CommandText = strQuery;
                obj = dbCommand.ExecuteScalar();
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                obj = null;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
            return obj;
        }

        internal IDataParameter[] InicializedParameters()
        {
            return null;
        }

        


        internal void RollBackTransaction()
        {
            this.ExistError = false;
            this.MsgError = "";
            try
            {
                base.BaseRollbackTransaction();
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                this.ExistError = true;
                this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
            }
        }
         
    }
}

