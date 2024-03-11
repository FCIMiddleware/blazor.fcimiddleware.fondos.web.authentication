using blazor.fcimiddleware.fondos.web.authentication.Models;
using Microsoft.AspNetCore.Components;

namespace blazor.fcimiddleware.fondos.web.authentication.Pages
{
    public partial class ForgotPassword
    {
        private RecoveryRequestViewModel recoveryRequestViewModel = new RecoveryRequestViewModel();
        public NavigationManager navigationManager { get; set; }
        public bool EstaProcesando { get; set; }
        public bool ReadTerms { get; set; }
        public bool HayErrores { get; set; }
        public string MensajeErrores { get; set; }
        public string UrlRetorno { get; set; }

        private void OnValidSubmit()
        {

            if (ReadTerms)
            {
                HayErrores = false;
                MensajeErrores = string.Empty;
                navigationManager.NavigateTo("/home");
            }
            else
            {
                HayErrores = true;
                if (!ReadTerms)
                {
                    MensajeErrores = "Debe aceptar terminos y condiciones";
                }
                else
                {

                    MensajeErrores = "algun error del back";
                }

            }
        }
    }
}
