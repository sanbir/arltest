namespace BusinessLayer.Contracts
{
    public interface IBusinessTaskFactory
    {
        TBusinessTask GetBusinessTask<TBusinessTask>() where TBusinessTask : IBusinessTask;
    }
}
