using System;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using BiryukovTest.TaskHelpers;
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

            ITaskHelper taskHelper;
            switch (typeOfTask)
            {
                case 1:
                    taskHelper = new FirstTaskHelper();
                    var firstTaskInput = taskHelper.SetTaskInput(args);
                    var firstTaskresult = taskHelper.RunTask(container, firstTaskInput);
                    taskHelper.DisplayTaskResults(firstTaskresult);
                    break;
                case 2:
                    taskHelper = new SecondTaskHelper();
                    var secondTaskInput = taskHelper.SetTaskInput(args);
                    var secondTaskResult = taskHelper.RunTask(container, secondTaskInput);
                    taskHelper.DisplayTaskResults(secondTaskResult);
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
    }
}
