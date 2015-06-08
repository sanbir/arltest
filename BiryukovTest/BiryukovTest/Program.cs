using System;
using BusinessLayer.Contracts.First;
using BusinessLayer.Contracts.Second;

namespace BiryukovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = MefLoader.GetMefContainer();

            var typeOfTask = int.Parse(args[0]);

            switch (typeOfTask)
            {
                case 1:
                    FirstTaskInput firstTaskInput;
                    firstTaskInput.AmountOfDigits = int.Parse(args[1]);
                    firstTaskInput.DesiredAmountOfResults = int.Parse(args[2]);

                    var firstTaskArguments = container.GetExportedValue<IFirstTaskArguments<Guid, char>>();
                    firstTaskArguments.SetFirstTaskArguments(firstTaskInput.AmountOfDigits, '0', firstTaskInput.DesiredAmountOfResults);
                    var firstTaskGuids = container.GetExportedValue<IFirstTask<Guid, char>>();
                    var firstTaskresult = firstTaskGuids.Calculate(firstTaskArguments);

                    foreach (var item in firstTaskresult.Items)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 2:
                    SecondTaskInput secondTaskInput;
                    secondTaskInput.NumberOfGuids = int.Parse(args[1]);

                    var secondTaskGuids = container.GetExportedValue<ISecondTask<Guid, string>>();
                    var secondTaskResult = secondTaskGuids.Calculate(secondTaskInput.NumberOfGuids, 3);

                    foreach (var item in secondTaskResult.Items)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (var maxCommonString in secondTaskResult.MaxCommonStrings)
                    {
                        Console.WriteLine(maxCommonString);
                    }
                    break;
            }

            Console.ReadLine();
        }

    }
}
