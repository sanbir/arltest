namespace BusinessLayer.Contracts.First
{
    public interface IFirstTaskArguments<in TSymbol> : IBusinessTaskArguments
    {
        TemplateToSearch TemplateToSearch { get; set; }

        int NumberOfItemsToReview { get; set; }

        void SetFirstTaskArguments(int numberOfSymbols, TSymbol symbol, int numberOfItemsToReview);
    }
}