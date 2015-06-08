using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTaskArguments<TItemToReview, TSymbol> : IBusinessTaskArguments
    {
        TemplateToSearch TemplateToSearch { get; set; }

        IEnumerable<TItemToReview> ItemsToReview { get; set; }

        void SetFirstTaskArguments(int numberOfSymbols, TSymbol symbol, int numberOfItemsToReview);
    }
}