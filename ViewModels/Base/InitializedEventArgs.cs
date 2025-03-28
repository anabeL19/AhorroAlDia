namespace SmartSave.ViewModels.Base
{
    public class InitializedEventArgs : EventArgs
    {
        public object Data { get; set; }
        public InitializedEventArgs()
        {
        }
        public InitializedEventArgs(object data)
        {
            Data = data;
        }
    }
}
