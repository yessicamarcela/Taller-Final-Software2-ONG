using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoFinalSoftwareONG.Control
{
    public class ControlPaciente
    {
        public static void IngresarPaciente(Entidades.Paciente paciente)
        {
            AccesoDatos.IngresarPaciente(paciente);
        }

        internal static List<Entidades.TipoDocumento> ObtenerTiposDocumento()
        {
            return AccesoDatos.ObtenerTiposDocumento();
        }

        internal static List<Entidades.Medicamentos> ObtenerMedicamentos()
        {
            return AccesoDatos.ObtenerMedicamentos();
        }

        internal static List<Entidades.Paciente> ObtenerPacientes()
        {
            return AccesoDatos.ObtenerPacientes();
        }
    }
}
