using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    [Export(typeof(IFirstTaskArguments<Guid, char>))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class FirstTaskArgumentsGuidChar : IFirstTaskArguments<Guid, char>
    {
        public TemplateToSearch TemplateToSearch { get; set; }
        public IEnumerable<Guid> ItemsToReview { get; set; }
        public void SetFirstTaskArguments(int numberOfSymbols, char symbol, int numberOfItemsToReview)
        {
            TemplateToSearch = new TemplateToSearch(numberOfSymbols, symbol);

            var itemsToReview = new List<Guid>(numberOfItemsToReview);
            for (int i = 0; i < numberOfItemsToReview; i++)
            {
                itemsToReview.Add(Guid.NewGuid());
            }
            ItemsToReview = itemsToReview;
        }

    }

}