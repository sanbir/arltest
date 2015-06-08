using System;
using System.Collections.Generic;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    public class FirstTaskResultGuids : IFirstTaskResult<Guid>
    {
        public IEnumerable<Guid> Items { get; set; }
    }
}
