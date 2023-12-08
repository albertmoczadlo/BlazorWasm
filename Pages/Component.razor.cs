using BlazorWasm.Components;
using BlazorWasm.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWasm.Pages
{
    public partial class Component
    {
        private string _info = "Komunikat 123";
        private string _title = "Tytuł!";
        private string _btnText = "Więcej";
        private Card _card;

        public List<CardModel> _authors = new List<CardModel>()
        {
              new CardModel
            {
                Title = "Krzysztof Klos",
                 Content = "Podczas spaceru przez stary las, pełen tajemniczych dźwięków " +
                "i zapachów, poczułem niesamowitą bliskość z naturą i jej pięknem.",
                Image = "/files/Krzysztof.png",
                BtnText = "Więcej"
            },
             new CardModel
             {
                Title = "Jan Kowalski",
                Content = "Podczas spaceru przez stary las, pełen tajemniczych dźwięków " +
                "i zapachów, poczułem niesamowitą bliskość z naturą i jej pięknem.",
                Image = "/files/Jan-kowalski.png",
                BtnText = "Więcej"
            },
              new CardModel
              {
                Title = "Olo Golk",
                Content = "Podczas spaceru przez stary las, pełen tajemniczych dźwięków " +
                "i zapachów, poczułem niesamowitą bliskość z naturą i jej pięknem.",
                Image = "/files/Olo.png",
                BtnText = "Więcej"
            }
        };

        public NavigationManager NavigationManager { get; set; }
        private void ClickMore()
        {
            NavigationManager.NavigateTo("/");
        }

        private Dictionary<string, object> _cardBtnAttributes = new Dictionary<string, object>
        {
            { "class", "btn btn-primary" },
            { "type", "button" },
            { "disabled", false },
            { "title", "Więcej informacji" }
        };


        //private Dictionary<string, object> _cardsAttribute = new()
        //{
        //    { "class", "btn btn-success" },
        //    { "type", "button" },
        //    { "disabled", false },
        //    { "title", "Więcej" }
        //};
    }
}
