using System.Collections.Generic;

namespace BusinessLayer.Contracts.Second
{
    public interface ISecondTaskArguments<TItem> : IBusinessTaskArguments
    {
        IList<TItem> Items { get; set; } 
    }
}
