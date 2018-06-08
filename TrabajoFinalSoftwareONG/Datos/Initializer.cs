using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinalSoftwareONG.Entidades;

namespace TrabajoFinalSoftwareONG.Datos
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Ciudadanía", Id = 1 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Extranjería", Id = 2 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Tarjeta de Identidad", Id = 3 });

            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 1, nombreMedicamento = "Acetaminofen" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 2, nombreMedicamento = "Dolex" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 3, nombreMedicamento = "Tiamina" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 4, nombreMedicamento = "Aspirina" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 5, nombreMedicamento = "Omeprazol" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 6, nombreMedicamento = "Salbutanol" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 7, nombreMedicamento = "Amoxicilina" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 8, nombreMedicamento = "Hidroxido de aluminia" });
            context.MedicamentosTomados.Add(new Medicamentos() { identificacionM = 9, nombreMedicamento = "Amitriptilina" });

            base.Seed(context);
        }
    }
}
