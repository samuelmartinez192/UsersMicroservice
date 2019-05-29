using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsersMicroservice.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public int NumMatricula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public char Sexo { get; set; }
        public string Ingreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Modifica { get; set; }
        public DateTime FechaModifica { get; set; }
        public bool Estatus { get; set; }
    }
}
