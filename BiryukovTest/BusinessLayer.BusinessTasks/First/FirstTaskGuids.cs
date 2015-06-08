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
        public IFirstTaskResult<Guid> Calculate(IFirstTaskArguments<Guid, char> arguments)
        {
            var template = arguments.TemplateToSearch.GetTemplate();

            var resultList = new List<Guid>();
            int currentNumberOfItems = 0;
            foreach (var guid in GetItemsToReview())
            {
                if (guid.RequirementIsMet(template))
                {
                    ++currentNumberOfItems;
                    resultList.Add(guid);
                }
                if (currentNumberOfItems == arguments.NumberOfItemsToReview) break;
            }

            var result = new FirstTaskResultGuids
            {
                Items = resultList
            };

            return result;
        }

        private static IEnumerable<Guid> GetItemsToReview()
        {
            while (true)
            {
                yield return Guid.NewGuid();
            }
        }
    }
}