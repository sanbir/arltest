namespace BusinessLayer.Contracts.First
{
    public interface IFirstTask<TItemToReview, TSymbol>
        : IBusinessTask<IFirstTaskArguments<TSymbol>, IFirstTaskResult<TItemToReview>>
    {
    }
}