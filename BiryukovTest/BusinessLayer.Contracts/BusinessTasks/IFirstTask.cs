using System.Collections.Generic;

namespace BusinessLayer.Contracts.BusinessTasks
{
    public interface IFirstTask<TItemToReview, TSymbol>
        : ICalculate<IFirstTaskArguments<TItemToReview, TSymbol>, IEnumerable<TItemToReview>>
    {
    }
}