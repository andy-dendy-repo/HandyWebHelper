namespace HandyWebHelper.Interfaces
{
    public interface IClipboardService
    {
        public Task CopyToClipboard(string text);

        public Task<string> CopyFromClipboard();
    }
}
