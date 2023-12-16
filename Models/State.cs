﻿using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Models
{
    public enum State
    {
        [Display(Name = "Nowy")]
        New,
        [Display(Name = "Aktywny")]
        Active,
        [Display(Name = "Zakończony")]
        Closed
    }
}
