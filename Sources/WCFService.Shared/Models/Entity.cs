using System.Runtime.Serialization;
using WCFService.Shared.Interfaces;

namespace WCFService.Shared.Models
{
    [DataContract]
    public class Entity : IEntity
    {
        [DataMember]
        public virtual int Id { get; set; }
    }
}
