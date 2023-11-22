using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="Nombre debe tener un maximo de 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Una Descripcion es Requerida")]
        [MaxLength(100, ErrorMessage = "La Descripcion debe tener un maximo de 100 caracteres")]
        public string Descripcion { get; set;}
        [Required(ErrorMessage = "El Estado es Requerida")]
        public bool Estado { get; set;}
    }
}
