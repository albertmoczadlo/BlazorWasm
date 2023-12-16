using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Models
{
    public class Item
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Description { get; set; }
        public State State { get; set; }
    }
}
