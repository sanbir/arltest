using System;

namespace BusinessLayer.Contracts.First
{
    public struct TemplateToSearch
    {
        public int NumberOfSymbols;
        public char Symbol;

        public TemplateToSearch(int numberOfSymbols, char symbol)
        {
            NumberOfSymbols = numberOfSymbols;
            Symbol = symbol;
        }

        public string GetTemplate()
        {
            return new String(Symbol, NumberOfSymbols);
        }
    }
}