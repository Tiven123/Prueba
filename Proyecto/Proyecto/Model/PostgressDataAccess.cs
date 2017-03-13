using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Xml;
using System.Windows.Forms;

namespace Model
{
    class PostgressDataAccess
    {
        private Boolean isError = false;        //Una bandera, para determinar si existe o no algun error
        private String errorDescription;        //Almacena la descripcion del error        

        public NpgsqlConnection connection;       //Objeto de tipo conexion, para establecer comunicacion con la BD
        private NpgsqlTransaction transaction;  //Objeto de tipo transaccion de base de datos, para iniciar, procesar y cerrar transacciones
        private bool thereIsTransaction;            //Bandera que determina si hay una transaccion activa
        private string schema;                  //Almacena el esquema con el cual se trabaja en la base de datos, para devolverlo mediante un metodo get
        string conexionType = "2";

        static int instances = 0;              //Contador de cuanta veces se ha instanciado la clase, para evitar que se instancie mas de una vez
        private static PostgressDataAccess instance;

        public static PostgressDataAccess Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PostgressDataAccess();
                }
                return instance;
            }
        }

        public DataSet loadIni()
        {
            DataSet dsetConf = new DataSet();
            try
            {
                string XMLFile = Application.StartupPath + "\\INI.xml";
                System.IO.FileStream fsReadXml = new System.IO.FileStream(XMLFile, System.IO.FileMode.Open);
                dsetConf.ReadXml(fsReadXml);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error cargando el archivo de configuración, " +
                                "detalle técnico: " + e.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return dsetConf;
        }


        // Constructor
        private PostgressDataAccess()
        {
            cleanState();

            if (instances > 1)
                return;

            //DataSet parametros = this.cargarIni();
            //DataTable tabla = parametros.Tables[0];
            //DataRow fila = tabla.Rows[0];

            DataRow fila = this.loadIni().Tables[0].Rows[0];

            connection = new NpgsqlConnection("Encoding = UNICODE; Server=" + fila["Server"].ToString() +
                                            ";Port = " + fila["Port"].ToString() +
                                            ";User Id=" + fila["Usuario"].ToString() +
                                            ";Password=" + fila["Password"].ToString() +
                                            ";Database=" + fila["Database"].ToString() +
                                            ";CommandTimeout=3600;");
            instances += 1;

            try
            {
                connection.Open();
                this.schema = fila["Schema"].ToString();
            }
            catch (NpgsqlException error)
            {
                instances = 0;
                this.IsError = true;
                this.errorDescription = error.Message;
            }

        }

        // Indica el estado de la persistencia
        public Boolean state()
        {
            cleanState();

            String message = "";

            // estado dela conexión
            switch (connection.State)
            {
                case System.Data.ConnectionState.Broken:
                    message = "La conexión con la base de datos fue interrumpida.";
                    break;
                case System.Data.ConnectionState.Closed:
                    message = "La conexión con la base de datos fue cerrada o no pudo ser establecida.";
                    break;
                case System.Data.ConnectionState.Connecting:
                    message = "Conectandose.";
                    break;
                case System.Data.ConnectionState.Executing:
                    message = "Ejecutando.";
                    break;
                case System.Data.ConnectionState.Fetching:
                    message = "Extrayendo.";
                    break;
                case System.Data.ConnectionState.Open:
                    message = "Abierta.";
                    break;
            }

            // cargar la propiedad con el estado de la conexion
            descriptionError = message;

            if ((connection.State == ConnectionState.Open) ||
                  (connection.State == ConnectionState.Executing) ||
                  (connection.State == ConnectionState.Fetching))
                return true;
            else
                return false;
        }

        // destructor
        ~PostgressDataAccess()
        {
        }

        public void connect()
        {
            try
            {
                if (!(connection.State == ConnectionState.Open))
                {
                    connection.Open();
                    instances = 1;
                }
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.descriptionError = error.Message;
            }
        }

        public void disconnect()
        {
            try
            {
                connection.Close();
                instances = 0;
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.descriptionError = error.Message;
            }
        }

        //Manipulacion de select
        public DataSet executeSQLQuery(String pSql)
        {
            cleanState();

            NpgsqlDataAdapter oDataAdapter = new NpgsqlDataAdapter(pSql, connection);
            DataSet oDataSet = new DataSet();

            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet);
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.errorDescription = error.Message;
            }

            return oDataSet;
        }

        public DataSet executeSQLQuery(String pSql, String pnTabla, Object[] myParamArray)
        {
            cleanState();

            NpgsqlCommand cmd = new NpgsqlCommand(pSql, connection);

            cmd.CommandType = CommandType.Text;

            for (int j = 0; j < myParamArray.Length; j++)
            {
                cmd.Parameters.Add((NpgsqlParameter)myParamArray[j]);
            }


            NpgsqlDataAdapter oDataAdapter = new NpgsqlDataAdapter(cmd);
            DataSet oDataSet = new DataSet();

            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet, pnTabla);
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.errorDescription = error.Message;
            }

            return oDataSet;
        }

        public DataSet executeSQLQuery(String pSql, String pnTabla)
        {
            cleanState();


            NpgsqlDataAdapter oDataAdapter = new NpgsqlDataAdapter(pSql, connection);
            DataSet oDataSet = new DataSet();

            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet, pnTabla);
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.errorDescription = error.Message;
            }

            return oDataSet;
        }

        // Método para manipular Insert, Update, Delete
        public void executeSQL(String pSql)
        {
            cleanState();

            // Definicion de Command
            NpgsqlCommand cmd = null;

            try
            {
                cmd = new NpgsqlCommand(pSql, connection);

                if (this.thereIsTransaction)
                {
                    cmd.Transaction = this.transaction;
                }

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.errorDescription = error.Message;
            }

        }

        // Método para manipular Insert, Update, Delete con identidad
        public void executeSQL(string pSql, Object[] myParamArray, ref string pNumber)
        {
            cleanState();

            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(pSql, connection);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((NpgsqlParameter)myParamArray[j]);
                }

                if (this.thereIsTransaction)
                {
                    cmd.Transaction = this.transaction;
                }

                cmd.ExecuteNonQuery();
                try
                {
                    pNumber = "";
                    pNumber = cmd.ExecuteScalar().ToString();
                }
                catch { }
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.errorDescription = error.Message;
            }
        }

        //Método para manipular Insert, Update pero con parametros
        public void executeSQL(string sql, Object[] myParamArray)
        {
            cleanState();

            try
            {

                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((NpgsqlParameter)myParamArray[j]);
                }

                if (this.thereIsTransaction)
                {
                    cmd.Transaction = this.transaction;
                }


                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException error)
            {
                this.IsError = true;
                this.errorDescription = error.Message;
            }

        }

        //Metodos de transaccion
        public void startTransaction()
        {
            if (this.thereIsTransaction == false)
            {
                this.transaction = this.connection.BeginTransaction();
                this.thereIsTransaction = true;
            }
        }

        public void commitTransaccion()
        {
            if (this.thereIsTransaction)
            {
                this.transaction.Commit();
                this.thereIsTransaction = false;
            }
        }

        public void rollbackTransaccion()
        {
            if (this.thereIsTransaction)
            {
                this.transaction.Rollback();
                this.thereIsTransaction = false;
            }
        }

        // Metodos de Set & Get
        public Boolean IsError
        {
            set { isError = value; }
            get { return isError; }
        }

        public String descriptionError
        {
            set { errorDescription = value; }
            get { return errorDescription; }
        }

        public string Schema
        {
            get { return this.schema; }
        }

        public string TipoConexion
        {
            get { return this.conexionType; }
        }

        //Elimina el estado de error de la clase.
        public void cleanState()
        {
            this.errorDescription = "";
            this.isError = false;
        }
    }
}
