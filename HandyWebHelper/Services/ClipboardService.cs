using HandyWebHelper.Interfaces;
using Microsoft.JSInterop;

namespace HandyWebHelper.Services
{
    public class ClipboardService : IClipboardService
    {
        private readonly IJSRuntime _jsInterop;

        public ClipboardService(IJSRuntime jsInterop)
        {
            _jsInterop = jsInterop;
        }

        public async Task CopyToClipboard(string text)
        {
            await _jsInterop.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }

        public async Task<string> CopyFromClipboard()
        {
            try
            {
                return await _jsInterop.InvokeAsync<string>("navigator.clipboard.readText");
            }
            catch (Exception ex)
            {
                // Handle any error (like clipboard access restrictions)
                Console.WriteLine($"Error reading from clipboard: {ex.Message}");
                return string.Empty;
            }
        }
    }

}
