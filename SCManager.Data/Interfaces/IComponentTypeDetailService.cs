using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Data.Interfaces
{
    public interface IComponentTypeDetailService
    {
        IEnumerable<ComponentTypeDetail> GetByComponentTypeId(int id);
    }
}