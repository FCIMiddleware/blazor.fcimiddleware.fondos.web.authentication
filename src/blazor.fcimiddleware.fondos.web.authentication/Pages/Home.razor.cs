
using blazor.fcimiddleware.fondos.web.authentication.Models;
using Microsoft.AspNetCore.Components;

namespace blazor.fcimiddleware.fondos.web.authentication.Pages
{
    public partial class Home
    {
        private AuthRequestViewModel authRequestViewModel = new AuthRequestViewModel();
        public NavigationManager navigationManager { get; set; }
        public bool EstaProcesando { get; set; }
        public bool HayErrores { get; set; }
        public string MensajeErrores { get; set; }
        public string UrlRetorno { get; set; }

        private void OnValidSubmit()
        {
            
            if (authRequestViewModel.Email == "admin@mail.com" && authRequestViewModel.Password == "admin")
            {
                HayErrores = false;
                MensajeErrores = string.Empty;
                navigationManager.NavigateTo("/");
            }
            else
            {
                HayErrores = true;
                MensajeErrores = "algun error del back";
            }
        }
    }
}
