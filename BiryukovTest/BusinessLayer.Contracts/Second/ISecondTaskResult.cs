using System.Collections.Generic;

namespace BusinessLayer.Contracts.Second
{
    public interface ISecondTaskResult<TOutputItem> : IBusinessTaskResult
    {
        IEnumerable<TOutputItem> Items { get; set; }
        IEnumerable<string> MaxCommonStrings { get; set; }
    }
}
