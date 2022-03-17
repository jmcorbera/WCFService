using System;
using WCFService.Shared.Interfaces;
using WCFService.Shared.Models;

namespace WCFService.DataAccess
{
    public class DataAccess<T> : IDataAccess where T : IEntity
    {
        DBContextList<T> _ctx;

        public DataAccess(DBContextList<T> ctx)
        {
            _ctx = ctx;
        }

        public string GetData(int value)
        {
            if (_ctx.GetDataById(value) == null)
                return string.Format("The object with Id : {0} was not found", value);
            else
                return string.Format("The object with Id : {0} was found", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
