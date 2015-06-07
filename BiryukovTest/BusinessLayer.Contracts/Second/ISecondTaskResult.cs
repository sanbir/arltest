using System.Collections.Generic;

namespace BusinessLayer.Contracts.Second
{
    public interface ISecondTaskResult<TItem> : IBusinessTaskResult
    {
        IEnumerable<TItem> Items { get; set; }
        IEnumerable<string> MaxCommonStrings { get; set; }
    }
}
