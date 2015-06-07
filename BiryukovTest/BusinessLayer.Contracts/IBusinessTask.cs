namespace BusinessLayer.Contracts
{
    public interface IBusinessTask<in TTaskArguments, out TTaskResult>
    {
        TTaskResult Calculate(TTaskArguments arguments);
    }
}