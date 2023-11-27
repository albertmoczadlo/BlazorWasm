using Microsoft.JSInterop;

namespace BlazorWasm.Services
{
    public class ToastService
    {
        private IJSRuntime _jsRuntime;

        public ToastService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public async Task ShowInfoMessage(string message)
        {
            await _jsRuntime.InvokeVoidAsync("toastrFunctions.showToastrInfo", message);
        }
    }
}
