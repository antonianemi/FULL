using System;
using System.Data;

namespace BaseAcces
{
    public class BaseDLL
    {
        private TypeDataBase typeDB;

        private IDataParameter[] parameters = null;

        private string strquery = string.Empty;

        private string msgError;

        private bool existError = false;

        private IDbTransaction transaction = null;

        private string strConnection;

        private int parameterLenght = 1;

        private DataConnection con;

        public bool ExistError
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

        public string MessageError
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

        protected string Query
        {
            get
            {
                return this.strquery;
            }
            set
            {
                this.strquery = value;
            }
        }

        protected string StringConnection
        {
            get
            {
                return this.strConnection;
            }
            set
            {
                this.strConnection = value;
            }
        }

        public IDbTransaction Transaction
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

        protected TypeDataBase TypeDB
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

        public BaseDLL(string pStrConn)
        {
            this.con = new DataConnection(pStrConn);
            this.TypeDB = this.con.TypeDB;
        }

        public BaseDLL(string pStrConn, TypeDataBase pTypeDB)
        {
            this.con = new DataConnection(pStrConn, pTypeDB);
            this.TypeDB = this.con.TypeDB;
        }

        protected DataSet AdapterFill(string strQuery)
        {
            DataSet dataSet = new DataSet();
            IDataAdapter dataAdapter = this.con.DataAdapter(strQuery);
            if (this.con.ExistError)
            {
                this.ExistError = this.con.ExistError;
                this.msgError = this.con.MsgError;
            }
            else
            {
                try
                {
                    dataAdapter.Fill(dataSet);
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            return dataSet;
        }

        protected DataSet AdapterFill(string strQuery, IDataParameter[] parameters, CommandType typeComm)
        {
            DataSet dataSet = new DataSet();
            IDataAdapter dataAdapter = this.con.DataAdapter(strQuery, parameters, typeComm);
            if (this.con.ExistError)
            {
                this.ExistError = this.con.ExistError;
                this.msgError = this.con.MsgError;
            }
            else
            {
                try
                {
                    dataAdapter.Fill(dataSet);
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    this.ExistError = true;
                    this.msgError = exception.Message.Replace("\"", "'").Replace("\r", "").Replace("\n", "\\n");
                }
            }
            return dataSet;
        }

        protected void AddParameters(DbType TypeObject, ParameterDirection Direction, string ParameterName, object Value)
        {
            this.ExistError = false;
            this.msgError = "";
            this.Parameters = this.con.AddParameters(this.Parameters, TypeObject, Direction, ParameterName, Value);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
        }

        public void BeginTransaction()
        {
            this.con.BeginTransaction();
            if (!this.con.ExistError)
            {
                this.Transaction = this.con.Transaction;
            }
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
        }

        public void CommitTransaction()
        {
            this.con.CommitTransaction();
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
        }

        protected IDataAdapter DataAdapter(string strQuery, IDataParameter[] parameters, CommandType typeComm)
        {
            IDataAdapter dataAdapter = this.con.DataAdapter(strQuery, parameters, typeComm);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return dataAdapter;
        }

        protected IDataAdapter DataAdapter(string strQuery)
        {
            IDataAdapter dataAdapter = this.con.DataAdapter(strQuery);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return dataAdapter;
        }

        public void EndTransaction()
        {
            this.con.EndTransaction();
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
        }

        protected int ExecuteNonQuery(string strQuery)
        {
            this.ExistError = false;
            this.msgError = "";
            int num = this.con.ExecuteNonQuery(strQuery);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return num;
        }

        protected int ExecuteNonQuery(string strQuery, IDataParameter[] parameters, CommandType typeComm)
        {
            this.ExistError = false;
            this.msgError = "";
            int num = this.con.ExecuteNonQuery(strQuery, parameters, typeComm);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return num;
        }

        protected int ExecuteNonQuery(IDbTransaction trans, string strQuery)
        {
            int num = this.con.ExecuteNonQuery(trans, strQuery);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return num;
        }

        protected IDataReader ExecuteReader(string strQuery)
        {
            IDataReader dataReader = this.con.ExecuteReader(strQuery);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return dataReader;
        }

        protected object ExecuteScalar(string strQuery)
        {
            this.ExistError = false;
            this.msgError = "";
            object obj = this.con.ExecuteScalar(strQuery);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return obj;
        }

        protected object ExecuteScalar(string strQuery, IDataParameter[] parameters, CommandType typeComm)
        {
            this.ExistError = false;
            this.msgError = "";
            object obj = this.con.ExecuteScalar(strQuery, parameters, typeComm);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return obj;
        }

        protected object ExecuteScalar(IDbTransaction trans, string strQuery)
        {
            object obj = this.con.ExecuteScalar(trans, strQuery);
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
            return obj;
        }

        protected string FormatDate(DateTime fecha)
        {
            string str = "";
            switch (this.TypeDB)
            {
                case TypeDataBase.Oracle:
                    {
                        str = (fecha == DateTime.MinValue ? "NULL" : string.Concat("TO_DATE('", fecha.ToString("dd/MM/yyyy"), "','DD/MM/YYYY')"));
                        break;
                    }
                case TypeDataBase.SqlServer:
                    {
                        str = (fecha == DateTime.MinValue ? "NULL" : string.Concat("CONVERT(DATETIME,'", fecha.ToString("dd/MM/yyyy"), "',103)"));
                        break;
                    }
            }
            return str;
        }

        protected string FormatDateTime(DateTime fecha)
        {
            string str = "";
            switch (this.TypeDB)
            {
                case TypeDataBase.Oracle:
                    {
                        str = (fecha == DateTime.MinValue ? "NULL" : string.Concat("TO_DATE('", fecha.ToString("dd/MM/yyyy HH:mm:ss"), "','DD/MM/YYYY HH24:MI:SS')"));
                        break;
                    }
                case TypeDataBase.SqlServer:
                    {
                        str = (fecha == DateTime.MinValue ? "NULL" : string.Concat("CONVERT(DATETIME,'", fecha.ToString("dd/MM/yyyy HH:mm:ss"), "',103)"));
                        break;
                    }
            }
            return str;
        }

        protected string FormatDouble(double valor)
        {
            return (valor < 0 ? "NULL" : valor.ToString());
        }

        protected string FormatInt(int valor)
        {
            return (valor < 0 ? "NULL" : valor.ToString());
        }

        protected string FormatLong(long valor)
        {
            return (valor < (long)0 ? "NULL" : valor.ToString());
        }

        protected string FormatString(string valor)
        {
            return (valor == string.Empty ? "NULL" : string.Concat("'", valor, "'"));
        }

        protected void InicializedParameters()
        {
            this.Parameters = this.con.InicializedParameters();
        }

        public void RollBackTransaction()
        {
            this.con.RollBackTransaction();
            this.ExistError = this.con.ExistError;
            this.msgError = this.con.MsgError;
        }
    }

}
