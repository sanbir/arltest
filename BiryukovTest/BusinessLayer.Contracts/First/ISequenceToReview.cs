using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface ISequenceToReview<TItemToReview>
    {
        IEnumerable<TItemToReview> ItemsToReview { get; set; }
        int NumberOfItemsToReview { get; set; }
    }
}