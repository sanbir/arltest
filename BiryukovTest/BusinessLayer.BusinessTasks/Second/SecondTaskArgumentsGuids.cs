using System;
using System.Collections.Generic;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    public class SecondTaskArgumentsGuids : ISecondTaskArguments<Guid>
    {
        public IList<Guid> Items { get; set; }
    }
}
