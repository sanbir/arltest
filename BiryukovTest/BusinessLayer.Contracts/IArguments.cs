using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Contracts
{
    public interface IArgument
    {

    }

    public interface IArgument<T>:IArgument
    {
        T Value { get; set; }
    }

    public interface ICalculate<in TTaskArguments, out TTaskResult>
    {
        TTaskResult Calculate(TTaskArguments arguments);
    }

    public interface IFirstTask<TItemToReview, TSymbol>
        : ICalculate<FirstTaskArguments<TItemToReview, TSymbol>, IEnumerable<TItemToReview>>
    {
    }

    public interface ISecondTask : ICalculate<SecondTaskArguments, SecondTaskResult>
    {

    }

    public class FirstTaskArgumentsGuidChar : FirstTaskArguments<Guid, char>
    {
    }

    public class FirstTaskArguments<TItemToReview, TSymbol>
    {
        public int NumberOfItemsToReview { get; set; }
        public int NumberOfSymbols { get; set; }
        public TSymbol Symbol { get; set; }
        public IEnumerable<TItemToReview> ItemsToReview { get; set; }
    }

    public class FirstTaskResult
    {

    }

    public class SecondTaskResult
    {

    }

    public class SecondTaskArguments
    {

    }

    public class FirstTaskGuids : IFirstTask<Guid, char>
    {
        public IEnumerable<Guid> Calculate(FirstTaskArguments<Guid, char> arguments)
        {
            var template = new String(arguments.Symbol, arguments.NumberOfSymbols);

            return arguments.ItemsToReview.Where(guid => IsRequirementMet(guid, template));
        }

        private static bool IsRequirementMet(Guid guid, string template)
        {
            var guidString = guid.ToString("N");
            if (guidString.Contains(template)) return true;
            return false;
        }
    }

    public class FirstTaskGuids : IFirstTask<Guid, int>
    {
        public IEnumerable<Guid> Calculate(FirstTaskArguments<Guid, int> arguments)
        {
            var template = new String(arguments.Symbol, arguments.NumberOfSymbols);

            return arguments.ItemsToReview.Where(guid => IsRequirementMet(guid, template));
        }

        private static bool IsRequirementMet(Guid guid, string template)
        {
            var guidString = guid.ToString("N");
            if (guidString.Contains(template)) return true;
            return false;
        }
    }

    public class FirstTaskStrings : IFirstTask<string, char>
    {
        public IEnumerable<string> Calculate(FirstTaskArguments<string, char> arguments)
        {
            var template = new String(arguments.Symbol, arguments.NumberOfSymbols);

            return arguments.ItemsToReview.Where(guid => IsRequirementMet(guid, template));
        }

        private static bool IsRequirementMet(string guid, string template)
        {
            var guidString = guid.ToString("N");
            if (guidString.Contains(template)) return true;
            return false;
        }
    }
}
