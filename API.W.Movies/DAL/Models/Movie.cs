using System;
using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        // Id, CreatedDate y ModifiedDate vienen de AuditBase

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; } = null!; // [1] Not nullable

        [Required(ErrorMessage = "La duración es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La duración debe ser un entero positivo.")]
        public int Duration { get; set; } // [1] Not nullable (minutos)

        [MaxLength(2000, ErrorMessage = "El número máximo de caracteres es de 2000.")]
        public string? Description { get; set; } // [0..1] Nullable

        [Required(ErrorMessage = "La clasificación es obligatoria.")]
        [MaxLength(10, ErrorMessage = "El número máximo de caracteres es de 10.")]
        public string Classification { get; set; } = null!; // [1] Not nullable
    }
}