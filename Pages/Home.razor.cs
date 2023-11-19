using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Pages
{
    public partial class Home
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private void BackHomework()
        {
            NavigationManager.NavigateTo("/homework-parametr/parametr");
        }
    }
}
