using BlazorWasm.Components;
using BlazorWasm.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorWasm.Pages
{
    public partial class Component
    {
        private string _info = "Komunikat 123";
        private string _title = "Tytuł!";
        private string _btnText = "Więcej";
        private Card _card;
        private bool _showDialog = false;

        private Dictionary<string, object> _cardBtnAttributes = new()
        {
            { "class", "btn btn-success" },
            { "type", "button" },
            { "disabled", false },
            { "title", "Więcej" }
        };

        private Dictionary<string, object> _cardAttributes = new()
        {
            { "B", "btn btn-primary" },
            { "type", "button" },
            { "disabled", false },
            { "title", "Więcej informacji" }
        };

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private List<CardModel> _authors = [

                new CardModel
                {
                    Title = "Krzysztof Klos",
                    Content = "Podczas spaceru przez stary las, pełen tajemniczych dźwięków " +
                "i zapachów, poczułem niesamowitą bliskość z naturą i jej pięknem.",
                    Image = "/files/kowalski.png",
                    BtnText = "Więcej"
                },
                new CardModel
                {
                    Title = "Jan Kowalski",
                    Content = "Podczas spaceru przez stary las, pełen tajemniczych dźwięków " +
                    "i zapachów, poczułem niesamowitą bliskość z naturą i jej pięknem.",
                    Image = "/files/kwiatkowski.png",
                    BtnText = "Więcej"
                },
                new CardModel
                {
                    Title = "Olo Golk",
                    Content = "Podczas spaceru przez stary las, pełen tajemniczych dźwięków " +
                    "i zapachów, poczułem niesamowitą bliskość z naturą i jej pięknem.",
                    Image = "/files/nowak.png",
                    BtnText = "Więcej"
                }

        ];

        private void ClickMore()
        {
            NavigationManager.NavigateTo("/");
        }

        private void ShowDialog()
        {
            _showDialog = true;
        }

        private void ModalAccept(MouseEventArgs e)
        {
            //logika
            Console.WriteLine("Operacja została zatwierdzona!!!!!");
            _showDialog = false;
        }

        private void ModalCancel(MouseEventArgs e)
        {
            _showDialog = false;
        }

        //private Dictionary<string, object> _cardBtnAttributes = new Dictionary<string, object>
        //{
        //    { "class", "btn btn-primary" },
        //    { "type", "button" },
        //    { "disabled", false },
        //    { "title", "Więcej informacji" }
        //};


    }
}
