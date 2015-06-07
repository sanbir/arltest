using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTaskResult<TItemToReview> : IBusinessTaskResult
    {
        IEnumerable<TItemToReview> Items { get; set; }
    }
}
