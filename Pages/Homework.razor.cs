using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata;

namespace BlazorWasm.Pages
{
    public partial class Homework
    {
        private string _header;

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Header { get; set; }

        private void BackHome()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
