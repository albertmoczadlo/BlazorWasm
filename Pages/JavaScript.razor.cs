using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWasm.Pages
{
    public partial class JavaScript
    {
        private bool _isConfigDialogVisible = false;
        private string _currentDate = "";
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

        [JSInvokable]
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private async Task ShowResultCSharp()
        {
            await JS.InvokeVoidAsync("addNumberCSharp", 11, 5);
        }

        [JSInvokable]
        public static string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }

        private async Task ShowDate()
        {
            _currentDate = await JS.InvokeAsync<string>("getCurrentDateCSharp");
        }
    }
}
