using System.Collections.Generic;

namespace BusinessLayer.Contracts.Second
{
    public interface ISecondTaskArguments<TInputItem> : IBusinessTaskArguments
    {
        IList<TInputItem> Items { get; set; } 
    }
}
