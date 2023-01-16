using Microsoft.AspNetCore.Components;

namespace MageTheAscension.Components
{
    public partial class Rating : ComponentBase
    {
        [Parameter] public string? Label { get; set; }
        [Parameter] public string? Text { get => _text; set { if (value == _text) return; _text = value; TextChanged.InvokeAsync(value); } }
        [Parameter] public EventCallback<string?> TextChanged { get; set; }
        [Parameter] public int? Value { get => _value; set { if (value == _value) return; _value = value; ValueChanged.InvokeAsync(value); } }
        [Parameter] public EventCallback<int?> ValueChanged { get; set; }

        private int? _value;
        private string? _text;
    }
}
