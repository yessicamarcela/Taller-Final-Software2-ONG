using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinalSoftwareONG.Control;

namespace TrabajoFinalSoftwareONG
{
    public partial class ListadoHistoriasCl : Form
    {
        public ListadoHistoriasCl()
        {
            InitializeComponent();
        }

        private void ListadoHistoriasCl_Load(object sender, EventArgs e)
        {
            dgvListado.AutoGenerateColumns = false;
            List<Entidades.Paciente> pacientes = ControlPaciente.ObtenerPacientes();
            dgvListado.DataSource = pacientes;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
