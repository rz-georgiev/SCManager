using HandotaiSeigyo.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace HandotaiSeigyo.Data.Interfaces
{
    public interface IUnitMultiplierService
    {
        IEnumerable<UnitMultiplier> GetAll();
    }
}