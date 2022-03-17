using System.ServiceModel;
using WCFService.Shared.Models;

namespace WCFService.Shared.Interfaces
{
    /// <summary>
    /// Defines the behavior of Pre-Authorization Contract  Service
    /// </summary>
    [ServiceContract]
    public interface IWCFService : IBussinessLogic
    {
        [OperationContract]
        new string GetData(int value);

        [OperationContract]
        new CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
