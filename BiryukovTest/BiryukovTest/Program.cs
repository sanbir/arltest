using System;
using System.Linq;
using BiryukovTest.TaskHelpers;

namespace BiryukovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = MefLoader.GetMefContainer();

            while (true)
            {
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

                Console.WriteLine("Would you like to quit? (Y/N)");
                string answer = Console.ReadLine();
                if (answer.ToLowerInvariant().StartsWith("y"))
                {
                    return;
                }
            }
        }

        private static int GetTypeOfTask(string[] args)
        {
            int typeOfTask = 0;
            if (!args.Any())
            {
                while (typeOfTask == 0)
                {
                    Console.Write("Enter type of task: ");
                    var input = Console.ReadLine();

                    if (input == "-h" || input == "--help" || input == "/?")
                    {
                        DisplayHelp();
                    }
                    else
                    {
                        try
                        {
                            typeOfTask = int.Parse(input);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter digits only");
                        }
                    }
                }
            }
            else
            {
                typeOfTask = int.Parse(args[0]);
            }
            return typeOfTask;
        }

        private static void DisplayHelp()
        {
            Console.WriteLine();
            Console.WriteLine(@"You can either pass all the paramaters at once or just follow the steps.
In order to pass all the paramaters at once, please enter a number of a task type and the parameters separated by a single whitespace.
For example, 1 6 5 means ""The first type of task, amount of digits (X) = 6, desired amount of results (N) = 5""");
            Console.WriteLine();
        }
    }
}
