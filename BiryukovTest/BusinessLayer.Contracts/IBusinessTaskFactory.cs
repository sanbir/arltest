using System.ComponentModel.Composition.Hosting;

namespace BusinessLayer.Contracts
{
    public interface IBusinessTaskFactory
    {
        TBusinessTask GetBusinessTask<TBusinessTask>() where TBusinessTask : IBusinessTask;
    }
}
