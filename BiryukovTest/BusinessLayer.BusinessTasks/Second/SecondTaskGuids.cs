using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    public class SecondTaskGuids : ISecondTask<Guid, string>
    {
        public ISecondTaskResult<string> Calculate(int numberOfGuids)
        {
            IList<Guid> guids = new List<Guid>();

            for (int i = 0; i < numberOfGuids; i++)
            {
                guids.Add(Guid.NewGuid());
            }

            return Calculate(new SecondTaskArgumentsGuids { Items = guids });
        }

        public ISecondTaskResult<string> Calculate(ISecondTaskArguments<Guid> arguments)
        {
            var result = new SecondTaskResultStrings
            {
                Items = arguments.Items.Select(guid => guid.ToString()),
                MaxCommonStrings = arguments.Items.Select(guid => guid.ToString("N")).ToList().GetLongestCommonSubstrings()
            };

            return result;
        }
    }
}
