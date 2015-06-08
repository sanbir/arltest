using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    public class SecondTaskArgumentsGuids : ISecondTaskArguments<Guid>
    {
        public IList<Guid> Items { get; set; }
        public int MinNumberOfStringsToCount { get; set; }
    }
}
