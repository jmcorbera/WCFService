using System;
using WCFService.Shared.Interfaces;
using WCFService.Shared.Models;

namespace WcfService.Business
{
    public class BussinessLogic : IBussinessLogic
    {
        IDataContext _dataContext;

        public BussinessLogic(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public string GetData(int value)
        {
            try
            {
                return _dataContext.GetData(value);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            try
            {
                return _dataContext.GetDataUsingDataContract(composite);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
