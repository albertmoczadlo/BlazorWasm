using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Components
{
    public partial class Card
    {
        [Parameter]
        public string Image { get; set; }

        [Parameter]
        public RenderFragment Title { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public string BtnText { get; set; }

        [Parameter]
        public EventCallback OnClickMore { get; set; }

        private void ClickMore(MouseEventArgs e)
        {
            OnClickMore.InvokeAsync();
        }
    }
}
