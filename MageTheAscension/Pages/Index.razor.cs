using BlazorDownloadFile;
using MageTheAscension.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;
using System.Text.Json;

namespace MageTheAscension.Pages
{
    public partial class Index : ComponentBase
    {
        public MageTheAscensionM20Sheet Sheet { get; set; } = new MageTheAscensionM20Sheet();
        [Inject] IBlazorDownloadFileService? BlazorDownloadFileService { get; set; }

        private async void DownloadFile()
        {
            string fileName = string.IsNullOrWhiteSpace(Sheet.Name.Text) ? "Unknown Character.mta" : Sheet.Name.Text + ".mta";
            string json = JsonSerializer.Serialize(Sheet);
            _ = await BlazorDownloadFileService!.DownloadFileFromText( fileName, json, System.Text.Encoding.Default, "application/octet-stream");
        }
        private async void UploadFile(IBrowserFile file)
        {
            using Stream stream = file.OpenReadStream(1024000 * 10);
            Sheet = await JsonSerializer.DeserializeAsync<MageTheAscensionM20Sheet>(stream) ?? Sheet;
            StateHasChanged();
        }
    }
}
