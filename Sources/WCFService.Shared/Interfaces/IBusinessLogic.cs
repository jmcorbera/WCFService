using WCFService.Shared.Models;

namespace WCFService.Shared.Interfaces
{
    public interface IBusinessLogic
    {
        string GetData(int value);

        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
