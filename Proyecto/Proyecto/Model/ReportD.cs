using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NpgsqlTypes;

namespace Model
{
    public class ReportD
    {
        private PostgressDataAccess connection;

        private bool error;
        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public ReportD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        public DataSet report_work_order_billing(int consecutive)
        {

            DataSet dset = null;

            Parameters oParameters = new Parameters();
           
            string sql = "select wo.consecutive as codigo_orden, wo.state as estado_orden, wo.entrydate as fecha_entrada, wo.exitdate as fecha_salida, " +
                "wo.costperorder as costo_orden, em.employee_name as empleado_orden, ve.vehicleyear as ano_vehiculo, ve.enginenumber as motor_vehiculo, " +
                "mo.modeldescription as modelo_vehiculo, br.branddescription as marca_vahiculo, cl.clientname as nombre_cliente, " +
                "cl.lastname1 as apellido_uno_cliente, cl.lastname2 as apellido_dos_cliente, cl.celphone as telefono_cliente " +
                "from workorder wo " +
                "JOIN employee em ON wo.employee = em.employeecod " +
                "JOIN vehicle ve ON wo.vehicle = ve.vehicleid " +
                "JOIN model mo ON ve.model = mo.modelcod " +
                "JOIN brand br ON mo.brand = br.brandcod " +
                "JOIN client cl ON ve.client = cl.clientid " +
                "WHERE wo.consecutive = @consecutive;";

            oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, consecutive);

            dset = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                //table = dset.Tables[0].Copy();
            }

            return dset;
        }
        public DataSet report_repair_per_order(int consecutive)
        {

            DataSet dset = null;

            Parameters oParameters = new Parameters();

            string sql = "select re.reparationscatalogue as codigo_reparacion, rc.description as descripcion_reparacion, re.reparationcost as costo_reparacion,  " + 
                "re.hours as horas_reparacion,  re.total as total_reparacion, em.employee_name as empleado_reparacion " +
                "from reparationperorder re " + 
                "JOIN employee as em ON re.employee = em.employeecod " + 
                "JOIN reparationscatalogue rc ON  re.reparationscatalogue = rc.consecutive " +
                "WHERE re.workorder = @consecutive;";

            oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, consecutive);

             dset = this.connection.executeSQLQuery(sql, "reparationperorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                //table = dset.Tables[0].Copy();
            }

            return dset;
        }
        public DataSet report_replacement_per_order(int consecutive)
        {

            DataSet dset = null;

            Parameters oParameters = new Parameters();

            string sql = "select re.replacementcatalogue as codigo_repuesto, rc.replamentname as descripcion_repuesto, " +
                "re.quantity as cantidad_repuesto, re.price as costo_repuesto,  re.total as total_repuesto " +
                "from replacementperorder re " +
                "JOIN replacementcatalogue rc ON  re.replacementcatalogue = rc.consecutive " +
                "WHERE re.workorder = @consecutive;";

            oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, consecutive);

            dset = this.connection.executeSQLQuery(sql, "replacementperorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                //table = dset.Tables[0].Copy();
            }

            return dset;
        }

        public DataTable report_order_per_day(DateTime dateN)
        {

            DataTable table = null;

            Parameters oParameters = new Parameters();

            string sql = "select wo.consecutive as codigo, wo.vehicle as placa_vehiculo, wo.costperorder as costo " +
                "from workorder wo " +
                "WHERE wo.state = 'Facturado' and wo.billingdate = @date;";

            oParameters.addParameter("@date", NpgsqlDbType.Timestamp, dateN);

            DataSet dset = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                table = dset.Tables[0].Copy();
            }

            return table;
        }
        public DataTable report_order_not_finish()
        {

            DataTable table = null;

            Parameters oParameters = new Parameters();

            string sql = "select wo.consecutive as codigo, wo.vehicle as placa_vehiculo, cl.clientname as nombre_cliente, wo.state as estado, " +
                "wo.entrydate as entrada, wo.exitdate as salida, wo.costperorder as costo, em.employee_name as empleado " +
                "from workorder wo " +
                "join employee em  on wo.employee = em.employeecod "+
                "join vehicle ve on wo.vehicle = ve.vehicleid "+
                "join client cl on ve.client = cl.clientid "+
                "WHERE wo.state != @a and wo.state != @b;";

            oParameters.addParameter("@a", NpgsqlDbType.Varchar, "Finalizado");
            oParameters.addParameter("@b", NpgsqlDbType.Varchar, "Facturado");

            DataSet dset = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                table = dset.Tables[0].Copy();
            }

            return table;
        }
        public DataTable report_repair_per_employee(DateTime inicio, DateTime final, int empleado)
        {

            DataTable table = null;

            Parameters oParameters = new Parameters();

            string sql = "select wo.consecutive as codigo_orden, wo.billingdate as fecha, rc.description as descripcion, ro.reparationcost as costo " +
                "from reparationperorder ro " +
                "join workorder wo on ro.workorder = wo.consecutive "+
                "join employee em on ro.employee = em.employeecod "+
                "join reparationscatalogue rc on ro.reparationscatalogue = rc.consecutive " +
                "WHERE ( wo.billingdate >= @a and wo.billingdate <= @b ) and wo.employee = @c;";

            oParameters.addParameter("@a", NpgsqlDbType.Timestamp, inicio);
            oParameters.addParameter("@b", NpgsqlDbType.Timestamp, final);
            oParameters.addParameter("@c", NpgsqlDbType.Integer, empleado);

            DataSet dset = this.connection.executeSQLQuery(sql, "reparationperorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                table = dset.Tables[0].Copy();
            }

            return table;
        }
        public DataTable report_replacements()
        {

            DataTable table = null;

            Parameters oParameters = new Parameters();

            string sql = "select rc.replamentname as descripcion, ro.quantity as cantidad "+
            "from replacementperorder ro "+
            "join replacementcatalogue rc on ro.replacementcatalogue = rc.consecutive "+
            "where ro.quantity >= @a; ";

            oParameters.addParameter("@a", NpgsqlDbType.Integer, 1);

            DataSet dset = this.connection.executeSQLQuery(sql, "replacementperorder", oParameters.getParameter());
            if (!connection.IsError)
            {
                table = dset.Tables[0].Copy();
            }

            return table;
        }
    }

    
}
