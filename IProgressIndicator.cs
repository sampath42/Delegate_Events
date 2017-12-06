namespace Demo
{
    public interface IProgressIndicator
    {
        void Progress(string message, int progressPercentage);
    }
}
