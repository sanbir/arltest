using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTaskResult<TItemToReview> : IBusinessTaskResult
    {
        IEnumerable<TItemToReview> Items { get; set; }
    }
}
