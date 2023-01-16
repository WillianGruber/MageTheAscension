using MageTheAscension.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MageTheAscension.Components
{
    public partial class RatingColumn : ComponentBase
    {
        [Parameter] public string? Title { get; set; }
        [Parameter] public List<Characteristic>? Characteristics { get; set; }
    }
}