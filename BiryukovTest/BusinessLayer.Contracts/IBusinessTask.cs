namespace BusinessLayer.Contracts
{
    public interface IBusinessTask<in TTaskArguments, out TTaskResult>
        where TTaskArguments : IBusinessTaskArguments
        where TTaskResult : IBusinessTaskResult
    {
        TTaskResult Calculate(TTaskArguments arguments);
    }
}