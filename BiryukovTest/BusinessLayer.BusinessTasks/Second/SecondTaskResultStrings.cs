﻿using System.Collections.Generic;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    public class SecondTaskResultStrings : ISecondTaskResult<string>
    {
        public IEnumerable<string> Items { get; set; }
        public IEnumerable<string> MaxCommonStrings { get; set; }
    }
}
