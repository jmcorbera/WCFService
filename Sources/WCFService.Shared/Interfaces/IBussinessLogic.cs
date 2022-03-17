using WCFService.Shared.Models;

namespace WCFService.Shared.Interfaces
{
    public interface IBussinessLogic
    {
        string GetData(int value);

        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
