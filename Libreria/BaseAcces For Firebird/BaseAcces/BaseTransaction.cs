using System;
using System.Collections;
using System.Data;

namespace BaseAcces
{
    [Serializable]
    internal class BaseTransaction
    {
        [NonSerialized]
        private IDataParameter[] iparameter;

        [NonSerialized]
        private IDbCommand idbCommand;

        private IDbConnection idbCon;

        private IDbTransaction idbTrasn;

        private TypeDataBase typeDB = TypeDataBase.Oracle;

        public IDbCommand ICommand
        {
            get
            {
                return this.idbCommand;
            }
            set
            {
                this.idbCommand = value;
            }
        }

        internal IDbConnection IConnection
        {
            get
            {
                return this.idbCon;
            }
            set
            {
                this.idbCon = value;
            }
        }

        internal IDataParameter[] IParameter
        {
            get
            {
                return this.iparameter;
            }
            set
            {
                this.iparameter = value;
            }
        }

        internal IDbTransaction ITransaction
        {
            get
            {
                return this.idbTrasn;
            }
            set
            {
                this.idbTrasn = value;
            }
        }

        public TypeDataBase TypeDB
        {
            get
            {
                return this.typeDB;
            }
            set
            {
                this.typeDB = value;
            }
        }

        public BaseTransaction()
        {
        }

        internal IDbTransaction BaseBeginTransaction(string strConnection)
        {
            if ((this.IConnection == null ? false : this.IConnection.State == ConnectionState.Open))
            {
                this.IConnection.Close();
            }
            ProviderSQL providerSQL = new ProviderSQL()
            {
                TipoDB = this.TypeDB
            };
            this.IConnection = providerSQL.Connection;
            this.IConnection.ConnectionString = strConnection;
            this.IConnection.Open();
            this.ITransaction = this.IConnection.BeginTransaction();
            return this.ITransaction;
        }

        internal void BaseCommitTransaction()
        {
            if (this.ITransaction != null)
            {
                this.ITransaction.Commit();
            }
        }

        internal void BaseEndTransaction()
        {
            if ((this.IConnection == null ? false : this.IConnection.State == ConnectionState.Open))
            {
                this.IConnection.Close();
            }
        }

        internal void BaseRollbackTransaction()
        {
            if (this.ITransaction != null)
            {
                this.ITransaction.Rollback();
            }
        }
    }
}

