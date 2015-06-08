namespace BusinessLayer.Contracts.Second
{
    public interface ISecondTask<TInputItem, TOutputItem>
        : IBusinessTask<ISecondTaskArguments<TInputItem>, ISecondTaskResult<TOutputItem>>
    {
        ISecondTaskResult<string> Calculate(int numberOfGuids);
    }
}