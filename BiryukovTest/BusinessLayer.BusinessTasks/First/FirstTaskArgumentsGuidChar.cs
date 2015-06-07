using System;
using System.Collections.Generic;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BusinessLayer.BusinessTasks.First
{
    public class FirstTaskArgumentsGuidChar : IFirstTaskArguments<Guid, char>
    {
        public ITemplateToSearch TemplateToSearch { get; set; }
        public ISequenceToReview<Guid> SequenceToReview { get; set; }
    }


}