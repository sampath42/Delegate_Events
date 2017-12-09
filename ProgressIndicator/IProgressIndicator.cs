namespace Delegate_Events.ProgressIndicator
{
    public interface IProgressIndicator
    {
        void Progress(string message, int progressPercentage);
    }
}
