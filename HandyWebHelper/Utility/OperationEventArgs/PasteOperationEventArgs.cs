using HandyWebHelper.Utility.Enums;

namespace HandyWebHelper.Utility.OperationEventArgs
{
    public class PasteOperationEventArgs(Operation operation) : EventArgs
    {
        public Operation Operation {  get => operation; } 
    }
}
