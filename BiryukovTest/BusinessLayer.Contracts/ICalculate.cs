namespace BusinessLayer.Contracts
{
    public interface ICalculate<in TTaskArguments, out TTaskResult>
    {
        TTaskResult Calculate(TTaskArguments arguments);
    }
}