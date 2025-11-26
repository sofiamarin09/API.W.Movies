using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models.Dtos
{
    public class MovieCreateUpdateDto
    {
        [Required(ErrorMessage = "El nombre de la película es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "La duración es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La duración debe ser un entero positivo.")]
        public int Duration { get; set; }

        [MaxLength(2000, ErrorMessage = "El número máximo de caracteres es de 2000.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "La clasificación es obligatoria.")]
        [MaxLength(10, ErrorMessage = "El número máximo de caracteres es de 10.")]
        public string Classification { get; set; } = null!;
    }
}