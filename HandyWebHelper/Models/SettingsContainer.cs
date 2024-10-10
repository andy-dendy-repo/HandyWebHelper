using HandyWebHelper.Utility.Enums;

namespace HandyWebHelper.Models
{
    public class SettingsContainer
    {
        public SettingsContainer() 
        {
            _operations = Default;
        }

        public IDictionary<OperationType, ICollection<Operation>> Default
        {
            get => new Dictionary<OperationType, ICollection<Operation>>()
            {
                { OperationType.Paste,  new HashSet<Operation>() { Operation.PasteClipboard, Operation.PasteLocalFile, Operation.PasteUrlLink } }
                , { OperationType.Encode,  new HashSet<Operation>() { Operation.EncodeBase64, Operation.EncodeHTML, Operation.EncodeURL } }
                , { OperationType.Decode,  new HashSet<Operation>() { Operation.DecodeBase64, Operation.DecodeHTML, Operation.DecodeURL } }
                , { OperationType.Format,  new HashSet<Operation>() { Operation.FormatXML, Operation.FormatJSON, Operation.FormatHTML, Operation.FormarCss } }
                , { OperationType.Minify,  new HashSet<Operation>() { Operation.MinifyXML, Operation.MinifyJSON, Operation.MinifyHTML, Operation.MinifyCss } }
            };
        }

        private IDictionary<OperationType, ICollection<Operation>> _operations;

        public IDictionary<OperationType, ICollection<Operation>> Operations
        {
            get => _operations;
            set
            {
                _operations = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
