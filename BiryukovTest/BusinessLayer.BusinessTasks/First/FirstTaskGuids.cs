using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    [Export(typeof(IFirstTask<Guid, char>))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class FirstTaskGuids : IFirstTask<Guid, char>
    {
        public IFirstTaskResult<Guid> Calculate(IFirstTaskArguments<char> arguments)
        {
            var template = arguments.TemplateToSearch.GetTemplate();

            var sequenceToReview=

            var result = new FirstTaskResultGuids
            {
                Items = arguments.SequenceToReview.ItemsToReview.Where(guid => guid.RequirementIsMet(template))
            };

            return result;
        }
    }
}