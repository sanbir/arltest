using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTask<TItemToReview, out TSymbol>
        : IBusinessTask<IFirstTaskArguments<TSymbol>, IFirstTaskResult<TItemToReview>>
    {
    }
}