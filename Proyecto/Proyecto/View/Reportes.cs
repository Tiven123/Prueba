using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Reports;

namespace View
{
    public partial class Reportes : Form
    {
        private int consecutivo;
        private int tipo;
        private DateTime fecha;
        private DateTime fecha_inicio;
        private DateTime fecha_final;
        private int empleado;

        public Reportes(int tipoN)
        {
            InitializeComponent();
            this.tipo = tipoN;
            reporteN();
        }
        public Reportes(int consecutivoN, int tipoN)
        {
            InitializeComponent();
            this.consecutivo = consecutivoN;
            this.tipo = tipoN;
            reporteN();
        }
        public Reportes(int tipoN, DateTime fechaN)
        {
            InitializeComponent();
            this.fecha = fechaN;
            this.tipo = tipoN;
            reporteN();
        }
        public Reportes(int tipoN, DateTime fecha_inicioN, DateTime fecha_finalN, int empleadoN)
        {
            InitializeComponent();
            this.fecha_inicio = fecha_inicioN;
            this.fecha_final = fecha_finalN;
            this.empleado = empleadoN;
            this.tipo = tipoN;
            reporteN();
        }
        public void reporteN()
        {
            Model.ReportD oReportD = new Model.ReportD();
            if (tipo == 1)
            {
                rptWordOrderBilling oRPT = new rptWordOrderBilling();
                oRPT.Load();
                DataSet ds = oReportD.report_repair_per_order(consecutivo);
                oRPT.Database.Tables[0].SetDataSource(ds.Tables[0]);

                ds = oReportD.report_replacement_per_order(consecutivo);
                oRPT.Database.Tables[1].SetDataSource(ds.Tables[0]);

                ds = oReportD.report_work_order_billing(consecutivo);
                oRPT.Database.Tables[2].SetDataSource(ds.Tables[0]);

                this.crystalReportViewer1.ReportSource = oRPT;
            }

            if (tipo == 2)
            {
                rptOrderPerDay oRPT = new rptOrderPerDay();
                oRPT.SetDataSource(oReportD.report_order_per_day(fecha));
                this.crystalReportViewer1.ReportSource = oRPT;
            }
            if (tipo==3)
            {
                rptOrderNotFinish oRPT = new rptOrderNotFinish();
                oRPT.SetDataSource(oReportD.report_order_not_finish());
                this.crystalReportViewer1.ReportSource = oRPT;
            }
            if (tipo==4)
            {
                rptRepairPerEmployee oRPT = new rptRepairPerEmployee();
                oRPT.SetDataSource(oReportD.report_repair_per_employee(fecha_inicio, fecha_final, empleado));
                this.crystalReportViewer1.ReportSource = oRPT;
            }
            if (tipo==5)
            {
                rptReplacement oRPT = new rptReplacement();
                oRPT.SetDataSource(oReportD.report_replacements());
                this.crystalReportViewer1.ReportSource = oRPT;
            }
        }
    }
}
