using System;
using System.Collections.Generic;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    public class FirstTaskArgumentsGuidChar : IFirstTaskArguments<Guid, char>
    {
        public int NumberOfItemsToReview { get; set; }
        public IEnumerable<Guid> ItemsToReview { get; set; }

        public int NumberOfSymbols { get; set; }
        public char Symbol { get; set; }

        public FirstTaskArgumentsGuidChar(int numberOfGuidsToReview, IEnumerable<Guid> guidsToReview, int numberOfSymbols, char symbol)
        {
            NumberOfItemsToReview = numberOfGuidsToReview;
            ItemsToReview = guidsToReview;
            NumberOfSymbols = numberOfSymbols;
            Symbol = symbol;
        }
    }
}