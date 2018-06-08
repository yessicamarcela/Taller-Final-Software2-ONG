using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalSoftwareONG.Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public long NumeroDocumento { get; set; }
        public string Telefono {get;set;}
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Analisis { get; set; }
        public string Revisiones { get; set; }
        public string AlergiasSufridas { get; set; }
        public string EnfermedadesPadecidas { get; set; }

        
        
        public int IdMedicamentos { get; set; }
        public virtual Medicamentos Medicamentos { get; set; }
        
        public int IdTipoDocumento { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }


    }
}
