using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.View;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegisterPosition_Click(object sender, EventArgs e)
        {
            Positions oPositions = new Positions();
            oPositions.ShowDialog();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            Employees oEmployees = new Employees();
            oEmployees.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clients oClients = new Clients();
            oClients.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
