using MudBlazor;

namespace MageTheAscension
{
    public class ThemeService
    {
        public MudThemeProvider? MudThemeProvider { get; set; }
        public bool DarkMode { get; set; }
        public void ToggleDarkMode()
        {
            MudThemeProvider!.IsDarkMode = !MudThemeProvider.IsDarkMode;
        }
    }
}
