using System;
using System.Collections.Generic;
using System.Linq;
using WCFService.Shared.Interfaces;
using WCFService.Shared.Models;

namespace WCFService.DataAccess
{
    public class DBContextList<T> where T : IEntity
    {
        IList<T> _data;

        public DBContextList()
        {
            _data = new List<T>();
        }

        public T GetDataById(int id)
        {
            return _data.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public CompositeType GetCompositeType(CompositeType composite)
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
