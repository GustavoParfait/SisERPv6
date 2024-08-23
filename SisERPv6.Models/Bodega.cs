using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisERPv6.Models
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Dato Nombre es Obligatorio")]
        [MaxLength(30, ErrorMessage = "Supero el maximo de 30 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Dato Descripcion es Obligatorio")]
        [MaxLength(60, ErrorMessage = "Supero el maximo de 60 caracteres")]
        public string Descripcion { get; set; }

        public Boolean Estado { get; set; }
    }
}
