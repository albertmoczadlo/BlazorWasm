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
        public string BtnText { get; set; }

        [Parameter]
        public string Content { get; set; }

        [Parameter]
        public EventCallback OnClickMore { get; set; }

        [Parameter]
        public string Style { get; set; }

        [Parameter]
        public string BtnClass { get; set; } = "btn btn-danger";

        [Parameter]
        public bool BtnDisable { get; set; }

        [Parameter]
        public string BtnTitle { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string,object> BtnAttributes { get; set; }

        private void ClickMore(MouseEventArgs e)
        {
            OnClickMore.InvokeAsync();
        }
    }
}
