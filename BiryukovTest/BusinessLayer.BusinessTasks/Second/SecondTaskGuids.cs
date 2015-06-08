using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    [Export(typeof(ISecondTask<Guid, string>))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class SecondTaskGuids : ISecondTask<Guid, string>
    {
        public ISecondTaskResult<string> Calculate(int numberOfGuids, int minNumberOfStringsToCount)
        {
            IList<Guid> guids = new List<Guid>();

            //for (int i = 0; i < numberOfGuids; i++)
            //{
            //    guids.Add(Guid.NewGuid());
            //}
            guids.Add(new Guid("5399cbaa-a0d5-4032-8bf8-ff4920ddc157"));
            guids.Add(new Guid("564733fc-920d-44de-9297-d5399e7642f8"));
            guids.Add(new Guid("345920d2-2c6d-5399-905d-f7f7a1ce8b0b"));
            guids.Add(new Guid("345920A2-2c6d-5399-905d-f7f7a1ce8b0b"));

            return
                Calculate(new SecondTaskArgumentsGuids
                {
                    Items = guids,
                    MinNumberOfStringsToCount = minNumberOfStringsToCount
                });
        }

        public ISecondTaskResult<string> Calculate(ISecondTaskArguments<Guid> arguments)
        {
            var result = new SecondTaskResultStrings
            {
                Items = arguments.Items.Select(guid => guid.ToString()),
                MaxCommonStrings = arguments.Items
                .Select(guid => guid.ToString("N"))
                .ToList()
                .GetLongestCommonSubstrings(arguments.MinNumberOfStringsToCount)
            };

            return result;
        }
    }
}
