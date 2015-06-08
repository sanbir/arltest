using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts.First
{
    public class SequenceToReview<TItemToReview>
    {
        public int NumberOfItems { get; set; }
        public IEnumerable<TItemToReview> ItemsToReview { get; set; }
    }
}
