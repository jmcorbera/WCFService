using System;
using WcfService.Business;
using WcfService.Business.Data;
using WCFService.DataAccess;
using WCFService.Shared.Interfaces;
using WCFService.Shared.Models;

namespace WcfService.Service
{
    public class WCFService : IWCFService
    {
        static DBContextList<CompositeType> _dbContextList = new DBContextList<CompositeType>();
        IBussinessLogic _bussinessLogic;

        public WCFService ()
        {
            Initialize();
        }

        public string GetData(int value)
        {
            return _bussinessLogic.GetData(value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            return _bussinessLogic.GetDataUsingDataContract(composite);
        }

        private void Initialize()
        {
            try
            {
                var _dataAccess = new DataAccess<CompositeType>(_dbContextList);
                var _dataContext = new DataContext(_dataAccess);
                _bussinessLogic = new BussinessLogic(_dataContext);
            }
            catch(Exception ex)
            {
                throw new Exception(string.Format("Initialize Error : error Message {0} ", ex.Message));
            }
        }
    }
}
