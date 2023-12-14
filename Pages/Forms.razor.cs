using BlazorWasm.Models;
using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BlazorWasm.Pages
{
    public partial class Forms
    {
        [Inject]
        public ToastService ToastService { get; set; }

        private bool _isLoading = false;
        private Employee _employee = new Employee()
        {
            DateOfEmployment = DateTime.Now
        };

        private IEnumerable<Position> _positions =

        [
            new Position { Id = 1, Name = "IT" },
            new Position { Id = 2, Name = "Kierownik" },
            new Position { Id = 3, Name = "Kierowca" },
            new Position { Id = 4, Name = "Magazynier" }
        ];

        private async Task Save()
        {

            try
            {
                _isLoading = true;

                await Task.Delay(3000);

                var json = JsonConvert.SerializeObject(_employee);

                await ToastService.ShowInfoMessage($"Dane zostały zapisane. " +
                    $"Użytkownik: {json}");

                _employee = new Employee()
                {
                    DateOfEmployment = DateTime.Now
                };
            }
            finally
            {
                _isLoading = false;
            }

        }
    }
}
