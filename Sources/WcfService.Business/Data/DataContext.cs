using WCFService.Shared.Interfaces;
using WCFService.Shared.Models;

namespace WcfService.Business.Data
{
    public class DataContext : IDataContext
    {
        IDataAccess _dataAccess;

        public DataContext(IDataAccess ctx)
        {
            _dataAccess = ctx;
        }
        public string GetData(int value)
        {
            return _dataAccess.GetData(value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return _dataAccess.GetDataUsingDataContract(composite);
        }
    }
}
