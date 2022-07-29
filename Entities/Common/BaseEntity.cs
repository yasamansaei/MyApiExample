using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Common
{
    public interface IBaseEntity
    {

    }
    public abstract class BaseEntity<T>:IBaseEntity
    {
        public T Id { get; set; }
    }
   public abstract class BaseEntity:BaseEntity<int>
    {

    }
}
