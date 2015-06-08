using System;
using System.ComponentModel.Composition.Hosting;
using BiryukovTest.Input;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;

namespace BiryukovTest.TaskHelpers
{
    class FirstTaskHelper : ITaskHelper
    {
        public ITaskInput SetTaskInput(string[] args)
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

        public void DisplayTaskResults(IBusinessTaskResult taskResult)
        {
            foreach (var item in ((IFirstTaskResult<Guid>)taskResult).Items)
            {
                Console.WriteLine(item);
            }
        }

        public IBusinessTaskResult RunTask(CompositionContainer container, ITaskInput taskInput)
        {
            FirstTaskInput firstTaskInput = (FirstTaskInput)taskInput;
            var firstTaskArguments = container.GetExportedValue<IFirstTaskArguments<Guid, char>>();
            firstTaskArguments.SetFirstTaskArguments(firstTaskInput.AmountOfDigits, '0', firstTaskInput.DesiredAmountOfResults);
            var firstTaskGuids = container.GetExportedValue<IFirstTask<Guid, char>>();
            var firstTaskresult = firstTaskGuids.Calculate(firstTaskArguments);
            return firstTaskresult;
        }
    }
}