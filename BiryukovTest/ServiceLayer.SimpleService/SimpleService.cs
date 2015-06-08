using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SimpleService
{
    class SimpleService
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

    }
}
