using System.Collections.Generic;

namespace BusinessLayer.Contracts
{
    public interface IFirstTaskArguments<TItemToReview, TSymbol>
    {
        int NumberOfItemsToReview { get; set; }
        IEnumerable<TItemToReview> ItemsToReview { get; set; }

        int NumberOfSymbols { get; set; }
        TSymbol Symbol { get; set; }
    }
}