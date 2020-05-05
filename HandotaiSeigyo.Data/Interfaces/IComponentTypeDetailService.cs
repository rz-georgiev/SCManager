using HandotaiSeigyo.Data.Models;
using System.Collections.Generic;

namespace HandotaiSeigyo.Data.Interfaces
{
    public interface IComponentTypeDetailService
    {
        IEnumerable<ComponentTypeDetail> GetByComponentTypeId(int id);
    }
}