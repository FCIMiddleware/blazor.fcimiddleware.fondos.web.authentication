using System.ComponentModel.DataAnnotations;

namespace blazor.fcimiddleware.fondos.web.authentication.Models
{
    public class RegisterRequestViewModel
    {
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(250, ErrorMessage = "El {0} debe estar entre al menos {2} caracteres de longitud", MinimumLength = 5)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [StringLength(250, ErrorMessage = "El {0} debe estar entre al menos {2} caracteres de longitud", MinimumLength = 5)]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El EMail es obligatorio")]
        [StringLength(250, ErrorMessage = "El {0} debe estar entre al menos {2} caracteres de longitud", MinimumLength = 5)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(80, ErrorMessage = "El {0} debe estar entre al menos {2} caracteres de longitud", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "La confirmación de contraseña es obligatoria")]
        [Compare("Password", ErrorMessage = "La contraseña y confirmación de contraseña no coinciden")]
        [StringLength(80, ErrorMessage = "El {0} debe estar entre al menos {2} caracteres de longitud", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
