using System.Collections.Generic;

namespace BusinessLayer.Contracts.First
{
    public interface IFirstTaskArguments<in TSymbol> : IBusinessTaskArguments
    {
        TemplateToSearch TemplateToSearch { get; set; }

        void SetFirstTaskArguments(int numberOfSymbols, TSymbol symbol);
    }
}