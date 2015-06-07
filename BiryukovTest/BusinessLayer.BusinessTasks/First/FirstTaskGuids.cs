using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    public class FirstTaskGuids : IFirstTask<Guid, char>
    {
        public IFirstTaskResult<Guid> Calculate(IFirstTaskArguments<Guid, char> arguments)
        {
            var template = new String(arguments.Symbol, arguments.NumberOfSymbols);

            var result = new FirstTaskResultGuids
            {
                Items = arguments.ItemsToReview.Where(guid => RequirementIsMet(guid, template))
            };

            return result;
        }

        private static bool RequirementIsMet(Guid guid, string template)
        {
            var guidString = guid.ToString("N");
            if (guidString.Contains(template)) return true;
            return false;
        }
    }
}