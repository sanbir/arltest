namespace BusinessLayer.Contracts
{
    public interface IBusinessTask { }

    public interface IBusinessTask<in TTaskArguments, out TTaskResult> : IBusinessTask
        where TTaskArguments : IBusinessTaskArguments
        where TTaskResult : IBusinessTaskResult
    {
        TTaskResult Calculate(TTaskArguments arguments);
    }
}