using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessTasks.First;
using BusinessLayer.BusinessTasks.Second;
using BusinessLayer.Contracts;
using BusinessLayer.Contracts.First;
using BusinessLayer.Contracts.Second;

namespace BiryukovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositionContainer container = new BootStrap().GetContainer();

            var typeOfTask = 2;// int.Parse(args[0]);

            switch (typeOfTask)
            {
                case 1:
                    var amountOfDigits = int.Parse(args[1]);
                    var desiredAmountOfResults = int.Parse(args[2]);

                    var aa = container.GetExportedValue<IFirstTaskArguments<Guid, char>>();
                    aa.SetFirstTaskArguments(amountOfDigits, '0', desiredAmountOfResults);
                    var firstTaskGuids = container.GetExportedValue<IFirstTask<Guid, char>>();
                    var result = firstTaskGuids.Calculate(aa);

                    foreach (var item in result.Items)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 2:
                    var numberOfGuids = int.Parse(args[1]);

                    var secondTaskGuids = container.GetExportedValue<ISecondTask<Guid, string>>();
                    var secondTaskResult = secondTaskGuids.Calculate(numberOfGuids);

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

    public class BootStrap
    {
        public CompositionContainer GetContainer()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(FirstTaskGuids).Assembly));

            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            return container;
        }
    }

}
