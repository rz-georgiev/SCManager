using SCManager.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace SCManager.Data.Interfaces
{
    public interface IComponentTypeService
    {
        IEnumerable<ComponentType> GetAll();

        ComponentType GetById(int id);
    }
}