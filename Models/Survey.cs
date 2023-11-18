#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2, ErrorMessage = "El nombre debe tener un largo mínimo de 2")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La ubicación es requerida")]
        public string Location { get; set; }

        [Required(ErrorMessage = "El lenguaje es Requerido")]
        public string Language { get; set; }

        [MaxLength(20, ErrorMessage = "El largo máximo del comentario debe ser de 20 caracteres")]
        public string Comment { get; set; }
    }
}