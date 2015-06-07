using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    public class FirstTaskResultGuids : IFirstTaskResult<Guid>
    {
        public IEnumerable<Guid> Items { get; set; }
    }
}
