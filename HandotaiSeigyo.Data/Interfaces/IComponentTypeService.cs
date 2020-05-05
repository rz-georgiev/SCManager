using HandotaiSeigyo.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace HandotaiSeigyo.Data.Interfaces
{
    public interface IComponentTypeService
    {
        IEnumerable<ComponentType> GetAll();

        ComponentType GetById(int id);
    }
}