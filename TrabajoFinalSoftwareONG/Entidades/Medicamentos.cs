using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalSoftwareONG.Entidades
{
    [Table("MedicamentosTomados")]
    public class Medicamentos 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int identificacionM { get; set; }
        public string nombreMedicamento { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
