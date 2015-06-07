using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTask<TItemToReview, TSymbol>
        : IBusinessTask<IFirstTaskArguments<TItemToReview, TSymbol>, IFirstTaskResult<TItemToReview>>
    {
    }
}