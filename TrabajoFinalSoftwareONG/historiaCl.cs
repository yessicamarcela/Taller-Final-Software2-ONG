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
using TrabajoFinalSoftwareONG.Entidades;

namespace TrabajoFinalSoftwareONG
{
    public partial class historiaCl : Form
    {
        public historiaCl()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            

            // VALIDAR NOMBRE
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpMensaje.SetError(txtNombre, "El nombre es obligatorio");
                MessageBox.Show("El nombre es obligatorio");
                return;
            }
            else
            {
                erpMensaje.SetError(txtNombre, "");
            }

            Entidades.Paciente paciente = new Entidades.Paciente();
            paciente.PrimerNombre = txtNombre.Text;
            paciente.SegundoNombre = txtSegundoNombre.Text;
            paciente.PrimerApellido = txtApellido.Text;
            paciente.SegundoApellido = txtSegundoApellido.Text;
            paciente.Departamento = txtDepartamento.Text;
            paciente.Ciudad = txtCiudad.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Analisis = txtAnalisis.Text;
            paciente.AlergiasSufridas = txtAlergias.Text;
            paciente.EnfermedadesPadecidas = txtEnfermedades.Text;
            paciente.Revisiones = txtRevisiones.Text;
            paciente.IdMedicamentos = (cbxMedicamentos.SelectedItem as Medicamentos).identificacionM;
            paciente.NumeroDocumento = Convert.ToInt64(txtNDocumento.Text);
            paciente.IdTipoDocumento = (cbxTipoDocumento.SelectedItem as TipoDocumento).Id;

            ControlPaciente.IngresarPaciente(paciente);

            MessageBox.Show("Paciente ingresado exitosamente");


           
            //Limpiamos cuadros de texto
            txtNombre.Text = "";
            txtNDocumento.Text = "";
            txtSegundoNombre.Text = "";
            txtApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtDepartamento.Text = "";
            txtCiudad.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtAnalisis.Text = "";
            txtAlergias.Text = "";
            txtEnfermedades.Text = "";
            txtRevisiones.Text = "";

           
        }

        private void historiaCl_Load(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumento = ControlPaciente.ObtenerTiposDocumento();
            cbxTipoDocumento.DataSource = tiposDocumento;
            cbxTipoDocumento.DisplayMember = "Nombre";

            List<Medicamentos> MedicamentosTomados = ControlPaciente.ObtenerMedicamentos();
            cbxMedicamentos.DataSource = MedicamentosTomados;
            cbxMedicamentos.DisplayMember = "nombreMedicamento";

        }

       

        private void txtNDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((int)e.KeyChar == 8 ||
                (int)e.KeyChar >= 48 && (int)e.KeyChar <= 59))
            {
                e.Handled = true;
            }

            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ListadoHistoriasCl form = new ListadoHistoriasCl();
            form.ShowDialog();
        }

        

        

     
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grpPaciente_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sólo permitir ingresar Letras 
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }


        }

        private void txtNDocumentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sólo permitir ingresar números 
            if (Char.IsNumber(e.KeyChar))
            { e.Handled = false; }

            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }

            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else
            { e.Handled = true; }

        }

       
        
    }
}