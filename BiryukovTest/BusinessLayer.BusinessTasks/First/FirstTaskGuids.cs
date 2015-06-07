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
            var template = arguments.TemplateToSearch.GetTemplate();

            var result = new FirstTaskResultGuids
            {
                Items = arguments.SequenceToReview.ItemsToReview.Where(guid => guid.RequirementIsMet(template))
            };

            return result;
        }

    }
}