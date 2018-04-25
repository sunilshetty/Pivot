using Core;
using Core.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public interface IRepository
    {
        Collection<SCRequest> GetAllSCRequestData(SCRequest request);
        Collection<ConnectMe> GetAllConnectMe(ConnectMe request);
    }
}
