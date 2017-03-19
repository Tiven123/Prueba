using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.view;
using Proyecto.View;

namespace Proyecto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
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
            oClients.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            Brands oBrands = new Brands();
            oBrands.Show();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            Vehicles oVehicles = new Vehicles();
            oVehicles.Show();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            Models oModels = new Models();
            oModels.Show();
        }

        private void btnRepairs_Click(object sender, EventArgs e)
        {
            Repairs oRepairs = new Repairs();
            oRepairs.Show();
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            Replacements oReplacements = new Replacements();
            oReplacements.Show();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
