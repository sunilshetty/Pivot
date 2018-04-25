using Core;
using Core.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPivotService
    {
        Collection<SCRequest> GetAllSCRequestData(SCRequest request);
    }
}
