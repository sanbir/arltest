using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    [Export(typeof(IFirstTaskArguments<char>))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class FirstTaskArgumentsGuidChar : IFirstTaskArguments<char>
    {
        public TemplateToSearch TemplateToSearch { get; set; }
        public void SetFirstTaskArguments(int numberOfSymbols, char symbol)
        {
            TemplateToSearch = new TemplateToSearch(numberOfSymbols, symbol);
        }
    }

}