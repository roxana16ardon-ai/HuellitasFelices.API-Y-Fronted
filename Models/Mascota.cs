using System.ComponentModel.DataAnnotations;

namespace HuellitasFelices.API.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar 50 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La especie es obligatoria")]
        public string Especie { get; set; } = string.Empty; // Ej: Perro, Gato, Ave

        public string? Raza { get; set; }

        [Range(0, 1200, ErrorMessage = "La edad debe ser mayor o igual a 0")]
        public int EdadMeses { get; set; }

        public string? Descripcion { get; set; }

        public DateTime FechaIngreso { get; set; } = DateTime.Now;

        public bool Adoptado { get; set; } = false;
    }
}