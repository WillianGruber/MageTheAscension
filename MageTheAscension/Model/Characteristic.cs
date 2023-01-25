using MudBlazor;

namespace MageTheAscension.Model
{
    public class Characteristic
    {
        public string? Label { get; set; }
        public string? Text { get; set; }
        public int? Value { get; set; }
        public int? MaxValue { get; set; } = 5;
        public string? FullIcon { get; set; } = Icons.Material.Filled.Circle;
        public string? EmptyIcon { get; set; } = Icons.Material.Outlined.Circle;
        public string Color { get; set; } = Colors.Shades.Black;
    }
}
