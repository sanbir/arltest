using System;
using System.ComponentModel.Composition.Hosting;
using BiryukovTest.Input;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.Second;

namespace BiryukovTest.TaskHelpers
{
    class SecondTaskHelper : ITaskHelper
    {
        public ITaskInput SetTaskInput(string[] args)
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

        public void DisplayTaskResults(IBusinessTaskResult taskResult)
        {
            ISecondTaskResult<string> secondTaskResult = (ISecondTaskResult<string>)taskResult;
            Console.WriteLine("GUIDs:");
            foreach (var item in secondTaskResult.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Max common strings:");
            foreach (var maxCommonString in secondTaskResult.MaxCommonStrings)
            {
                Console.WriteLine(maxCommonString);
            }
        }

        public IBusinessTaskResult RunTask(CompositionContainer container, ITaskInput taskInput)
        {
            var secondTaskGuids = container.GetExportedValue<ISecondTask<Guid, string>>();
            var secondTaskResult = secondTaskGuids.Calculate(((SecondTaskInput)taskInput).NumberOfGuids);
            return secondTaskResult;
        }
    }
}