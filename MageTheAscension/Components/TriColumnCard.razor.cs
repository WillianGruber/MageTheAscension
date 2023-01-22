using MageTheAscension.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MageTheAscension.Components
{
    public partial class TriColumnCard : ComponentBase
    {
        [Parameter] public string? HeaderTitle { get; set; }
        [Parameter] public string? LeftColumnTitle { get; set; }
        [Parameter] public string? MidColumnTitle { get; set; }
        [Parameter] public string? RightColumnTitle { get; set; }
        [Parameter] public List<Characteristic>? LeftColumn { get; set; }
        [Parameter] public List<Characteristic>? MidColumn { get; set; }
        [Parameter] public List<Characteristic>? RightColumn { get; set; }
    }
}