using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using TrabajoFinalSoftwareONG.Entidades;
using TrabajoFinalSoftwareONG.Datos;



namespace Datos
{
    public class AccesoDatos
    {
        private static Context context = new Context();

        public static void IngresarPaciente(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            context.SaveChanges();
        }

        internal static List<TipoDocumento> ObtenerTiposDocumento()
        {
            return context.TiposDocumento.ToList();
        }

        internal static List<Medicamentos> ObtenerMedicamentos()
        {
            return context.MedicamentosTomados.ToList();
        }

        internal static List<Paciente> ObtenerPacientes()
        {
            return context.Pacientes.ToList();
        }

        
    }
}
