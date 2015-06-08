using System;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Reflection;

namespace BiryukovTest
{
    class MefLoader
    {
        public static CompositionContainer GetMefContainer()
        {
            string businessLayerFolder = ConfigurationManager.AppSettings["BusinessLayerFolder"];
            var catalog = new AggregateCatalog();
            // TODO: The path is hardcoded for now
            catalog.Catalogs.Add(
                new AssemblyCatalog(
                    Assembly.LoadFile(Environment.CurrentDirectory.Replace(@"\BiryukovTest\bin\Debug", string.Empty)
                                      + businessLayerFolder
                                      + "/BusinessLayer.BusinessTasks.dll")));
            CompositionContainer container = new CompositionContainer(catalog);
            return container;
        }
    }
}