using System.ComponentModel.Composition.Hosting;
using BiryukovTest.Input;
using BusinessLayer.Contracts;

namespace BiryukovTest.TaskHelpers
{
    interface ITaskHelper
    {
        ITaskInput SetTaskInput(string[] args);

        void DisplayTaskResults(IBusinessTaskResult taskResult);

        IBusinessTaskResult RunTask(CompositionContainer container, ITaskInput taskInput);
    }
}
