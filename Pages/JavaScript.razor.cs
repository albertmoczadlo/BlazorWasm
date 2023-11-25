using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWasm.Pages
{
    public partial class JavaScript
    {
        private bool _isConfigDialogVisible = false;
        [Inject]
        public IJSRuntime JS { get; set; }

        private async Task CallJs()
        {
            await JS.InvokeVoidAsync("alert", "Hello World");
        }

        private async Task DisplayConfigDialog()
        {
            _isConfigDialogVisible = await JS.InvokeAsync<bool>("confirm", "Czy na pewno chcesz usunąć");
        }

        private async Task ShowResultJs()
        {
            await JS.InvokeVoidAsync("addNumber", 2, 5);
        }
    }
}
