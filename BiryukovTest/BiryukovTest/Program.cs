using System;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using BusinessLayer.Contracts.First;
using BusinessLayer.Contracts.Second;

namespace BiryukovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = MefLoader.GetMefContainer();

            var typeOfTask = GetTypeOfTask(args);

            switch (typeOfTask)
            {
                case 1:
                    var firstTaskInput = SetFirstTaskInput(args);
                    var firstTaskresult = RunFirstTask(container, firstTaskInput);
                    DisplayFirstTaskResults(firstTaskresult);
                    break;
                case 2:
                    var secondTaskInput = SetSecondTaskInput(args);
                    var secondTaskResult = RunSecondTask(container, secondTaskInput);
                    DisplaySeconTaskResults(secondTaskResult);
                    break;
                default:
                    Console.WriteLine("Only tasks 1 and 2 are currently supported.");
                    break;
            }

            Console.ReadLine();
        }

        private static int GetTypeOfTask(string[] args)
        {
            int typeOfTask = 0;
            if (!args.Any())
            {
                while (typeOfTask == 0)
                {
                    Console.Write("Enter type of task: ");
                    try
                    {
                        typeOfTask = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter digits only");
                    }
                }
            }
            else
            {
                typeOfTask = int.Parse(args[0]);
            }
            return typeOfTask;
        }

        private static SecondTaskInput SetSecondTaskInput(string[] args)
        {
            SecondTaskInput secondTaskInput;
            secondTaskInput.NumberOfGuids = 0;

            if (args.Length < 2)
            {
                while (secondTaskInput.NumberOfGuids == 0)
                {
                    Console.Write("Please enter the amount of GUIDs to review (X): ");
                    try
                    {
                        secondTaskInput.NumberOfGuids = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter digits only");
                    }
                }
            }
            else
            {
                secondTaskInput.NumberOfGuids = int.Parse(args[1]);
            }

            return secondTaskInput;
        }

        private static FirstTaskInput SetFirstTaskInput(string[] args)
        {
            FirstTaskInput firstTaskInput;
            firstTaskInput.AmountOfDigits = 0;
            firstTaskInput.DesiredAmountOfResults = 0;

            if (args.Length < 2)
            {
                while (firstTaskInput.AmountOfDigits == 0)
                {
                    Console.Write("Please enter the amount of digits (X): ");
                    try
                    {
                        firstTaskInput.AmountOfDigits = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter digits only");
                    }
                }
            }
            else
            {
                firstTaskInput.AmountOfDigits = int.Parse(args[1]);
            }

            if (args.Length < 3)
            {
                while (firstTaskInput.DesiredAmountOfResults == 0)
                {
                    Console.Write("Please enter the desired amount of results (N): ");
                    try
                    {
                        firstTaskInput.DesiredAmountOfResults = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter digits only");
                    }
                }
            }
            else
            {
                firstTaskInput.DesiredAmountOfResults = int.Parse(args[2]);
            }

            return firstTaskInput;
        }

        private static void DisplaySeconTaskResults(ISecondTaskResult<string> secondTaskResult)
        {
            foreach (var item in secondTaskResult.Items)
            {
                Console.WriteLine(item);
            }
            foreach (var maxCommonString in secondTaskResult.MaxCommonStrings)
            {
                Console.WriteLine(maxCommonString);
            }
        }

        private static void DisplayFirstTaskResults(IFirstTaskResult<Guid> firstTaskresult)
        {
            foreach (var item in firstTaskresult.Items)
            {
                Console.WriteLine(item);
            }
        }

        private static ISecondTaskResult<string> RunSecondTask(CompositionContainer container, SecondTaskInput secondTaskInput)
        {
            var secondTaskGuids = container.GetExportedValue<ISecondTask<Guid, string>>();
            var secondTaskResult = secondTaskGuids.Calculate(secondTaskInput.NumberOfGuids, 3);
            return secondTaskResult;
        }

        private static IFirstTaskResult<Guid> RunFirstTask(CompositionContainer container, FirstTaskInput firstTaskInput)
        {
            var firstTaskArguments = container.GetExportedValue<IFirstTaskArguments<Guid, char>>();
            firstTaskArguments.SetFirstTaskArguments(firstTaskInput.AmountOfDigits, '0', firstTaskInput.DesiredAmountOfResults);
            var firstTaskGuids = container.GetExportedValue<IFirstTask<Guid, char>>();
            var firstTaskresult = firstTaskGuids.Calculate(firstTaskArguments);
            return firstTaskresult;
        }
    }
}
