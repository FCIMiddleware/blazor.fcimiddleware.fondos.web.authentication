using System.ComponentModel.DataAnnotations;

namespace blazor.fcimiddleware.fondos.web.authentication.Models
{
    public class AuthRequestViewModel
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        [StringLength(250, MinimumLength =  5, ErrorMessage = "El EMail debe estar entre 5 y 250 caracteres")]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(250, MinimumLength = 4, ErrorMessage = "La Contraseña debe estar entre 4 y 250 caracteres")]
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool RememberMe { get; set; } = false;

    }
}
