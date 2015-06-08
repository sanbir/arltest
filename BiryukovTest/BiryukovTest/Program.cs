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

namespace BiryukovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositionContainer container = new BootStrap().GetContainer();
            //var businessTaskFactory = container.GetExportedValue<IBusinessTaskFactory>();

            var typeOfTask = int.Parse(args[0]);

            switch (typeOfTask)
            {
                case 1:
                    var amountOfDigits = int.Parse(args[1]);
                    var desiredAmountOfResults = int.Parse(args[2]);

                    var aa = container.GetExportedValue<IFirstTaskArguments<Guid, char>>();
                    aa.SetFirstTaskArguments(amountOfDigits, '0', desiredAmountOfResults);
                    var firstTaskGuids = container.GetExportedValue<IFirstTask<Guid, char>>();
                    
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

            //var longestCommon = strings.GetLongestCommonSubstrings();

            //foreach (var longestString in longestCommon)
            //{
            //    Console.WriteLine(longestString);
            //}

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

    //public interface IMainApplication
    //{
    //    string ProcessCreditRequest(string ssn);
    //}

    //[Export]
    //[Export(typeof(IMainApplication))]
    //public class MainApplication : IMainApplication
    //{
    //    private readonly ICreditProcessor _creditProcessor;

    //    [ImportingConstructor]
    //    public MainApplication(ICreditProcessor creditProcessor)
    //    {
    //        _creditProcessor = creditProcessor;
    //    }

    //    public string ProcessCreditRequest(string ssn)
    //    {
    //        return _creditProcessor.ProcessRequest(ssn);
    //    }
    //}

    //public interface ICreditProcessor
    //{
    //    string ProcessRequest(string ssn);
    //}

    //[Export]
    //[Export(typeof(ICreditProcessor))]
    //public class CreditProcessor : ICreditProcessor
    //{
    //    private readonly IGateway _gateway;
    //    private readonly IDbAccessor _dbAccessor;

    //    [ImportingConstructor]
    //    public CreditProcessor(IGateway gateway,
    //           [Import("dbAccessor", typeof(IDbAccessor))]IDbAccessor dbAccessor)
    //    {
    //        _gateway = gateway;
    //        _dbAccessor = dbAccessor;
    //    }

    //    public string ProcessRequest(string ssn)
    //    {
    //        int creditScore = _gateway.GetCreditScore(ssn);
    //        decimal currentBalance = _dbAccessor.GetOutstandingBalance(ssn);

    //        return currentBalance / creditScore % 2 == 0 ? "Approved" : "Denied";

    //    }
    //}

    //public class ExternalSourcesCatalog : AggregateCatalog
    //{
    //    public ExternalSourcesCatalog()
    //    {
    //        Catalogs.Add(new AssemblyCatalog(typeof(ICreditProcessor).Assembly));
    //        Catalogs.Add(new AssemblyCatalog(typeof(IGateway).Assembly));
    //    }
    //}

    //[Export("dbAccessor", typeof(IDbAccessor))]
    //public class DbAccessor : IDbAccessor
    //{
    //    public decimal GetOutstandingBalance(string ssn)
    //    {
    //        var balance = new Random().Next(100, 20000);
    //        return Convert.ToDecimal(balance);
    //    }
    //}

    //[Export("sqlDbAccessor", typeof(IDbAccessor))]
    //public class SqlDbAccessor : IDbAccessor
    //{
    //    public decimal GetOutstandingBalance(string ssn)
    //    {
    //        var balance = new Random().Next(2000, 200000);
    //        return Convert.ToDecimal(balance);
    //    }
    //}

    //public interface IGateway
    //{
    //    int GetCreditScore(string ssn);
    //}

    //[Export(typeof(IGateway))]
    //public class Gateway : IGateway
    //{
    //    private readonly IEnumerable<ICreditAgencyGateway> _creditAgencies;

    //    [ImportingConstructor]
    //    public Gateway([ImportMany]IEnumerable<ICreditAgencyGateway> creditAgencies)
    //    {
    //        _creditAgencies = creditAgencies;
    //    }

    //    public int GetCreditScore(string ssn)
    //    {
    //        int creditScore = 0;
    //        _creditAgencies.ToList().ForEach(a => creditScore += a.GetScore(ssn));
    //        return creditScore;
    //    }
    //}

    //[Export(typeof(ICreditAgencyGateway))]
    //public class CreditAgency1 : ICreditAgencyGateway
    //{
    //    public int GetScore(string ssn)
    //    {
    //        return new Random().Next(500, 700);
    //    }
    //}


}
