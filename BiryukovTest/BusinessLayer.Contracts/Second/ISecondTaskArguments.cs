using System.Collections.Generic;

namespace BusinessLayer.Contracts.Second
{
    public interface ISecondTaskArguments<TItem>
    {
        IList<TItem> Items { get; set; } 
    }
}
