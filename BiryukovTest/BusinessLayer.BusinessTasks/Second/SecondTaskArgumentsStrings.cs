using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    public class SecondTaskArgumentsStrings : ISecondTaskArguments<string>
    {
        public IList<string> Items { get; set; }
    }
}
