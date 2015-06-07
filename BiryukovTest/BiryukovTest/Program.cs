using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts;

namespace BiryukovTest
{
    class Program
    {
        [Import]
        IBusinessTask _businessTaskFactory;

        static void Main(string[] args)
        {
            var typeOfTask = int.Parse(args[0]);

            switch (typeOfTask)
            {
                case 1:
                    var amountOfDigits = int.Parse(args[1]);
                    var desiredAmountOfResults = int.Parse(args[2]);

                    
                    break;
                case 2:
                    break;
            }

            var list = new List<Guid>
            {
                new Guid("5399cbaa-a0d5-4032-8bf8-ff4920ddc157"),
                new Guid("564733fc-920d-44de-9297-d5399e7642f8"),
                new Guid("345920d2-2c6d-5399-905d-f7f7a1ce8b0b")
            };

            var strings = list.Select(guid => guid.ToString("N")).ToList();

            var longestCommon = strings.GetLongestCommonSubstrings();

            foreach (var longestString in longestCommon)
            {
                Console.WriteLine(longestString);
            }

            Console.ReadLine();
        }
    }
}
