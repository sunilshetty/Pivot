using Core;
using Core.BusinessEntities;
using DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PivotService : IPivotService
    {
        public IRepository _repository;
        public PivotService()
        {
            _repository = new Repository();
        }

        public Collection<SCRequest> GetAllSCRequestData(SCRequest request)
        {
            return _repository.GetAllSCRequestData(request);
        }

        public Collection<ConnectMe> GetAllConnectMe(ConnectMe request)
        {
            return _repository.GetAllConnectMe(request);
        }
    }
}
