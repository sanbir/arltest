using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTaskArguments<TItemToReview, TSymbol> : IBusinessTaskArguments
    {
        ITemplateToSearch TemplateToSearch { get; set; }

        ISequenceToReview<TItemToReview> SequenceToReview { get; set; }
    }
}