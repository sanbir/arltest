namespace BusinessLayer.Contracts.BusinessTasks
{
    public interface ISecondTask
        : ICalculate<ISecondTaskArguments<TItemToReview, TSymbol>, IEnumerable<TItemToReview>>
    {

    }
}