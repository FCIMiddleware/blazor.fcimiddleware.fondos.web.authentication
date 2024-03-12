using System.ComponentModel.DataAnnotations;

namespace blazor.fcimiddleware.fondos.web.authentication.Models
{
    public class RecoveryRequestViewModel
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
